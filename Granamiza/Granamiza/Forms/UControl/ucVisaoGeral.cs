using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.Modelo;
using Granamiza.App.Autenticacao;
using System.Globalization;

namespace Granamiza.Forms.UControl
{
    public partial class UcVisaoGeral : UserControl
    {
        public UcVisaoGeral()
        {
            InitializeComponent();
            using (var bd = new granamizaEntities())
            {
                //lblValorReceitaTotal.Text = bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor) + " R$";
                var valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "US$ {0:#,###.##}", bd.vwreceita.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor) + " R$");
                lblValorReceitaTotal.Text = valorFormatado;

                var despesa = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "US$ {0:#,###.##}", bd.vwdespesa.Where(r => r.usuario_id == Sessao.IdUsuario).Sum(r => r.valor) + " R$");
                lblValorDespesaTotal.Text = despesa;
            }

        }

        private void BtnAdicionarDespesa_Click(object sender, EventArgs e)
        {
            FrmDespesa frmDes = new FrmDespesa();
            frmDes.Show();
        }

        private void BtnAdicionarReceita_Click(object sender, EventArgs e)
        {
            FrmReceita frmReceita = new FrmReceita();
            frmReceita.Show();
        }
    }
}
