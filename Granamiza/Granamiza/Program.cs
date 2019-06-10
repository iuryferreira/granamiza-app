using System;
using System.Windows.Forms;
using Granamiza.Forms;
using Granamiza.Forms.RedefinirSenha;

namespace Granamiza
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
