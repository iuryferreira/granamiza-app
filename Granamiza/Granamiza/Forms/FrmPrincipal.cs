using Granamiza.Forms.UControl;
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
    public partial class FrmPrincipal : Form
    {
        //Valores retornados do login
        int id_usuario_logado;
        string nome_usuario = "John";
        string avatar_usuario = "Granamiza\\Granamiza\\Imagens\\male";
        

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Formulario anterior, passa o id do usuario logado para cá.
        public FrmPrincipal(int id_usuario, string nome, string avatar)
        {
            InitializeComponent();
            this.id_usuario_logado = id_usuario;
            this.nome_usuario = nome;
            this.avatar_usuario = avatar;
            lblBemVindo.Text = "Bem Vindo ao Granamiza, " + nome_usuario;

        }

        private void VisaoGeralUC_Load(object sender, EventArgs e)
        {
            //Aqui carregaria nos lbls de valor, os valores da calculo geral da receita e das despesas.

        }

        //Menu

        //Esconde o Menu
        private void PbLogo_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void EsconderMenu()
        {
            if (pnlMenu.Size.Width == 44)
            {
                pnlMenu.Size = new Size(170, pnlMenu.Height);
            }

            else
            {
                pnlMenu.Size = new Size(44, pnlMenu.Height);
            }
        }

        //Muda o nome de titulo, e mostra o usercontrol visão geral
        private void LblTitulo_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Bem Vindo ao Granamiza, " + nome_usuario;
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UcVisaoGeral uc = new UcVisaoGeral();
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }


        //Limpa o painel de conteudo adicionar o titulo, e adiciona o usercontrol de transacao
        private void BtnReceita_Click(object sender, EventArgs e)
        {

            lblBemVindo.Text = "Gerenciamento de Receita";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UserControlTransacao uc = new UserControlTransacao(btnReceita);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);

        }

        //Volta pra tela inicial ao clicar no Label
        private void BtnDespesa_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Gerenciamento de Despesa";
            lblBemVindo.ForeColor = Color.FromArgb(191,93, 101);
            UserControlTransacao uc = new UserControlTransacao(btnDespesa);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }
    }
}
