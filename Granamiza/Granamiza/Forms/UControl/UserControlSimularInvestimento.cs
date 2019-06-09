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
    public partial class UserControlSimularInvestimento : UserControl
    {
        int idSimulacao;
        public UserControlSimularInvestimento()
        {
            InitializeComponent();
        }

        //Chama método para atualizar dados do data grid view
        private void UserControlSimularInvestimento_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        //Ao clicar no botão calcular, é calculado o valor e salva a simulação no banco de dados 
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double rendTotal;
            rendTotal = CalcularInvestimento(numValor.Value, numJuros.Value, numAplicacoesMensais.Value, Convert.ToInt32(numQntMeses.Value));

            SimulacaoInvestimento.Salvar(numValor.Value, numJuros.Value, numAplicacoesMensais.Value, Convert.ToInt32(numQntMeses.Value), rendTotal);

            AtualizarGrid();
        }

        //Calcula rendimento total do investimento com base nos valores inseridos pelo usuário
        private double CalcularInvestimento(decimal valor, decimal juros, decimal aplicacoesMensais, int meses)
        {
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

        //
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            SimulacaoInvestimento.Excluir(idSimulacao);
            AtualizarGrid();
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

        //Recupera o id da simulação com clique simples, possibilitando uma ação de exclusão mais prática
        private void dgvSimulacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSimulacao = int.Parse(dgvSimulacao.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        //Evento de duplo clique em linha - Chama método de recuperar os valores de simulação selecionada para caixas de texto
        private void DgvSimulacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSimulacao = int.Parse(dgvSimulacao.Rows[e.RowIndex].Cells[0].Value.ToString());
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

    }
}

