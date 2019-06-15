using System;
using System.Linq;
using System.Windows.Forms;
using Granamiza.Modelo;
using Granamiza.Forms;
using CryptSharp;
using System.Text.RegularExpressions;
using Granamiza.Forms.Popup;

namespace Granamiza.App.Autenticacao
{
    class Validacao
    {
        internal static bool Validar(TextBox txtNome, TextBox txtEmail, TextBox txtSenha, TextBox txtConSenha, Label[] lblErros)
        {
            string email = txtEmail.Text.Trim();

            bool validou = true;

            //Valida nome
            if (txtNome.Text.Trim().Length < 3)
            {
                MeusWidgets.AvisoForm(lblErros[0], "O nome precisa ser maior que 3 caracteres.");
                validou = false;
            }

            //Valida se e-mail foi digitado.
            if (email == "")
            {
                MeusWidgets.AvisoForm(lblErros[1], "O E-mail não pode ser vazio. Preencha o e-mail.");
                validou = false;
            }

            //Valida e-mail (válido ou não válido) e valida se é único ou já foi cadastrado.
            if (!ValidarEmail(email, lblErros[1]))
            {
                validou = false;
            }

            //Valida senha.
            if (txtSenha.Text.Trim().Length < 5)
            {
                MeusWidgets.AvisoForm(lblErros[2], "A senha precisa ter no mínimo 6 caracteres.");
                validou = false;
            }

            //Valida senha com confirmação de senha.
            if (txtSenha.Text.Trim() != txtConSenha.Text.Trim() || txtConSenha.Text.Trim() == String.Empty)
            {
                MeusWidgets.AvisoForm(lblErros[3], "As senhas digitadas não são iguais.");
                validou = false;
            }

            return validou;
        }

        //Valida E-mail através de expressão regular, e se válido chama método para verificar se é único.
        private static bool ValidarEmail(string email, Label lblErro)
        {
            //Expressão regular.
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
            {
                MeusWidgets.AvisoForm(lblErro, "Digite um e-mail válido.");
                return false;
            }

            //Método para verificar se é único.
            if (!VerificarEmailUnico(email, lblErro))
            {
                return false;
            }

            return true;
        }

        //Valida E-mail através da consulta para checar se não foi cadastrado.
        private static bool VerificarEmailUnico(string email, Label lblErro)
        {
            //Tenta conectar no banco para consultar E-mail.
            try
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
                        MeusWidgets.AvisoForm(lblErro, "Endereço de e-mail digitado já está cadastrado.");
                        return false;
                    }
                }
            }
            //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopupErro();
                return false;
            }

            //Se não encontrou, E-mail pode ser usado para cadastro.
            return true;
        }

        //Faz o Hash da senha. (Recebe a senha em texto pleno e retorna o hash).
        internal static string CriptografarSenha(string senhaText)
        {
            //Usando algoritmo Sha256 + salt já implementados através da biblioteca Crypt.
            return Crypter.Sha256.Crypt(senhaText);
        }


        internal static bool ValidarTransacao(decimal valor, string categoria)
        {
            if(valor <= 0)
            {
                return false;
            }

            if(categoria.Trim() == "")
            {
                return false;
            }

            return true;

        }
    }
}
