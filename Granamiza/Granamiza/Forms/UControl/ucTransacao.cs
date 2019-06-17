using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.Modelo;
using Granamiza.Forms.Popup;
using System.Globalization;
using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD;
using Granamiza.App.CRUD.Transacao;

namespace Granamiza.Forms.UControl
{
    public partial class UcTransacao : UserControl
    {
        readonly Button btn_clicado;
        int idTransacao;


        //Campos para atualizar
        decimal valor;
        string nomeCategoria;
        string descricao;
        private Receita objReceita;
        private Despesa objDespesa;
        FrmPrincipal frmPai;


        //Construtor!
        public UcTransacao(Button botao_clicado, FrmPrincipal frm_pai)
        {
            InitializeComponent();
            this.btn_clicado = botao_clicado;
            this.frmPai = frm_pai;
            //objReceita = new Receita();
            //objDespesa = new Despesa();

            DefinirModoLayout();
        }

        //Metodo mais relevante!
        private void UcTransacao_Load(object sender, EventArgs e)
        {
            //Se o botao clicado for de receita, deve se chamar um metodo que defina o datasource
            //do gridview para receber somente os dados de transacões que não são gastos
            if (btn_clicado.Name == "btnMenuReceita")
            {
                objReceita = new Receita();

                AtualizarGrid("receita");

                btnAdicionar.Image = global::Granamiza.Properties.Resources.plus_2_;
            }
            //Se o botao clicado for de receita, deve se chamar um metodo que defina o datasource
            //do gridview para receber somente os dados de transacões que são gastos
            if (btn_clicado.Name == "btnMenuDespesa")
            {
                objDespesa = new Despesa();

                AtualizarGrid("despesa");

                btnAdicionar.Image = global::Granamiza.Properties.Resources.plus__2_;
            }
        }

        private void AtualizarGrid(string btn_clicado)
        {

            if (btn_clicado == "receita")
            {
                //Remover abas denecessárias
                tcTransacao.TabPages.Remove(tabDespesasAPagar);
                tcTransacao.TabPages.Remove(tabDespesasPagas);

                var dadosReceita = objReceita.Listar();

                if (dadosReceita != null)
                {
                    //Recupera as receitas
                    dgvReceitas.DataSource = dadosReceita;
                }
            }

            if (btn_clicado == "despesa")
            {

                tcTransacao.TabPages.Remove(tabReceitasCadastradas);

                var DadosDespesas = objDespesa.Listar();
                var DadosDespesasPagas = objDespesa.ListarDespesasPagas();

                if (DadosDespesas != null)
                {
                    dgvDespesas.DataSource = DadosDespesas;
                }

                if (DadosDespesasPagas != null)
                {
                    dgvDespesasPagas.DataSource = DadosDespesasPagas;

                }
            }
        }

