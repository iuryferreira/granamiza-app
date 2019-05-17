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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        //Muda cor do titulo ao passsar o mouse
        private void LblTitulo_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = System.Drawing.Color.Khaki;
        }

        //Muda cor do titulo ao retirar o mouse
        private void LblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
        }

        //evento de clique de cadastratar
        private void LnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Instanciando o formulario de cadastro
            FrmCadastro frmCadastrar = new FrmCadastro(this);
            frmCadastrar.Show();

            //Minimizando o form de login
            this.WindowState = FormWindowState.Minimized;

            //Exibindo o form de cadastro
            frmCadastrar.WindowState = FormWindowState.Normal;

        }

        //cor da linha do email ao entrar em foco
        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaEmail);
        }
        //cor da linha do email ao sair de foco
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaEmail);

        }
        //cor da linha da senha ao entrar em foco
        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaSenha);
        }
        //cor da linha da senha ao sair de foco
        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaSenha);

        }

        //Evento de clique do entrar
        private void BtnEntrar_Click(object sender, EventArgs e)
        {

        }


    }
}
