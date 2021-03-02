using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace TestWPF
{
    public static class DataSourceClass
    {
        public static MailAddress from
        {
            get 
            { 
                return new MailAddress("a.demyanof@yandex.ru", "Андрей");
            }
        }

        public static MailAddress to
        {
            get
            {
                return new MailAddress("a.demyanofff@gmail.com", "Андрей");
            }
        }

        public static MailMessage message
        {
            get
            {
                return new MailMessage(from, to);
            }
        }

        public static string smtpserver
        {
            get
            {
                return "smtp.yandex.ru";
            }
        }

        public static int port
        {
            get
            {
                return 25;
            }
        }

        public static string subject
        {
            get
            {
                return "Заголовок";
            }
        }


        public static string body
        {
            get
            {
                return "Текст сообщения";
            }
        }


        public static SmtpClient client
        {
            get
            {
                return new SmtpClient(smtpserver, port);
            }
        }

    }
}
