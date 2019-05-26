using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms.UControl
{
    public partial class UcVisaoGeral : UserControl
    {
        public UcVisaoGeral()
        {
            InitializeComponent();
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
