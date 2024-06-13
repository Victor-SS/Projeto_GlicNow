using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_GlicNow
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Global.LerAppConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmCadastro cadastro = new frmCadastro();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.Tag.ToString() == "Cadastro")
            {                
                cadastro.ShowDialog();
            }
            if(login.DialogResult == DialogResult.OK || cadastro.DialogResult== DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }            
        }
    }
}
