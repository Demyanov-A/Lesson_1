using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Service;
using Lesson_1.Models;

namespace Lesson_1.Data
{
    internal static class TestData
    {
        public static List<Server> Servers { get; } = Enumerable.Range(1, 10)
           .Select(i => new Server
           {
               Name = $"Сервер-{i}",
               Adress = $"smtp.server{i}.com",
               Login = $"Login-{i}",
               Password = TextEncoder.Encode($"Password-{i}",7),
               UseSSL = i % 2 == 0,
           })
           .ToList();

        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10)
            .Select(i => new Sender
            {
                Name = $"Отправитель-{i}",
                Adress = $"sender_{i}@server.ru",

            })
            .ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 10)
            .Select(i => new Recipient
            {
                Name = $"Получатель-{i}",
                Adress = $"recipient_{i}@server.ru",

            })
            .ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 10)
            .Select(i => new Message
            {
                Subject = $"Сообщение {i}",
                Body = $"Текст сообщения {i}",
            })
            .ToList();
    }
}
