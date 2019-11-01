using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.App.API;

namespace Granamiza.Forms.UControl
{
    public partial class UcCotacao : UserControl
    {
        Cotacao objCotacao;
        int idCotacao = 0;

        public UcCotacao()
        {
            //Mudar pro FormPrincipal
            objCotacao = new Cotacao();

            InitializeComponent();

            btnDolarAlta.Text = " R$ " + Dolar.ValorAlta;
            btnDolarBaixa.Text = " R$ " + Dolar.ValorBaixa;
            txtUltimaAtualização.Text = Dolar.DataConsulta.ToString();
            btnEuroAlta.Text = " R$ "+ Euro.ValorAlta;
            btnEuroBaixa.Text = " R$ "+ Euro.ValorBaixa;
            btnBitcoinAlta.Text = " R$ " + Bitcoin.ValorAlta;
            btnBitcoinBaixa.Text = " R$ " + Bitcoin.ValorBaixa;
            AtualizarGrid();
            lblTituloGridView.Focus();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Dolar.ValorAlta != null && Euro.ValorAlta != null && Bitcoin.ValorAlta != null)
            {
                if (objCotacao.Salvar(Dolar.ValorAlta, Euro.ValorAlta, Bitcoin.ValorAlta))
                {
                    MessageBox.Show("Cotação salva com Sucesso!");
                    AtualizarGrid();
                    LimparSelecaoGrid();  
                }
                //Caso ocorra algum erro ao salvar
                else
                {
                    return;
                }

            }
            //Caso valores estejam nulos (ainda não há valores retornados da api)
            else
            {
                return;
            }
        }

        private void AtualizarGrid()
        {
            dgvCotacao.DataSource = Cotacao.Listar();
        }

        private void DgvCotacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCotacao = int.Parse(dgvCotacao.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnExcluir.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(idCotacao != 0)
            {
                objCotacao.Excluir(idCotacao);
                MessageBox.Show("Excluído com Sucesso!");
                
                AtualizarGrid();
                LimparSelecaoGrid();
            }
            else
            {
                MessageBox.Show("Selecione uma cotação na sua lista para poder excluir.");
            }
        }

        private void LimparSelecaoGrid()
        {
            dgvCotacao.ClearSelection();
            lblTituloGridView.Focus();
            btnExcluir.Enabled = false;
        }
    }
}
