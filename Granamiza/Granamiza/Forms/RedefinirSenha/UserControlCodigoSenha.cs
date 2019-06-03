using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.App.Autenticacao;

namespace Granamiza.Forms.RedefinirSenha
{
    public partial class UserControlCodigoSenha : UserControl
    {

        Form frmPai;
        Form frmVo;

        public UserControlCodigoSenha(Form frmPai, Form frmVo)
        {
            InitializeComponent();
            this.frmPai = frmPai;
            this.frmVo = frmVo;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if(Sessao.CodigoUsuario == txtCodigo.Text.Trim())
            {
                var frmNovaSenha = new FrmNovaSenha(frmVo);
                frmPai.Hide();
                frmNovaSenha.Show();
                frmNovaSenha.Closed += (s, args) => frmPai.Close();
            }
        }
    }
}
