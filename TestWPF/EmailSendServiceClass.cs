using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace TestWPF
{
    public class EmailSendServiceClass
    {
        public EmailSendServiceClass()
        {

        }

        public void SendMail(MailMessage message, SmtpClient client, NetworkCredential credential)
        {
            client.Credentials = credential;
            client.Send(message);
        }
    }
}
