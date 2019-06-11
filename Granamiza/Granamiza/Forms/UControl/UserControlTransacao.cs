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
    public partial class UserControlTransacao : UserControl
    {

        Button btn_clicado;

        int idTransacao;
        public UserControlTransacao()
        {
            InitializeComponent();
        }

        //Construtor!
        public UserControlTransacao(Button botao_clicado)
        {
            InitializeComponent();
            this.btn_clicado = botao_clicado;
        }

        //Metodo mais relevante!
        private void UserControlTransacao_Load(object sender, EventArgs e)
        {
            //Se o botao clicado for de receita, deve se chamar um metodo que defina o datasource
            //do gridview para receber somente os dados de transacões que não são gastos
            if (btn_clicado.Name == "btnReceita")
            {
                AtualizarGrid("receita");
            }

            //Se o botao clicado for de receita, deve se chamar um metodo que defina o datasource
            //do gridview para receber somente os dados de transacões que são gastos
            if (btn_clicado.Name == "btnDespesa")
            {
                AtualizarGrid("despesa");
            }

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            //Se o botão clicado no menu lateral for o de receita,  ele vai chamar o form de receita
            if (btn_clicado.Name == "btnReceita")
            {
                FrmReceita frm = new FrmReceita();
                frm.Show();
                frm.Closed += (s, args) => this.AtualizarGrid("receita");
            }

            //  Se o botao clicado no menu lateral for o de despesa ele chama o form de despesa
            if (btn_clicado.Name == "btnDespesa")
            {
                FrmDespesa frm = new FrmDespesa();
                frm.Show();
                frm.Closed += (s, args) => this.AtualizarGrid("despesa");
            }
        }

        private void AtualizarGrid(string btn_clicado)
        {

            if (btn_clicado == "receita")
            {
                tcDespesa.Visible = false;

                try
                {
                    using (var bd = new granamizaEntities())
                    {
                        this.dgvDespesas.DataSource = bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).ToList();
                    }
                }
                catch (Exception)
                {
                    _ = new FrmPopupErro();
                }
            }

            if (btn_clicado == "despesa")
            {

                try
                {
                    using (var bd = new granamizaEntities())
                    {
                        dgvDespesas.DataSource = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Where(d => d.debitada != true).ToList();
                        dgvDespesasPagas.DataSource = bd.vwdespesa.Where(d => d.usuario_id == Sessao.IdUsuario).Where(d => d.debitada == true).ToList();
                    }
                }
                catch (Exception)
                {
                    _ = new FrmPopupErro();
                }
            }
        }

        private void DgvTransacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTransacao = int.Parse(dgvDespesas.Rows[e.RowIndex].Cells[0].Value.ToString());
                CarregarDadosTransacao();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }

        private void CarregarDadosTransacao()
        {
            if (btn_clicado.Name == "btnReceita")
            {

                using (var bd = new granamizaEntities())
                {
                    if (idTransacao > 0)
                    {
                        vwreceita r = (from re in bd.vwreceita
                                       where re.id == idTransacao
                                       select re).FirstOrDefault();

                        if (r != null) //Testa se localizou o registro
                        {
                            txtValor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), " {0:#,###.##} R$", r.valor);
                            txtCategoria.Text = r.nome;
                            txtData.Text = r.data_insercao;
                            txtHora.Text = r.hora_insercao;
                            txtDesc.Text = r.descricao;
                        }
                    }
                }
            }

            if (btn_clicado.Name == "btnDespesa")
            {
                try
                {
                    using (var bd = new granamizaEntities())
                    {
                        if (idTransacao > 0)
                        {
                            vwdespesa d = (from de in bd.vwdespesa
                                           where de.id == idTransacao
                                           select de).FirstOrDefault();

                            if (d != null) //Testa se localizou o registro
                            {
                                txtValor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), " {0:#,###.##} R$", d.valor);
                                txtCategoria.Text = d.nome;
                                txtData.Text = d.data_insercao;
                                txtHora.Text = d.hora_insercao;
                                txtDesc.Text = d.descricao;
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

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            tcDespesa.Visible = false;
            TransacaoTemp.Pagar(idTransacao);
            AtualizarGrid("despesa");
            LimparDadosTransacao();
        }

        private void LimparDadosTransacao()
        {
            txtValor.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtData.Text = string.Empty;
            txtHora.Text = string.Empty;
            txtDesc.Text = string.Empty;
        }
    }
}

