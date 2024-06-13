namespace Projeto_GlicNow
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grpDadosAcesso = new System.Windows.Forms.GroupBox();
            this.ckbSalvaLogin = new System.Windows.Forms.CheckBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.grpDadosAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosAcesso
            // 
            this.grpDadosAcesso.Controls.Add(this.ckbSalvaLogin);
            this.grpDadosAcesso.Controls.Add(this.lblSenha);
            this.grpDadosAcesso.Controls.Add(this.txtSenha);
            this.grpDadosAcesso.Controls.Add(this.txtUsuario);
            this.grpDadosAcesso.Controls.Add(this.lblUsuario);
            this.grpDadosAcesso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosAcesso.ForeColor = System.Drawing.Color.Black;
            this.grpDadosAcesso.Location = new System.Drawing.Point(15, 12);
            this.grpDadosAcesso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDadosAcesso.Name = "grpDadosAcesso";
            this.grpDadosAcesso.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDadosAcesso.Size = new System.Drawing.Size(302, 100);
            this.grpDadosAcesso.TabIndex = 0;
            this.grpDadosAcesso.TabStop = false;
            // 
            // ckbSalvaLogin
            // 
            this.ckbSalvaLogin.AutoSize = true;
            this.ckbSalvaLogin.Checked = true;
            this.ckbSalvaLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSalvaLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSalvaLogin.Location = new System.Drawing.Point(12, 73);
            this.ckbSalvaLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbSalvaLogin.Name = "ckbSalvaLogin";
            this.ckbSalvaLogin.Size = new System.Drawing.Size(128, 22);
            this.ckbSalvaLogin.TabIndex = 6;
            this.ckbSalvaLogin.Text = "Salva Login?";
            this.ckbSalvaLogin.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(8, 49);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 18);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(97, 49);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(198, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(97, 18);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(8, 18);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(15, 144);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(170, 144);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(148, 45);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Location = new System.Drawing.Point(15, 115);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(100, 23);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Tem Cadastro?";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(325, 201);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDadosAcesso);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpDadosAcesso.ResumeLayout(false);
            this.grpDadosAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosAcesso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.CheckBox ckbSalvaLogin;
        private System.Windows.Forms.Button btnCadastro;
    }
}

