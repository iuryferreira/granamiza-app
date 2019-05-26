using Granamiza.App.CRUD;
using Granamiza.Forms.Popup;
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
    public partial class FrmDespesa : Form
    {
        public FrmDespesa()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                string categoria = cbCategoria.Text;
                int idCategoria = Categoria.Salvar(categoria, 1);
                string descricao = txtDesc.Text;
                TransacaoTemp.Salvar(numValor.Value, idCategoria, descricao, 1);
                this.Close();
            }
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }
    }
}
