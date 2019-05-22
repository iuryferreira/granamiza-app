using CryptSharp;
using Granamiza.Forms;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granamiza.App.Autenticacao
{
    class Autenticacao
    {
        //-- Autenticar -----
        static internal bool Autenticar(string email, string senhaDigitada, Label lblErroAutenticacao)
        {
            //Tenta conectar no banco para consultar usuário.
            try
            {
                //Faz consulta do usuário através do email
                //Select usuario from usuario where usuario.email = txtEmail.Text;
                using (var bd = new granamizaEntities())
                {
                    //Consulta usando LINQ
                    usuario user = (from u in bd.usuario
                                    where u.email == email
                                    select u).FirstOrDefault();
                    //Testa se achou usuário, para poder verificar senha.
                    if (user != null)
                    {
                        if (VerificarSenha(senhaDigitada, user.senha))
                        {
                            return true;
                        }
                        //Senha incorreta.
                        else
                        {
                            lblErroAutenticacao.Visible = true;
                            return false;
                        }
                    }
                    //E-mail incorreto.
                    else
                    {
                        lblErroAutenticacao.Visible = true;
                        return false;
                    }
                }
            }
            //Se ocorrer erro ao conectar.
            catch (Exception)
            {
                _ = new FrmPopup("Ocorreu um erro, contate o suporte!", "Erro");
                return false;
            }
        }

        //Verifica se senha digita e senha do banco relacionada ao E-mail são iguais.
        internal static bool VerificarSenha(string senhaDigitada, string senhaHash)
        {
            return Crypter.CheckPassword(senhaDigitada, senhaHash);
        }
    }
}
