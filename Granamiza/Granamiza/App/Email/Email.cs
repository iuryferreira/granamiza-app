using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Granamiza.App.Email
{
    internal class Email
    {
        //Enviar E-mail de forma assíncrona
        internal static async Task EnviarAsync()
        {
            var apiKey = Environment.GetEnvironmentVariable("SG.uM9mBiKpSpywQARyQroeSA.Bm5MQ0hes5xR3iXZ3xd3Ex30So6c_n9yy03ZJ0ZX9Xo");
            var client = new SendGridClient(apiKey);
            //Remetente 
            var from = new EmailAddress("nao-responder@granzamiza.com", "Granamiza");
            var subject = "Recuperação de senha";
            //Destinatário - Email e nome do usuário
            var to = new EmailAddress("magnoslima@bol.com.br", "Magnos");
            //Corpo do E-mail
            var plainTextContent = "Digite o código a seguir para recuperar sua senha: 4#5kb8";
            var htmlContent = "<p>Digite o código a seguir para recuperar sua senha: </p>" +
                "<strong>4#5kb8</strong>";
            //E-mail montado
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //Enviar
            var response = await client.SendEmailAsync(msg);
        }
    }
}
