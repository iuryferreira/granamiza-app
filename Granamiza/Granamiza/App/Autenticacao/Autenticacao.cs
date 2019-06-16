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
                    var user = (from u in bd.usuario
                                where u.email == email
                                select new
                                {
                                    u.id,
                                    u.nome,
                                    u.senha
                                }).FirstOrDefault();

                    //Testa se achou usuário, para poder verificar senha.
                    if (user != null)
                    {
                        if (VerificarSenha(senhaDigitada, user.senha))
                        {
                            if (DefinirUsuario(user.id, user.nome)) {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                            
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
                _ = new FrmPopupErro();
                return false;
            }
        }

        //Verifica se senha digita e senha do banco relacionada ao E-mail são iguais.
        internal static bool VerificarSenha(string senhaDigitada, string senhaHash)
        {
            return Crypter.CheckPassword(senhaDigitada, senhaHash);
        }

        internal static bool DefinirUsuario(int id_usuario, string nome_usuario)
        {
            Sessao.IdUsuario = id_usuario;
            Sessao.NomeUsuario = nome_usuario;
            //string avatar_usuario;
            preferencias pref;

            try
            {
                using (var bd = new granamizaEntities())
                {
                    pref = (from p in bd.preferencias
                                      where p.usuario_id == id_usuario
                                      select p).FirstOrDefault();

                    /*avatar_usuario = (from p in bd.preferencias
                                      where p.usuario_id == id_usuario
                                      select p.avatar).FirstOrDefault();*/
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
                return false;
            }

            //Sessao.AvatarUsuario = avatar_usuario;
            Sessao.AvatarUsuario = pref.avatar;
            Sessao.DarkMode = pref.dark_mode;
            Sessao.CodigoUsuario = String.Empty;

            return true;
        }

    }
}
