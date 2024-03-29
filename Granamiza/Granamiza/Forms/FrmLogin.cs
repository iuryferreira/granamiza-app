﻿using System;
using System.Windows.Forms;
using Granamiza.App.Autenticacao;
using Granamiza.Forms.Popup;
using Granamiza.Forms.RedefinirSenha;

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
            lblTitulo.ForeColor = System.Drawing.Color.White;
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
            MeusWidgets.CorFocoLinhaForm(linhaEmail, txtEmail);
            txtEmail.ForeColor = System.Drawing.Color.Khaki;
        }
        //cor da linha do email ao sair de foco
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaEmail, txtEmail);
        }
        //cor da linha da senha ao entrar em foco
        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaSenha, txtSenha);
            txtSenha.ForeColor = System.Drawing.Color.Khaki;
        }
        //cor da linha da senha ao sair de foco
        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaSenha, txtSenha);
            txtSenha.ForeColor = System.Drawing.Color.White;
        }

        //Evento de clique do entrar
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            
            if (Autenticacao.Autenticar(txtEmail.Text.Trim(), txtSenha.Text.Trim(), lblErroAutenticacao))
            {
                //Retornar os dados para a tela principal
                //


                //Solução somente para testes

                //Oculta o login
                this.Hide();
                this.txtSenha.Clear(); 
                
                //chama o form principal
                //var formPrincipal = new FrmPrincipal();
                var formPrincipal = new FrmPrincipal();
                formPrincipal.Closed += (s, args) => this.Show();
                formPrincipal.Show();
                

            }
            else
            {
                LimparForm();
            }
        }

        private void LimparForm()
        {
            txtSenha.Text = String.Empty;
        }

        private void LnkCadastrar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro frm = new FrmCadastro(this);
            frm.Show();

            this.WindowState = FormWindowState.Minimized;

            frm.WindowState = FormWindowState.Normal;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmRedefinirSenha = new FrmRedefinirSenha(this);
            this.Hide();
            frmRedefinirSenha.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblErroAutenticacao.Visible = false;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            lblErroAutenticacao.Visible = false;
        }
    }
}
