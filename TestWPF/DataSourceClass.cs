using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace TestWPF
{
    public static class DataSourceClass
    {
        public static MailAddress from = new MailAddress("a.demyanof@yandex.ru", "Андрей");

        public static MailAddress to = new MailAddress("a.demyanofff@gmail.com", "Андрей");

        public static MailMessage message = new MailMessage(from, to);

        public static string smtpserver = "smtp.yandex.ru";

        public static int port = 25;

        public static string subject = "Заголовок";

        public static string body = "Текст сообщения";

        public static SmtpClient client = new SmtpClient(smtpserver, port);      

    }
}
