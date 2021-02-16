using System;
using System.Net;
using System.Net.Mail;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new MailAddress("a.demyanof@yandex.ru","Андрей");

            var to = new MailAddress("a.demyanofff@gmail.com","Андрей");

            var message = new MailMessage(from,to);

            message.Subject = "Заголовок";
            message.Body = "Text";

            var client = new SmtpClient("smtp.yandex.ru",465);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = "a.demyanof",
                Password = "Qwerty0808"
            };

            client.Send(message);

        }
    }
}
