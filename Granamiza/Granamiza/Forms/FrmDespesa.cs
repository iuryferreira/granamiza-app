using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD.Transacao;
using Granamiza.App.CRUD;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using Granamiza.App.CRUD.Categoria;

namespace Granamiza.Forms
{
    public partial class FrmDespesa : Form
    {
        private readonly int idTransacao;
        private readonly bool atualizar = false;
        private readonly Despesa objDespesa;
        private int idCategoria;
        private readonly CategoriaDespesa objCategoriaDespesa;

        public FrmDespesa()
        {
            InitializeComponent();
            objCategoriaDespesa = new CategoriaDespesa();
            objDespesa = new Despesa();
            cbCategoria.DataSource = objCategoriaDespesa.Listar();

        }

        public FrmDespesa(int idTransacao, decimal valor, string nomeCategoria, string descricao)
        {
            InitializeComponent();
            this.idTransacao = idTransacao;
            atualizar = true;
            numValor.Value = valor;
            cbCategoria.Text = nomeCategoria;
            txtDesc.Text = descricao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            //passa a categoria digitada ou escolhida
            string nomeCategoria = cbCategoria.Text;
            //Chama o salvar categoria enviando a categoria inserida e 0 como sendo não gasto
            idCategoria = objCategoriaDespesa.Salvar(nomeCategoria);
            //Recebe a descricao da transacao
            string descricao = txtDesc.Text;
            decimal valor = numValor.Value;

            bool validou = Validacao.ValidarTransacao(valor, nomeCategoria);

            if (validou)
            {
                if (atualizar == true)
                {
                    MessageBox.Show("Dados atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objDespesa.Atualizar(idTransacao, valor, idCategoria, descricao);
                    this.Close();
                }

                else
                {
                    //Envia os valores já formatados para o metodo de salvar modificado
                    objDespesa.Salvar(numValor.Value, idCategoria, descricao);
                    this.Close();
                }
            }
            else
            {
                _ = new FrmPopupInformacao();
            }


        }
    }
}
