using Granamiza.Forms.UControl;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void PbLogo_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void EsconderMenu()
        {
            if (pnlMenu.Size.Width == 44)
            {
                pnlMenu.Size = new Size(170, pnlMenu.Height);
            }

            else
            {
                pnlMenu.Size = new Size(44, pnlMenu.Height);
            }
        }

        private void BtnAdicionarRemuneracao_Click(object sender, EventArgs e)
        {
            FrmReceita frmRemu = new FrmReceita();
            frmRemu.Show();
        }

        private void BtnAdicionarDespesa_Click(object sender, EventArgs e)
        {
            FrmDespesa frmDes = new FrmDespesa();
            frmDes.Show();
        }
    }
}
