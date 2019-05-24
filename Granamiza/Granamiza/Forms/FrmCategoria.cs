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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Categoria.Salvar(txtNome, rbGasto, 0);
            /*}
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }*/
        }
    }
}
