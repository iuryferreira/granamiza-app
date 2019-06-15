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
    public partial class FrmPopupSucesso : Form
    {
        int X = 0;
        int Y = 0;
        //Atributo para receber referência de formulário de cadastro
        readonly Form frmPai;


        public FrmPopupSucesso(Form frmPai)
        {
            InitializeComponent();
            this.frmPai = frmPai;
            this.Show();
        }


        public FrmPopupSucesso(string texto, Form frmPai)
        {
            InitializeComponent();
            this.frmPai = frmPai;
            lblTextoSucesso.Text = texto;
            this.Show();
        }


        /// <summary>
        /// Eventos para arrastar pop-up
        /// </summary>
        /// 
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
            try
            {
                frmPai.Close();
                Close();
            }

            catch
            {
                Close();
            }


        }

        //Fechar pop-up através do botão confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
                frmPai.Close();
                Close();
        }

    }
}
