using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.App.API;

namespace Granamiza.Forms.UControl
{
    public partial class UserControlCotacao : UserControl
    {
        public UserControlCotacao()
        {
            InitializeComponent();

            var cotacao = new Cotacao();

            lblAltaDolarValor.Text = Dolar.ValorAlta + " R$";
            lblBaixaDolarValor.Text = Dolar.ValorBaixa + " R$";
            txtDataDolar.Text = Dolar.DataConsulta.ToString();


            lblAltaValorEuro.Text = Euro.ValorAlta + " R$";
            lblBaixaValorEuro.Text = Euro.ValorBaixa + " R$";
            txtDataEuro.Text = Euro.DataConsulta.ToString();
        }
    }
}
