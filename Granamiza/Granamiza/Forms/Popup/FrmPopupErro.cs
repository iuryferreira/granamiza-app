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
    public partial class FrmPopupErro : Form
    {

        int X = 0;
        int Y = 0;
        private Form frmPai;


        public FrmPopupErro()
        {
            InitializeComponent();
            this.Show();
        }

        public FrmPopupErro(Form frmPai)
        {
            this.frmPai = frmPai;
            InitializeComponent();
            this.Show();
        }


        public FrmPopupErro(string texto, Form frmPai)
        {
            InitializeComponent();
            this.frmPai = frmPai;
            lblTextoSucesso.Text = texto;
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

        //Fechar pop-up através do botão close
        private void BtnClose_Click(object sender, EventArgs e)
        {

            frmPai.Close();
            Close();
        }

        //Fechar pop-up através do botão confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            frmPai.Close();
            Close();
        }


    }
}
