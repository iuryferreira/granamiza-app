using Granamiza.App.Autenticacao;
using Granamiza.App.CRUD;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Granamiza.Forms
{
    public partial class FrmReceita : Form
    {
        public FrmReceita()
        {
            InitializeComponent();

            try
            {
                using (var bd = new granamizaEntities())
                {
                    //viewcategoriareceita
                    cbCategoria.DataSource = bd.vwcategoriareceita.Where(c => c.usuario_id == Sessao.IdUsuario).ToList();
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

                //Chama o salvar categoria enviando a categoria inserida e 0 como sendo não gasto
                int idCategoria = Categoria.Salvar(categoria, 0);

                //Recebe a descricao da transacao
                string descricao = txtDesc.Text; 

                //Envia os valores já formatados para o metodo de salvar modificado
                TransacaoTemp.Salvar(numValor.Value, idCategoria, descricao, 0, false);
                this.Close();
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
            }
        }
    }
}
