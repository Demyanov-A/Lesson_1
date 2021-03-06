﻿namespace Lesson_1.Models
{
    public class Server
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Port { get; set; } = 25;
        public bool UseSSL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString() => $"{Name}:{Port}";
    }
}
