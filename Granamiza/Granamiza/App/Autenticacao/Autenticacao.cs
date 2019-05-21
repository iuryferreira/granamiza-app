using CryptSharp;
using Granamiza.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granamiza.App.Autenticacao
{
    class Autenticacao
    {
        //-- Autenticar -----
        static internal bool Autenticar(string email, string senhaDigitada)
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
                }
            }
            //Se não achar retorna false.
            return false;
        }

        //Verifica senha através da senha.
        internal static bool VerificarSenha(string senhaDigitada, string senhaHash)
        {
            return Crypter.CheckPassword(senhaDigitada, senhaHash);
        }
    }
}
