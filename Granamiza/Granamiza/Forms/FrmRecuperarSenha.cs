using Granamiza.App.Email;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms
{
    public partial class FrmRecuperarSenha : Form
    {
        public FrmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
            MessageBox.Show("E-mail enviado com sucesso!");
        }

        //Método para enviar E-mail de forma assíncrona na classe Email
        internal static async void EnviarEmail()
        {
            await Email.EnviarAsync();
        }
    }
}
