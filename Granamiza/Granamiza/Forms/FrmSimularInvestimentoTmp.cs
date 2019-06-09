using Granamiza.App.CRUD;
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
    public partial class FrmSimularInvestimentoTmp : Form
    {
        public FrmSimularInvestimentoTmp()
        {
            InitializeComponent();

            using (var bd = new granamizaEntities())
            {
                this.dataGridView1.DataSource = bd.simulacao.ToList();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Valor juros: " + numJuros.Value);
            double rendTotal;
            rendTotal = CalcularInvestimento(numValor.Value, numJuros.Value, numAplicacoesMensais.Value, Convert.ToInt32(numQntMeses.Value));

            SimulacaoInvestimento.Salvar(numValor.Value, numJuros.Value, numAplicacoesMensais.Value, Convert.ToInt32(numQntMeses.Value), rendTotal);
        }

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
            lblTotal.Text = valorTotalFormatado;
            return valorTotal;
        }
    }
}