        private void DgvDespesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTransacao = int.Parse(dgvDespesas.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnPagar.Enabled = true;
                CarregarDadosTransacao();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        private void DgvDespesaPagas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTransacao = int.Parse(dgvDespesasPagas.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                CarregarDadosTransacao();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        private void DgvReceita_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTransacao = int.Parse(dgvReceitas.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                CarregarDadosTransacao();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        private void CarregarDadosTransacao()
        {
            if (btn_clicado.Name == "btnMenuReceita")
            {

                var dadosReceitaSelecionada = objReceita.GetReceitaSelecionada(idTransacao);

                if (dadosReceitaSelecionada != null) //Testa se localizou o registro
                {
                    txtValor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}",
                        dadosReceitaSelecionada.valor);

                    txtCategoria.Text = dadosReceitaSelecionada.nome;
                    txtData.Text = dadosReceitaSelecionada.data_criacao.ToShortDateString();
                    txtHora.Text = dadosReceitaSelecionada.data_criacao.ToShortTimeString();
                    txtDesc.Text = dadosReceitaSelecionada.descricao;

                    //Registra os campos recebidos
                    valor = dadosReceitaSelecionada.valor;
                    nomeCategoria = dadosReceitaSelecionada.nome;
                    descricao = dadosReceitaSelecionada.descricao;
                }
            }

            if (btn_clicado.Name == "btnMenuDespesa")
            {

                var dadosDespesaSelecionada = objDespesa.GetDespesaSelecionada(idTransacao);

                if (dadosDespesaSelecionada != null) //Testa se localizou o registro
                {
                    txtValor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}",
                        dadosDespesaSelecionada.valor);

                    txtCategoria.Text = dadosDespesaSelecionada.nome;
                    txtData.Text = dadosDespesaSelecionada.data_criacao.ToShortDateString();
                    txtHora.Text = dadosDespesaSelecionada.data_criacao.ToShortTimeString();
                    txtDesc.Text = dadosDespesaSelecionada.descricao;


                    //Registra os campos recebidos
                    valor = dadosDespesaSelecionada.valor;
                    nomeCategoria = dadosDespesaSelecionada.nome;
                    descricao = dadosDespesaSelecionada.descricao;
                }
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            //Se o botão clicado no menu lateral for o de receita,  ele vai chamar o form de receita
            if (btn_clicado.Name == "btnMenuReceita")
            {
                FrmReceita frm = new FrmReceita();
                frm.Show();
                frm.Closed += (s, args) => this.AtualizarGrid("receita");
            }

            //  Se o botao clicado no menu lateral for o de despesa ele chama o form de despesa
            if (btn_clicado.Name == "btnMenuDespesa")
            {
                FrmDespesa frm = new FrmDespesa();
                frm.Show();
                frm.Closed += (s, args) => this.AtualizarGrid("despesa");
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {

            decimal transacaoValorAPagar = objDespesa.GetDespesaSelecionada(idTransacao).valor;
            decimal saldoAtual = objReceita.GetValorTotal() - objDespesa.GetValorTotalDespesasPagas();

            if (transacaoValorAPagar < saldoAtual)
            {
                objDespesa.Pagar(idTransacao);
                AtualizarGrid("despesa");
                LimparDadosTransacao();
            }

            else
            {
                MessageBox.Show("Você não tem saldo suficiente. :(", "Pagamento não efetuado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void LimparDadosTransacao()
        {
            txtValor.Text = "";
            txtCategoria.Text = string.Empty;
            txtData.Text = string.Empty;
            txtHora.Text = string.Empty;
            txtDesc.Text = string.Empty;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnPagar.Enabled = false;

            dgvDespesas.ClearSelection();
            dgvReceitas.ClearSelection();
            dgvDespesasPagas.ClearSelection();

        }

        private void TabDespesasPagas_Enter(object sender, EventArgs e)
        {
            btnPagar.Visible = false;
            btnAdicionar.Visible = false;
        }

        private void TabReceitasCadastradas_Enter(object sender, EventArgs e)
        {
            btnPagar.Visible = false;
            btnAdicionar.Visible = true;
        }

        private void TabDespesasAPagar_Enter(object sender, EventArgs e)
        {
            btnPagar.Visible = true;
            btnAdicionar.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (btn_clicado.Name == "btnMenuReceita")
            {
                var frmAlterarReceita = new FrmReceita(idTransacao, valor, nomeCategoria, descricao);
                frmAlterarReceita.Show();
                frmAlterarReceita.Closing += (s, args) => CarregarDadosTransacao();
                frmAlterarReceita.Closed += (s, args) => AtualizarGrid("receita");
            }

            else if (btn_clicado.Name == "btnMenuDespesa")
            {
                var frmAlterarDespesa = new FrmDespesa(idTransacao, valor, nomeCategoria, descricao);
                frmAlterarDespesa.Show();
                frmAlterarDespesa.Closing += (s, args) => CarregarDadosTransacao();
                frmAlterarDespesa.Closed += (s, args) => AtualizarGrid("despesa");

            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Excluir esse Registro?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (btn_clicado.Name == "btnMenuReceita")
                {
                    objReceita.Excluir(idTransacao);
                    AtualizarGrid("receita");
                }

                if (btn_clicado.Name == "btnMenuDespesa")
                {
                    objDespesa.Excluir(idTransacao);
                    AtualizarGrid("despesa");
                }

                LimparDadosTransacao();

            }
        }

        private void DefinirModoLayout()
        {
            sbyte dark_mode = Sessao.DarkMode;

            if (dark_mode == 1)
            {
                var cor_back = Color.FromArgb(255, 11, 16, 11);
                var cor_front = Color.Gray;
                var color_back_txt = Color.Gray;
                var color_front_txt = Color.White;

                //-- dgvDespesas
                dgvDespesas.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvDespesas.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvDespesas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvDespesas.BackgroundColor = cor_back;

                dgvDespesas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvDespesas.DefaultCellStyle.BackColor = cor_back;
                dgvDespesas.DefaultCellStyle.ForeColor = cor_front;
                //--

                //-- dgvDespesasPagas
                dgvDespesasPagas.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvDespesasPagas.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvDespesasPagas.BackgroundColor = cor_back;

                dgvDespesasPagas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvDespesasPagas.DefaultCellStyle.BackColor = cor_back;
                dgvDespesasPagas.DefaultCellStyle.ForeColor = cor_front;
                //--

                //-- dgvReceitas
                dgvReceitas.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvReceitas.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvReceitas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvReceitas.BackgroundColor = cor_back;

                dgvReceitas.DefaultCellStyle.BackColor = cor_back;
                dgvReceitas.DefaultCellStyle.ForeColor = cor_front;
                //--

                //-- tabDespesasApagar
                tabDespesasAPagar.BackColor = cor_back;
                tabDespesasAPagar.ForeColor = cor_front;
                //--

                //-- tabDespesasPagas
                tabDespesasPagas.BackColor = cor_back;
                tabDespesasPagas.ForeColor = cor_front;
                //--

                //-- tabDespesasPagas
                tabReceitasCadastradas.BackColor = cor_back;
                tabReceitasCadastradas.ForeColor = cor_front;
                //--

                /*//-- Caixa de valores
                txtData.BackColor = color_back_txt;
                txtDesc.BackColor = color_back_txt;
                txtHora.BackColor = color_back_txt;
                txtCategoria.BackColor = color_back_txt;
                txtValor.BackColor = color_back_txt;

                txtData.ForeColor = color_front_txt;
                txtDesc.ForeColor = color_front_txt;
                txtHora.ForeColor = color_front_txt;
                txtCategoria.ForeColor = color_front_txt;
                txtValor.ForeColor = color_front_txt;
                //--*/

            }

            else
            {
                var cor_back = Color.White;
                var cor_front = Color.Black;
                var color_back_txt = Color.White;
                var color_front_txt = Color.Black;

                //-- dgvDespesas
                dgvDespesas.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvDespesas.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvDespesas.BackgroundColor = cor_back;

                dgvDespesas.DefaultCellStyle.BackColor = cor_back;
                dgvDespesas.DefaultCellStyle.ForeColor = cor_front;
                //--

                //-- dgvDespesasPagas
                dgvDespesasPagas.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvDespesasPagas.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvDespesasPagas.BackgroundColor = cor_back;

                dgvDespesasPagas.DefaultCellStyle.BackColor = cor_back;
                dgvDespesasPagas.DefaultCellStyle.ForeColor = cor_front;
                //--

                //-- dgvReceitas
                dgvReceitas.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvReceitas.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvReceitas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvReceitas.BackgroundColor = cor_back;

                dgvReceitas.DefaultCellStyle.BackColor = cor_back;
                dgvReceitas.DefaultCellStyle.ForeColor = cor_front;
                //--

                //-- tabDespesasApagar
                tabDespesasAPagar.BackColor = cor_back;
                tabDespesasAPagar.ForeColor = cor_front;
                //--

                //-- tabDespesasPagas
                tabDespesasPagas.BackColor = cor_back;
                tabDespesasPagas.ForeColor = cor_front;
                //--

                //-- tabDespesasPagas
                tabReceitasCadastradas.BackColor = cor_back;
                tabReceitasCadastradas.ForeColor = cor_front;
                //--

                /*//-- Caixas de valores
                txtData.BackColor = color_back_txt;
                txtDesc.BackColor = color_back_txt;
                txtHora.BackColor = color_back_txt;
                txtCategoria.BackColor = color_back_txt;
                txtValor.BackColor = color_back_txt;

                txtData.ForeColor = color_front_txt;
                txtDesc.ForeColor = color_front_txt;
                txtHora.ForeColor = color_front_txt;
                txtCategoria.ForeColor = color_front_txt;
                txtValor.ForeColor = color_front_txt;
                //--*/

            }
        }
    }
}