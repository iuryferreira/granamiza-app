using Granamiza.App.Autenticacao;
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
                    //viewcategoriadespesa
                    cbCategoria.DataSource = bd.vwcategoriadespesa.Where(c => c.usuario_id == Sessao.IdUsuario).ToList();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }
        
        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                //passa a categoria digitada ou escolhida
                string categoria = cbCategoria.Text;
                //int id_categoria = int.Parse(cbCategoria.SelectedValue.ToString());


                //Chama o salvar categoria enviando a categoria inserida e 1 como sendo gasto
                int idCategoria = Categoria.Salvar(categoria, 1);

                //Recebe a descricao da transacao
                string descricao = txtDesc.Text;

                //Envia os valores já formatados para o metodo de salvar modificado
                TransacaoTemp.Salvar(numValor.Value, idCategoria, descricao, 1);
                //TransacaoTemp.Salvar(numValor.Value, idCategoria, descricao, 1);
                this.Close();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }
    }
}
