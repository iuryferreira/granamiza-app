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
        public FrmDespesa()
        {
            InitializeComponent();

            try
            {
                using (var bd = new granamizaEntities())
                {

                    //Solução alternativa, falta um metodo para listar categorias por tipo
                    cbCategoria.DataSource = bd.categoria.ToList();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }

        

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                //passa a categoria digitada ou escolhida
                string categoria = cbCategoria.Text;

                //Chama o salvar categoria enviando a categoria inserida e 0 como sendo gasto
                int idCategoria = Categoria.Salvar(categoria, 1);

                //Recebe a descricao da transacao
                string descricao = txtDesc.Text;

                //Envia os valores já formatados para o metodo de salvar modificado
                TransacaoTemp.Salvar(numValor.Value, idCategoria, descricao, 1);
            }
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }
    }
}
