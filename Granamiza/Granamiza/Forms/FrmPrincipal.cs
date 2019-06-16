using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD.Categoria;
using Granamiza.App.CRUD.Transacao;
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
        //readonly string nome_usuario = "John";
        private readonly Receita objReceita;
        private readonly Despesa objDespesa;
        private readonly CategoriaDespesa objCategoriaDespesa;

        public FrmPrincipal()
        {
            InitializeComponent();

            lblBemVindo.Text = "Seja bem vindo(a), " + Sessao.NomeUsuario;
            pbAvatar.ImageLocation = Sessao.AvatarUsuario;

            objReceita = new Receita();
            objDespesa = new Despesa();
            objCategoriaDespesa = new CategoriaDespesa();

            AtualizarValores();
        }

        private void AtualizarValores()
        {
            graficoGastoCategoria.DataSource = null;

            graficoGastoCategoria.DataSource = objCategoriaDespesa.ListarQuantidadeCategorias();

            decimal valorDespesas = objDespesa.GetValorTotal();
            decimal valorDespesasPagas = objDespesa.GetValorTotalDespesasPagas();
            decimal valorReceitaTotal = objReceita.GetValorTotal();
            decimal valorDespesasAtivas = valorDespesas - valorDespesasPagas;
            decimal saldoAtual = valorReceitaTotal - valorDespesasPagas;

            
            SetValorTexto(valorReceitaTotal, btnReceita);
            SetValorTexto(saldoAtual, btnSaldoAtual);

            if(saldoAtual > 0)
            {
                btnSaldoAtual.ForeColor = Color.FromArgb(119, 160, 112);
                gpVisaoGeral.BackColor = Color.FromArgb(119, 160, 112);
            }

            else
            {
                btnSaldoAtual.ForeColor = Color.FromArgb(191, 93, 101);
                gpVisaoGeral.BackColor = Color.FromArgb(191, 93, 101);
            }

            if(valorDespesasAtivas > 0)
            {
                SetValorTexto(valorDespesasAtivas, btnDespesa);
            }
            else
            {
                btnDespesa.Text = "R$ 0,00";
            }
        }

        private void SetValorTexto(decimal valor, Button btn)
        {
            if (valor != 0)
            {
                var valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valor);
                btn.Text = valorFormatado;
            }
            else
            {
                btn.Text = "R$ 0,00";
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
            lblBemVindo.Text = "Bem Vindo ao Granamiza, " + Sessao.NomeUsuario;
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(gpVisaoGeral);
            pnlConteudo.Controls.Add(graficoGastoCategoria);
            pnlConteudo.Controls.Add(pbAjuda);
            pnlConteudo.Controls.Add(lblAjuda);
            pnlConteudo.Controls.Add(lblOla);
            AtualizarValores();
        }

        private void BtnDespesa_Click(object sender, EventArgs e)
        {
            this.BtnMenuDespesa_Click(sender, e);
        }

        private void BtnReceita_Click(object sender, EventArgs e)
        {
            this.BtnMenuReceita_Click(sender, e);
        }
        //Limpa o painel de conteudo adicionar o titulo, e adiciona o usercontrol de transacao
        private void BtnMenuReceita_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Gerenciamento de Receita";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UcTransacao uc = new UcTransacao(btnMenuReceita);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        //Volta pra tela inicial ao clicar no Label
        private void BtnMenuDespesa_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Gerenciamento de Despesa";
            lblBemVindo.ForeColor = Color.FromArgb(191, 93, 101);
            UcTransacao uc = new UcTransacao(btnMenuDespesa);
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnSimulacao_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Simulador de Investimentos";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UcSimularInvestimento uc = new UcSimularInvestimento();
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }

        private void BtnCotacao_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Cotações";
            lblBemVindo.ForeColor = Color.FromArgb(191, 93, 101);
            UcCotacao uc = new UcCotacao();
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

        private void btnPreferencias_Click(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Preferências";
            lblBemVindo.ForeColor = Color.FromArgb(119, 160, 112);
            UcPreferencias uc = new UcPreferencias();
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(uc);
        }
    }
}
