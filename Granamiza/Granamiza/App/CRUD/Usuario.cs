using Granamiza.App.Autenticacao;
using Granamiza.Forms.Popup;
using Granamiza.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Granamiza.App.CRUD
{
    class Usuario
    {
        private static readonly int id_usuario = Sessao.IdUsuario;

        internal static bool Salvar(TextBox txtNome, TextBox txtEmail, TextBox txtSenha, RadioButton rbJoana)
        {
            string caminhoAvatar = "C:\\Users\\Mag\\source\\repos\\iuryferreira\\granamiza-app\\Granamiza\\Granamiza\\Imagens\\male.png";

            using (var bd = new granamizaEntities())
            {
                //Objeto DateTime para data_criacao do usuário.
                DateTime dt = DateTime.Now;
                //Preencher os dados do usuário.
                usuario u = new usuario
                {
                    nome = txtNome.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    //Receber retorno de método que faz hash da senha.
                    senha = Validacao.CriptografarSenha(txtSenha.Text.Trim()),
                    data_criacao = dt
                };
                //Adicionar usuário
                bd.usuario.Add(u);

                if (rbJoana.Checked)
                {
                    caminhoAvatar = "C:\\Users\\Mag\\source\\repos\\iuryferreira\\granamiza-app\\Granamiza\\Granamiza\\Imagens\\female.png";
                }

                //Preencher dados de preferência de usuário.
                preferencias p = new preferencias
                {
                    avatar = caminhoAvatar,
                    dark_mode = 0,
                    transacao_email = 0,
                    email_verificado = 0,
                    usuario_id = u.id
                };
                //Adicionar preferências
                bd.preferencias.Add(p);
                bd.SaveChanges();

                return true;
            }

        }

        //Recebe novo nome de usuário, busca usuário pelo id e o altera
        internal static bool AtualizarNome(string novo_nome)
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Consulta usando LINQ
                    usuario user = (from u in bd.usuario
                                    where u.id == id_usuario
                                    select u).FirstOrDefault();

                    if (user == null)
                    {
                        return false;
                    }

                    user.nome = novo_nome;
                    bd.SaveChanges();
                    Sessao.NomeUsuario = novo_nome;

                    return true;
                }

            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
                return false;
            }
        }

        internal static bool AtualizarDarkMode(sbyte dark_mode)
        {
            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Consulta usando LINQ
                    preferencias pref = (from p in bd.preferencias
                            where p.usuario_id == id_usuario
                            select p).FirstOrDefault();

                    if (pref == null)
                    {
                        return false;
                    }

                    pref.dark_mode = dark_mode;
                    bd.SaveChanges();
                    Sessao.DarkMode = dark_mode;
                    return true;
                }
            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
                return false;
            }
        }

        //Recebe senha em texto, criptografa, busca usuário pelo id e atríbui nova senha criptografada
        internal static bool RedefinirSenha(string senhaText)
        {
            string senha = Validacao.CriptografarSenha(senhaText);

            try
            {
                using (var bd = new granamizaEntities())
                {
                    //Consulta usando LINQ
                    usuario user = (from u in bd.usuario
                                    where u.id == id_usuario
                                    select u).FirstOrDefault();

                    if (user == null)
                    {
                        return false;
                    }

                    user.senha = senha;
                    bd.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                _ = new FrmPopupErro();
                return false;
            }

        }
    }
}

