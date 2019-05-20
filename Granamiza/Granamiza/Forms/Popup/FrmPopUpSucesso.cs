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
    public partial class FrmPopUpSucesso : Form
    {
        int X = 0;
        int Y = 0;
        //Atributo para receber referência de formulário de cadastro
        private Form frmCadastro;

        public FrmPopUpSucesso()
        {
            InitializeComponent();
        }

        //Recebendo referência de formulário de cadastro e exibindo pop-up
        public FrmPopUpSucesso(Form frmCadastro)
        {
            this.frmCadastro = frmCadastro;
            InitializeComponent();
            this.Show();
        }
        public FrmPopUpSucesso(Form frmCadastro, string texto)
        {
            this.frmCadastro = frmCadastro;
            InitializeComponent();
            this.lblSucesso.Text = texto;
            this.Show();
        }

        /// <summary>
        /// Eventos para arrastar pop-up
        /// </summary>
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
            frmCadastro.Close();
            Close();
        }

        //Fechar pop-up através do botão confirmar
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            frmCadastro.Close();
            Close();
        }
    }
}
