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

namespace Granamiza.Forms.UControl
{
    public partial class UcSimularInvestimento : UserControl
    {
        int idSimulacao;
        FrmPrincipal frmPai;

        public UcSimularInvestimento(FrmPrincipal frm_pai)
        {
            InitializeComponent();
            this.frmPai = frm_pai;
            DefinirModoLayout();
        }

        //Chama método para atualizar dados do data grid view
        private void UserControlSimularInvestimento_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        //Ao clicar no botão calcular, é calculado o valor e salva a simulação no banco de dados 
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (numValor.Value <= 0 && numJuros.Value <= 0 && numQntMeses.Value <= 0)
            {
                MessageBox.Show("Preencha os dados obrigatórios com valores maiores que 0.");
                return;
            }
            double rendTotal;
            rendTotal = CalcularInvestimento(numValor.Value, numJuros.Value, numAplicacoesMensais.Value, Convert.ToInt32(numQntMeses.Value));

            SimulacaoInvestimento.Salvar(numValor.Value, numJuros.Value, numAplicacoesMensais.Value, Convert.ToInt32(numQntMeses.Value), rendTotal);

            AtualizarGrid();
        }

        //Calcula rendimento total do investimento com base nos valores inseridos pelo usuário
        private double CalcularInvestimento(decimal valor, decimal juros, decimal aplicacoesMensais, int meses)
        {
            //Converter demais valores para double para cálculo
            double valorTotal = Convert.ToDouble(valor);
            double jurosDouble = Convert.ToDouble(juros);
            double aplicacoesM = Convert.ToDouble(aplicacoesMensais);

            for (int i = 0; i < meses; i++)
            {
                valorTotal += (jurosDouble * valorTotal / 100) + aplicacoesM;
            }

            var valorTotalFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", valorTotal);
            lblRendimentoTotal.Text = valorTotalFormatado;
            return valorTotal;
        }

        //Excluir simulação selecionada
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            SimulacaoInvestimento.Excluir(idSimulacao);
            AtualizarGrid();
            LimparDados();
        }

        //Atualizar dados do data grid view
        private void AtualizarGrid()
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    this.dgvSimulacao.DataSource = bd.simulacao.Where(s => s.usuario_id == Sessao.IdUsuario).OrderByDescending(s => s.id).ToList();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }

        }

        //Chama método de recuperar os valores de simulação selecionada para caixas de texto
        private void DgvSimulacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSimulacao = int.Parse(dgvSimulacao.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnCalcular.Enabled = true;
                btnLimpar.Enabled = true;
                btnRemover.Enabled = true;
                CarregarDadosSimulacao();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        //Carrega os valores recuperados para as caixas de texto
        private void CarregarDadosSimulacao()
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    if (idSimulacao > 0)
                    {
                        simulacao s = (from sim in bd.simulacao
                                       where sim.id == idSimulacao
                                       select sim).FirstOrDefault();

                        if (s != null) //Testa se localizou o registro
                        {
                            numValor.Value = s.valor_inserido;
                            numJuros.Value = s.juros;
                            txtData.Text = s.data_criacao.ToString();
                            txtHora.Text = s.data_criacao.Value.ToShortTimeString();
                            numAplicacoesMensais.Value = s.aplicacoes_mensais;
                            numQntMeses.Value = s.qnt_meses;
                            lblRendimentoTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", s.rendimento_total);
                        }
                    }
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        //--- Ao clicar em algum campo, invoca método que apagam data e hora
        private void NumValor_Click(object sender, EventArgs e)
        {
            LimparDataHora();
        }

        private void NumJuros_Click(object sender, EventArgs e)
        {
            LimparDataHora();
        }

        private void NumAplicacoesMensais_Click(object sender, EventArgs e)
        {
            LimparDataHora();
        }

        private void NumQntMeses_Click(object sender, EventArgs e)
        {
            LimparDataHora();
        }

        //Limpa data e hora
        private void LimparDataHora()
        {
            txtData.Text = String.Empty;
            txtHora.Text = String.Empty;
        }

        //Limpa todos os dados das caixas de texto
        private void LimparDados()
        {
            numValor.Value = 0;
            numJuros.Value = 0;
            numAplicacoesMensais.Value = 0;
            numQntMeses.Value = 0;
            lblRendimentoTotal.Text = String.Empty;
            txtData.Text = String.Empty;
            txtHora.Text = String.Empty;
            btnLimpar.Enabled = false;
            btnRemover.Enabled = false;
        }

        private void DefinirModoLayout()
        {
            sbyte dark_mode = Sessao.DarkMode;

            if (dark_mode == 1)
            {
                var cor_back = Color.FromArgb(255, 11, 16, 11);
                var cor_front = Color.Gray;
                var color_back_txt = Color.DimGray;

                //-- DgvDespesasPagas
                dgvSimulacao.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvSimulacao.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvSimulacao.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvSimulacao.BackgroundColor = cor_back;

                dgvSimulacao.DefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvSimulacao.DefaultCellStyle.BackColor = cor_back;
                dgvSimulacao.DefaultCellStyle.ForeColor = cor_front;
                //--

            }

            else
            {
                var cor_back = Color.White;
                var cor_front = Color.Black;
                var color_back_txt = Color.White;

                //-- DgvDespesasPagas
                dgvSimulacao.ColumnHeadersDefaultCellStyle.BackColor = cor_back;
                dgvSimulacao.ColumnHeadersDefaultCellStyle.ForeColor = cor_front;
                dgvSimulacao.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvSimulacao.BackgroundColor = cor_back;

                dgvSimulacao.DefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 160, 112);
                dgvSimulacao.DefaultCellStyle.BackColor = cor_back;
                dgvSimulacao.DefaultCellStyle.ForeColor = cor_front;
                //--

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }
    }
}