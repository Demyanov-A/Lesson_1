using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Mail;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var from = new MailAddress("a.demyanof@yandex.ru", "Андрей");

            var to = new MailAddress("a.demyanofff@gmail.com", "Андрей");

            var message = new MailMessage(from, to);

            message.Subject = "Заголовок";
            message.Body = "Text";

            var client = new SmtpClient("smtp.yandex.ru", 465);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = Login.Text,
                SecurePassword = Password.SecurePassword
            };

            client.Send(message);
        }
    }
}
