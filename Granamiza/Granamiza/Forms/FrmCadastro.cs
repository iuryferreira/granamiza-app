using System;
using System.Windows.Forms;
using Granamiza.Modelo;
using Granamiza.Forms.Popup;
using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD;
using System.Drawing;

namespace Granamiza.Forms
{
    public partial class FrmCadastro : Form
    {


        //------------------------------ Construtores --------------------------------------

        //Atributo para guardar o form de login
        private readonly Form frmlogin;

        //Construtor que recebe o form de login para manter informaçoes sobre ele
        public FrmCadastro(Form frmLogin)
        {
            this.frmlogin = frmLogin;
            InitializeComponent();
        }

        //Construtor Padrão
        public FrmCadastro()
        {
            InitializeComponent();
        }

        //------------------------- Eventos de Carregamento do Form -----------------------------

        //Executado ao form ser carregado.
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            //Ao abrir form, cursor ativado na caixa de texto do nome.
            this.ActiveControl = txtNome;
            rbJohn.Checked = true;
            btnSalvar.Enabled = false;
        }

        //Executado ao form ser fechado
        private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ao fechar o form, exibirá novamente o form de login que foi minimizado
            this.frmlogin.WindowState = FormWindowState.Normal;
        }

        //--------------------------- Eventos de Foco em Elemento Específico ----------------------

        // Cor das linhas quando estiverem em foco.

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaNome, txtNome);
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaEmail, txtEmail);
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaSenha, txtSenha);
        }

        private void TxtConSenha_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaConSenha, txtConSenha);
        }


        // Cor das linhas quando não estiverem em foco.
        // Limpando o label de validação a cada campo focado.

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaNome, txtNome);
            lblNomeErro.Text = "";
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaEmail, txtEmail);
            lblEmailErro.Text = "";
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaSenha, txtSenha);
            lblSenhaErro.Text = "";
        }

        private void TxtConSenha_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaConSenha, txtConSenha);
            lblConSenhaErro.Text = "";
        }


        //------------------------ Eventos do botão de radio do Avatar ----------------------


        //Muda a cor do botão de rádio selecionado

        private void RbJohn_CheckedChanged(object sender, EventArgs e)
        {
            rbJohn.ForeColor = Color.SeaGreen;
            rbJoana.ForeColor = Color.FromArgb(64, 64, 64);
        }

        //mudar a cor caso o avatar joana seja checkado
        private void RbJoana_CheckedChanged(object sender, EventArgs e)
        {
            rbJohn.ForeColor = Color.FromArgb(64, 64, 64);
            rbJoana.ForeColor = System.Drawing.Color.SeaGreen;
        }

        //Limpa a mensagem de erro do checked termos de uso
        private void ChkTermosUso_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkTermosUso.Checked)
            {
                btnSalvar.Enabled = false;
            }

            else
            {
                btnSalvar.Enabled = true;
            }

        }


        //------------------------ Evento dos Botões ------------------------------------------

        //Evento do botão Salvar.
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }


        //-------------------------- Métodos Utilizados nos Eventos -----------------------

        //Salvar usuário e suas preferências. 
        private void Salvar()
        {
            Label[] lblErros = { lblNomeErro, lblEmailErro, lblSenhaErro, lblConSenhaErro};


            //Testa se validou ou não. Se validou prossegue com a operação.
            if (!Validacao.Validar(txtNome, txtEmail, txtSenha, txtConSenha, lblErros))
            {
                return;
            }

            try
            {
                Usuario.Salvar(txtNome, txtEmail, txtSenha, rbJoana);
                _ = new FrmPopupSucesso(this);
            }

            catch (Exception)
            {
                _ = new FrmPopupErro();
                LimparForm();
                return;
            }

            finally
            {
                //instanciar pop-up de sucesso passando form de cadastro como referência, o texto desejado, e o tipo de aviso.
               
                
            }
        }

        //Volta o formulário para o estado original.
        private void LimparForm()
        {
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtConSenha.Text = String.Empty;
            chkTermosUso.CheckState = CheckState.Unchecked;
        }

        private void GbDadosUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
