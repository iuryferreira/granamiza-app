using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptSharp;
using Granamiza.Forms;
using Granamiza.Modelo;

namespace Granamiza.Forms
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            //Ao abrir form, cursor ativado na caixa de texto do nome.
            this.ActiveControl = txtNome;
        }

        /// <summary>
        /// Cor das linhas quando estiverem em foco.
        /// </summary>
        private void TxtNome_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaNome);
        }
        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaEmail);
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaSenha);
        }

        private void TxtConSenha_Enter(object sender, EventArgs e)
        {
            MeusWidgets.CorFocoLinhaForm(linhaConSenha);
        }

        /// <summary>
        /// Cor das linhas quando não estiverem em foco.
        /// </summary>
        private void TxtNome_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaNome);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaEmail);
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaSenha);
        }

        private void TxtConSenha_Leave(object sender, EventArgs e)
        {
            MeusWidgets.CorLinhaForm(linhaConSenha);
        }

        //Evento do botão Salvar.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        //Salvar usuário. 
        private void Salvar()
        {
            //Testa se validou ou não. Se validou prossegue com a operação.
            if (!Validar())
            {
                return;
            }
            //Bloco using estanciando objeto de contexto da base de dados.
            using (var bd = new granamizaEntities())
            {
                //Objeto DateTime para data_criacao do usuário.
                DateTime dt = DateTime.Now;
                //Preencher os dados do usuário.
                usuario u = new usuario
                {
                    nome = txtNome.Text,
                    email = txtEmail.Text.Trim(),
                    //Receber retorno de método que faz hash da senha.
                    senha = CriptografarSenha(txtSenha.Text.Trim()),
                    data_criacao = dt
                };
                bd.usuario.Add(u);
                bd.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparForm();
                Close();
            }
        }

        //Volta o formulário para o estado original.
        private void LimparForm()
        {
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtConSenha.Text = String.Empty;
            chkTermosUso.CheckState = CheckState.Unchecked;
        }

        //Validar campos do formulário.
        private bool Validar()
        {
            string email = txtEmail.Text.Trim();

            //Valida nome
            if (txtNome.Text.Trim().Length < 3)
            {
                MessageBox.Show("Preencha o nome corretamente (Mínino 3 caracteres).");
                return false;
            }

            //Valida senha.
            if (txtSenha.Text.Trim().Length < 5)
            {
                MessageBox.Show("Preencha a senha corretamente (Mínimo 6 caracteres).");
                return false;
            }

            //Valida se e-mail foi digitado.
            if (email == "")
            {
                MessageBox.Show("Preencha o E-mail.");
                return false;
            }

            //Valida senha com confirmação de senha.
            if (txtSenha.Text.Trim() != txtConSenha.Text.Trim())
            {
                MessageBox.Show("As senhas não são iguais.");
                return false;
            }

            //Valida e-mail (válido ou não válido).
            if (!ValidarEmail(email))
            {
                MessageBox.Show("Digite um E-mail válido.");
                return false;
            }

            //Valida e-mail (se é único ou já foi cadastrado).
            if (!VerificarEmailUnico(email))
            {
                MessageBox.Show("Endereço de E-mail já cadastrado.");
                return false;
            }

            //Valida se checkbox de termos de uso está selecionado.
            if (!chkTermosUso.Checked)
            {
                MessageBox.Show("Você precisa aceitar os termos de uso.");
                return false;
            }
            return true;
        }

        //Valida E-mail através de expressão regular.
        private bool ValidarEmail(string email)
        {
            //Expressão regular.
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
            {
                return false;
            }
            return true;
        }

        //Valida E-mail através da consulta para checar se não foi cadastrado.
        private bool VerificarEmailUnico(string email)
        {
            //Se encontrar e-mail return false.
            //Select usuario.email from usuario where usuario.email = txtEmail.Text;
            using (var bd = new granamizaEntities())
            {
                //Consulta usando LINQ
                string _email = (from u in bd.usuario
                                 where u.email == email
                                 select u.email).FirstOrDefault();
                //Testa se encontrou algum e-mail igual ao informado na caixa de texto E-mail.
                if (_email != null)
                {
                    return false;
                }
            }
            //Se não encontrou, E-mail pode ser usado para cadastro.
            return true;
        }

        //Faz o Hash da senha. (Recebe a senha em texto pleno e retorna o hash).
        private string CriptografarSenha(string senhaText)
        {
            //Usando algoritmo Sha256 + salt já implementados através da biblioteca Crypt.
            return Crypter.Sha256.Crypt(senhaText);
        }
    }
}
