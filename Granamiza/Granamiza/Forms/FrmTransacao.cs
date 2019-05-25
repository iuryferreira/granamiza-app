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
    public partial class FrmTransacao : Form
    {
        public FrmTransacao()
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
            Transacao.Salvar(txtDescricao, txtValor, txtTipoTransacao, cbCategoria, txtIdTransacao);
            }
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
            }
        }
    }
}
