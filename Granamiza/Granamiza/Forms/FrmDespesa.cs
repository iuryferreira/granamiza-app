using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD.Transacao;
using Granamiza.App.CRUD;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Granamiza.Forms
{
    public partial class FrmDespesa : Form
    {
        private int idTransacao;
        private bool atualizar = false;
        private Despesa despesa;

        public FrmDespesa()
        {
            InitializeComponent();
            cbCategoria.DataSource = Categoria.ListarCategoriaDespesa();

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
            string categoria = cbCategoria.Text;
            //Chama o salvar categoria enviando a categoria inserida e 0 como sendo não gasto
            int idCategoria = Categoria.Salvar(categoria, 1);
            //Recebe a descricao da transacao
            string descricao = txtDesc.Text;
            decimal valor = numValor.Value;

            if (atualizar == true)
            {
                despesa = new Despesa();
                MessageBox.Show("Dados atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                despesa.Atualizar(idTransacao, valor, idCategoria, descricao);
                this.Close();
            }

            else
            { 
                despesa = new Despesa();
                //Envia os valores já formatados para o metodo de salvar modificado
                despesa.Salvar(numValor.Value, idCategoria, descricao);
                this.Close();
            }
        }
    }
}
