using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Granamiza.App.Autenticacao;
using Granamiza.Modelo;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Granamiza.App.Email
{
    internal class Email
    {
        //internal static bool ValidarEmail(string email, Label lblErro)
        internal static bool Validar(TextBox txtEmail)
        {
            string email = txtEmail.Text.Trim();

            if (email == "")
            {
                MessageBox.Show("Digite um e-mail válido.");
                //MeusWidgets.AvisoForm(lblErros[1], "O E-mail não pode ser vazio. Preencha o e-mail.");
                return false;
            }
            if (!ValidarEmail(email) || !EmailCadastrado(email))
            {
                return false;
            }
            return true;
        }

        //Verificar se o E-mail é de formato válido
        internal static bool ValidarEmail(string email)
        {
            //Expressão regular.
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
            {
                MessageBox.Show("Digite um e-mail válido.");
                return false;
            }

            return true;
        }

        //Verificar se o E-mail é cadastrado ou não
        internal static bool EmailCadastrado(string email)
        {
            using (var bd = new granamizaEntities())
            {
                //Consulta usando LINQ
                usuario user = (from u in bd.usuario
                                where u.email == email
                                select u).FirstOrDefault();
                //Retorna falso se não encontrar E-mail
                if (user == null)
                {
                    MessageBox.Show("E-mail não cadastrado.");
                    return false;
                }

                //Aproveitar consulta e guardar dados
                Sessao.IdUsuario = user.id;
                Sessao.EmailUsuario = user.email;
                Sessao.NomeUsuario = user.nome;
                return true;
            }
        }

        //Enviar E-mail de forma assíncrona
        internal static async Task EnviarAsync()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            //Remetente 
            var from = new EmailAddress("nao-responder@granzamiza.com", "Granamiza");
            var subject = "Recuperação de senha";
            //Destinatário - Email e nome do usuário
            var to = new EmailAddress(Sessao.EmailUsuario, Sessao.NomeUsuario);
            //Corpo do E-mail
            var plainTextContent = "Digite o código a seguir para recuperar sua senha: " + Sessao.CodigoUsuario;
            var htmlContent = "<p>Digite o código a seguir para recuperar sua senha: </p>" +
                "<strong>" + Sessao.CodigoUsuario + "</strong>";
            //E-mail montado
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //Enviar
            var response = await client.SendEmailAsync(msg);
        }
    }
}
