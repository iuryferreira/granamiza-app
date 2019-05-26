using Granamiza.App.CRUD;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    cbCategoria.DataSource = bd.categoria.ToList();
                }
            }
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }

        }

        private void FrmRemuneracao_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {


            try
            {

                string categoria = cbCategoria.Text;
                int idCategoria = Categoria.Salvar(categoria, 0);
                string descricao = txtDesc.Text; 
                TransacaoTemp.Salvar(numValor.Value, idCategoria, descricao, 0);
                this.Close();
            }
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }
    }
}
