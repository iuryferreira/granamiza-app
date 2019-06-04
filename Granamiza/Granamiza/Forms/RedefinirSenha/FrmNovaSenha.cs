using Granamiza.App.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.Forms.RedefinirSenha
{
    public partial class FrmNovaSenha : Form
    {
        Form frmBisavo;
        public FrmNovaSenha(Form frmBisavo)
        {
            this.frmBisavo = frmBisavo;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            if (Usuario.RedefinirSenha(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Senha alterada com sucesso.");
                frmBisavo.Show();
                this.Close();
            }
            
        }

        private bool Validar()
        {
            //Valida senha com confirmação de senha.
            if (txtSenha.Text.Trim() != txtConSenha.Text.Trim() || txtConSenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("As senhas digitadas não são iguais.");
                //MeusWidgets.AvisoForm(lblErros[3], "As senhas digitadas não são iguais.");
                return false;
            }
            return true;
        }
    }
}
