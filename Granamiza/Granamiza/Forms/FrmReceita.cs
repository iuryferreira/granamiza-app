using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD;
using Granamiza.App.CRUD.Transacao;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Granamiza.Forms
{
    public partial class FrmReceita : Form
    {

        private readonly bool atualizar = false;
        private readonly int idTransacao;
        private Receita objReceita;

        public FrmReceita()
        {
            InitializeComponent();
            cbCategoria.DataSource = Categoria.ListarCategoriaReceita();

        }

        public FrmReceita(int idTransacao, decimal valor, string nomeCategoria, string descricao)
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
            int idCategoria = Categoria.Salvar(categoria, 0);
            //Recebe a descricao da transacao
            string descricao = txtDesc.Text;
            decimal valor = numValor.Value;

            if (atualizar == true)
            {
                objReceita = new Receita();
                objReceita.Atualizar(idTransacao, valor, idCategoria, descricao);
                MessageBox.Show("Dados atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                objReceita = new Receita();
                //Envia os valores já formatados para o metodo de salvar modificado
                objReceita.Salvar(numValor.Value, idCategoria, descricao);
                this.Close();
            }


        }
    }
}

