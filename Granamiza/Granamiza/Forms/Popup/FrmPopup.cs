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
    public partial class FrmPopup : Form
    {
        int X = 0;
        int Y = 0;
        readonly System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopup));

        //Atributo para receber referência de formulário de cadastro
        private readonly Form frmCadastro;

        public FrmPopup()
        {
            InitializeComponent();
        }


        public FrmPopup(string texto, string tipo)
        {
            InitializeComponent();
            lblTextoSucesso.Text = texto;

            if(tipo == "Erro")
            {
                pbIcone.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("pbIcone.Erro")));

            }

            if (tipo == "Sucesso")
            {
                pbIcone.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("pbIcone.Sucesso")));
            }

            if(tipo == "Informação")
            {
                pbIcone.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("pbIcone.Informacao")));
            }

            this.Show();
        }

        //Recebendo referência de formulário de cadastro, o texto desejado e exibindo pop-up
        public FrmPopup(Form frmCadastro, string texto, string tipo)
        {
            this.frmCadastro = frmCadastro;
            InitializeComponent();
            this.lblTextoSucesso.Text = texto;

            if (tipo == "Erro")
            {
                pbIcone.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("pbIcone.Erro")));

            }

            if (tipo == "Sucesso")
            {
                pbIcone.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("pbIcone.Sucesso")));
            }

            if (tipo == "Informação")
            {
                pbIcone.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("pbIcone.Informacao")));
            }
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
            try
            {
                frmCadastro.Close();
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
            try
            {
                frmCadastro.Close();
                Close();
            }

            catch
            {
                Close();
            }
        }

    }
}
