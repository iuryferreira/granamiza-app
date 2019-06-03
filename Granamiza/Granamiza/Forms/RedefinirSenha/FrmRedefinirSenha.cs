using Granamiza.App.Autenticacao;
using Granamiza.App.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms.RedefinirSenha
{
    public partial class FrmRedefinirSenha : Form
    {
        public FrmRedefinirSenha()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {

            if (!Email.Validar(txtEmail))
            {
                return;
            }

            //Gerar código que será enviado para o E-mail
            Sessao.GerarCodigo();
            EnviarEmail();

            var ucCodigo = new UserControlCodigoSenha(this);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(ucCodigo);
            lblDesc.Text = "Insira o código recebido por você  no seu email, \r\npara que possamos redefinir a" +
    " sua senha.\r\n \r\n";
            linkVoltar.Visible = true;
        }

        internal static async void EnviarEmail()
        {
            await Email.EnviarAsync();
        }
    }
}
