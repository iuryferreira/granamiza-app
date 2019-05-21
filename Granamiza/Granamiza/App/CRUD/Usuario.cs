using Granamiza.App.Autenticacao;
using Granamiza.Modelo;
using System;
using System.Windows.Forms;

namespace Granamiza.App.CRUD
{
    class Usuario
    {
        internal static bool Salvar(TextBox txtNome, TextBox txtEmail, TextBox txtSenha, RadioButton rbJoana)
        {
            string caminhoAvatar = "Granamiza\\Granamiza\\Imagens\\male";

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
                    senha = Validacao.CriptografarSenha(txtSenha.Text.Trim()),
                    data_criacao = dt
                };
                //Adicionar usuário
                bd.usuario.Add(u);

                if (rbJoana.Checked)
                {
                    caminhoAvatar = "Granamiza\\Granamiza\\Imagens\\female";
                }

                //Preenhcer dados de preferência de usuário.
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
    }
}

