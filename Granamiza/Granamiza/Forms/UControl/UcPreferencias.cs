using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.Forms.RedefinirSenha;
using Granamiza.App.CRUD;
using Granamiza.Forms.Popup;
using Granamiza.App.Autenticacao;

namespace Granamiza.Forms.UControl
{
    public partial class UcPreferencias : UserControl
    {
        bool validou = true;
        bool salvou = true;
        sbyte dark_mode = 0;

        public UcPreferencias()
        {
            InitializeComponent();
            CarregarPreferenciasSalvas();
        }

        private void CarregarPreferenciasSalvas()
        {
            txtNome.Text = Sessao.NomeUsuario;
            btnOk.Enabled = false;
            dark_mode = Sessao.DarkMode;
            DefinirEstadoBotoesDM();
        }

        private void TxtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Trim().Length > 3)
            {
                //e.Cancel = false;
                validou = true;
                errorProvider1.SetError(txtNome, "");
                btnOk.Enabled = true;
            }
            else
            {
                //e.Cancel = true;
                validou = false;
                txtNome.Focus();
                errorProvider1.SetError(txtNome, "O nome precisa ser maior que 3 caracteres.");
                btnOk.Enabled = false;
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FrmNovaSenha frmSenha = new FrmNovaSenha(this.ParentForm);
            frmSenha.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string novo_nome = txtNome.Text.Trim();

            //if (ValidateChildren(ValidationConstraints.Enabled))
            if(Sessao.NomeUsuario != novo_nome || Sessao.DarkMode != dark_mode)
            {
                if (Sessao.NomeUsuario != novo_nome)
                {
                    if (validou)
                    {
                        if (Usuario.AtualizarNome(novo_nome))
                        {
                            salvou = true;
                        }
                    }
                    else
                    {
                        // new Popup de informação
                        MessageBox.Show("Verifique os erros.");
                    }
                }

                if (Sessao.DarkMode != dark_mode)
                {
                    if (Usuario.AtualizarDarkMode(dark_mode))
                    {
                        salvou = true;
                    }
                }

                if (!salvou)
                {
                    // new Popup de informação
                    MessageBox.Show("Nada foi alterado.");
                }
                //_ = new FrmPopupSucesso("Preferências atualizadas.", this.ParentForm);
                MessageBox.Show("Preferências atualizadas.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CarregarPreferenciasSalvas();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.TrimEnd().Length > 3)
            {
                //e.Cancel = false;
                validou = true;
                errorProvider1.SetError(txtNome, "");
                btnOk.Enabled = true;
            }
            else
            {
                //e.Cancel = true;
                validou = false;
                txtNome.Focus();
                errorProvider1.SetError(txtNome, "O nome precisa ser maior que 3 caracteres.");
                btnOk.Enabled = false;
            }
        }

        private void BtnLigarDarkMode_Click(object sender, EventArgs e)
        {
            dark_mode = 1;
            DefinirEstadoBotoesDM();
            btnOk.Enabled = true;
        }

        private void BtnDesligarDarkMode_Click(object sender, EventArgs e)
        {
            dark_mode = 0;
            DefinirEstadoBotoesDM();
            btnOk.Enabled = true;
        }

        private void DefinirEstadoBotoesDM()
        {
            if (dark_mode == 0)
            {
                btnLigarDarkMode.BackColor = Color.Black;
                btnLigarDarkMode.ForeColor = Color.DarkCyan;

                btnDesligarDarkMode.Enabled = false;
                btnLigarDarkMode.Enabled = true;

                btnDesligarDarkMode.ForeColor = Color.Black;
                btnDesligarDarkMode.BackColor = Color.White;
            }
            else
            {
                btnLigarDarkMode.Enabled = false;
                btnDesligarDarkMode.Enabled = true;

                btnDesligarDarkMode.BackColor = Color.Black;
                btnDesligarDarkMode.ForeColor = Color.DarkCyan;

                btnLigarDarkMode.ForeColor = Color.Black;
                btnLigarDarkMode.BackColor = Color.White;
            }
        }
    }
}
