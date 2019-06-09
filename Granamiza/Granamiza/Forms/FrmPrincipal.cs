using Granamiza.App.Autenticacao;
using Granamiza.Forms.Popup;
using Granamiza.Forms.UControl;
using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms
{
    public partial class FrmPrincipal : Form
    {
        //Valores padrões
        int id_usuario_logado;
        string nome_usuario = "John";
        string avatar_usuario = "C:\\Users\\Mag\\source\\repos\\iuryferreira\\granamiza-app\\Granamiza\\Granamiza\\Imagens\\female.png";

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
            pbAvatar.ImageLocation = avatar_usuario;

            ReceberValores();
        }

        private void ReceberValores()
        {
            using (var bd = new granamizaEntities())
            {

                var qtdReceita = bd.vwreceita.Count(r => r.usuario_id == Sessao.IdUsuario);
                var qtdDespesas = bd.vwdespesa.Count(r => r.usuario_id == Sessao.IdUsuario);

                if (qtdReceita != 0)
                {
                    decimal valorReceitaTotal = bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor);
                    var valorReceitaTotalFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,###.##} R$", valorReceitaTotal);
                    lblValorReceitaTotal.Text = valorReceitaTotalFormatado;
                }

                else
                {
                    lblValorReceitaTotal.Text = "0,00 R$";
                }

                if (qtdDespesas != 0)
                {
                    decimal valorDespesaTotal = bd.vwdespesa.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor);
                    var valorDespesaTotalFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), " {0:#,###.##} R$", valorDespesaTotal);
                    lblValorDespesaTotal.Text = valorDespesaTotalFormatado;

                }

                else
                {
                    lblValorDespesaTotal.Text = "0,00 R$";
                }
            }

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
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(gpVisaoGeral);
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
            lblBemVindo.ForeColor = Color.FromArgb(191, 93, 101);
            UserControlTransacao uc = new UserControlTransacao(btnDespesa);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnSimulacao_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Simulador de Investimentos";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UserControlSimularInvestimento uc = new UserControlSimularInvestimento(btnSimulacao);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnAdicionarDespesa_Click(object sender, EventArgs e)
        {
            FrmDespesa frmDes = new FrmDespesa();
            frmDes.Show();
            frmDes.Closed += (s, args) => this.ReceberValores();

        }

        private void BtnAdicionarReceita_Click(object sender, EventArgs e)
        {
            FrmReceita frmReceita = new FrmReceita();
            frmReceita.Show();
            frmReceita.Closed += (s, args) => this.ReceberValores();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?",
                       "Saindo...",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
