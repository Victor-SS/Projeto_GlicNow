using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_GlicNow
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void AbrirForm(Form form)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == form.Name)
                {
                    filho.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string senhaCriptografada = Global.Criptografar(txtSenha.Text);
                Usuario usuario = new Usuario();
                usuario.login = txtUsuario.Text;
                usuario.Consultar();
                if(usuario.id == 0)
                {
                    MessageBox.Show("Usuário e/ou senha invalidos", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!usuario.Autenticar(senhaCriptografada))
                {
                    MessageBox.Show("Usuário e/ou senha invalidos", "Login",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Bem vindo {usuario.nomeCompleto}.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.IdUsuarioLogado = usuario.id;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Tag = "Cadastro";
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Tag = "";
        }

    }
}
