using Granamiza.App.Autenticacao;
using Granamiza.Forms.UControl;
using Granamiza.Modelo;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Granamiza.Forms
{
    public partial class FrmPrincipal : Form
    {
        //Valores padrões
        int id_usuario_logado;
        readonly string nome_usuario = "John";
        readonly string avatar_usuario = "C:\\Users\\Mag\\source\\repos\\iuryferreira\\granamiza-app\\Granamiza\\Granamiza\\Imagens\\female.png";

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

            lblBemVindo.Text = "Seja bem vindo(a), " + nome_usuario;
            pbAvatar.ImageLocation = avatar_usuario;

            ReceberValores();

        }

        private void ReceberValores()
        {
            decimal saldoAtual = 0;
            using (var bd = new granamizaEntities())
            {
                graficoGastoCategoria.DataSource = bd.vwtotalcategoria.Where(u => u.usuario_id == Sessao.IdUsuario).ToList();

                int qtdReceita = bd.vwreceita.Count(r => r.usuario_id == Sessao.IdUsuario);
                int qtdDespesas = bd.vwdespesa.Count(d => d.usuario_id == Sessao.IdUsuario);
                int qtdDespesasPagas = bd.vwdespesa.Where(dp => dp.usuario_id == Sessao.IdUsuario).Where(dp => dp.debitada == true).Count();
                decimal despesasPagas;

                if(qtdDespesasPagas != 0)
                {
                    despesasPagas = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Where(d => d.debitada == true).Sum(d => d.valor);
                }

                else
                {
                    despesasPagas = 0;
                }

                if (qtdReceita != 0)
                {
                    
                    decimal valorReceitaTotal = bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor);
                    saldoAtual = valorReceitaTotal - despesasPagas;
                    var valorReceitaTotalFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,###.##} R$", valorReceitaTotal);
                    var saldoAtualFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:#,###.##} R$", saldoAtual);

                    btnReceita.Text = valorReceitaTotalFormatado;
                    btnSaldoAtual.Text = saldoAtualFormatado;
                }

                else
                {
                    btnReceita.Text = "0,00 R$";
                }

                if (qtdDespesas != 0)
                {
                    decimal valorDespesaTotal = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Sum(d => d.valor) - despesasPagas;
                    var valorDespesaTotalFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), " {0:#,###.##} R$", valorDespesaTotal);
                    btnDespesa.Text = valorDespesaTotalFormatado;

                }

                else
                {
                    btnDespesa.Text = "0,00 R$";
                }
            }

            if(saldoAtual < 0)
            {
                btnSaldoAtual.ForeColor = Color.FromArgb(191, 93, 101);
                gpVisaoGeral.BackColor = Color.FromArgb(191, 93, 101);
            }
            else
            {

                btnSaldoAtual.ForeColor = Color.FromArgb(119, 160, 112);
                gpVisaoGeral.BackColor = Color.FromArgb(119, 160, 112);
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
            pnlConteudo.Controls.Add(graficoGastoCategoria);
            pnlConteudo.Controls.Add(pbAjuda);
            pnlConteudo.Controls.Add(lblAjuda);
            pnlConteudo.Controls.Add(lblOla);
        }


        //Limpa o painel de conteudo adicionar o titulo, e adiciona o usercontrol de transacao
        private void BtnMenuReceita_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Gerenciamento de Receita";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UserControlTransacao uc = new UserControlTransacao(btnMenuReceita);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);

        }

        //Volta pra tela inicial ao clicar no Label
        private void BtnMenuDespesa_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Gerenciamento de Despesa";
            lblBemVindo.ForeColor = Color.FromArgb(191, 93, 101);
            UserControlTransacao uc = new UserControlTransacao(btnMenuDespesa);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnSimulacao_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Simulador de Investimentos";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UserControlSimularInvestimento uc = new UserControlSimularInvestimento();
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnCotacao_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Cotações";
            lblBemVindo.ForeColor = Color.FromArgb(191, 93, 101);
            UserControlCotacao uc = new UserControlCotacao();
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void PbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void LnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnDespesa_Click(object sender, EventArgs e)
        {
            this.BtnMenuDespesa_Click(sender, e);
        }

        private void BtnReceita_Click(object sender, EventArgs e)
        {
            this.BtnMenuReceita_Click(sender, e);
        }
    }
}
