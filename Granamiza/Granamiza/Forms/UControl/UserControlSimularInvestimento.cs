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

namespace Granamiza.Forms.UControl
{
    public partial class UserControlSimularInvestimento : UserControl
    {

        //Button btn_clicado;

        int idSimulacao;
        public UserControlSimularInvestimento()
        {
            InitializeComponent();
        }

        //Construtor!
        public UserControlSimularInvestimento(Button botao_clicado)
        {
            InitializeComponent();
            //this.btn_clicado = botao_clicado;
        }

        //
        private void UserControlSimularInvestimento_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //
        }

        private void AtualizarGrid()
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    this.dgvSimulacao.DataSource = bd.simulacao.Where(s => s.usuario_id == Sessao.IdUsuario).ToList();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }

        }

        private void DgvTransacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {*/
                idSimulacao = int.Parse(dgvSimulacao.Rows[e.RowIndex].Cells[0].Value.ToString());
                CarregarDadosSimulacao();
            /*}
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }*/
        }

        private void CarregarDadosSimulacao()
        {
            /*try
            {*/
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
                            maskedTextBox1.Text = s.data_criacao.ToString();
                            maskedTextBox2.Text = s.data_criacao.Value.ToShortTimeString();
                            //txtHora.Text = s.hora_insercao;
                            //txtDesc.Text = r.descricao;
                    }
                }
                }
            /*}
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }*/
        }

    }
}

