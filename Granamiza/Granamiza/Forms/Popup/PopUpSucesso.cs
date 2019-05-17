using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms.Popup
{
    public partial class PopUpSucesso : Form
    {
        int X = 0;
        int Y = 0;
        private Form frmCaixa;

        public PopUpSucesso()
        {
            InitializeComponent();
        }

        public PopUpSucesso(Form frmCaixa)
        {
            
            this.frmCaixa = frmCaixa;
            InitializeComponent();
            this.Show();
        }

        private void PnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            frmCaixa.Close();
            Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            frmCaixa.Close();
            Close();
        }
    }
}
