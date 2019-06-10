using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.App.API;

namespace Granamiza.Forms
{
    public partial class FrmCotacao : Form
    {
        public FrmCotacao()
        {
            InitializeComponent();

            var cotacao = new Cotacao();

            lblAltaDolar.Text = Dolar.ValorAlta + " R$";
            lblBaixaDolar.Text = Dolar.ValorBaixa + " R$";
            lblDataConsultaDolar.Text = Dolar.DataConsulta.ToString();


            lblAltaEuro.Text = Euro.ValorAlta + " R$";
            lblBaixaEuro.Text = Euro.ValorBaixa + " R$";
            lblDataConsultaEuro.Text = Euro.DataConsulta.ToString();

        }

    }
}
