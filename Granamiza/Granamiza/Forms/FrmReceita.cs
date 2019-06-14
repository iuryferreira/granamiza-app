using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD;
using Granamiza.App.CRUD.Categoria;
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
        private readonly Receita objReceita;
        private readonly CategoriaReceita objCategoriaReceita;


        public FrmReceita()
        {
            InitializeComponent();
            objCategoriaReceita = new CategoriaReceita();
            objReceita = new Receita();
            cbCategoria.DataSource = objCategoriaReceita.Listar();

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
            int idCategoria = objCategoriaReceita.Salvar(categoria);
            //Recebe a descricao da transacao
            string descricao = txtDesc.Text;
            decimal valor = numValor.Value;

            bool validou = Validacao.ValidarTransacao(valor, categoria);

            if(validou)
            {
                if (atualizar == true)
                {
                    objReceita.Atualizar(idTransacao, valor, idCategoria, descricao);
                    MessageBox.Show("Dados atualizados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    //Envia os valores já formatados para o metodo de salvar modificado
                    objReceita.Salvar(numValor.Value, idCategoria, descricao);
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

