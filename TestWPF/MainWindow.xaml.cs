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
    public partial class WPFMailSender : Window
    {
        public WPFMailSender()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var message = DataSourceClass.message;

            //message.Subject = DataSourceClass.subject;

            message.Subject = MessageSubject.Text;

            //message.Body = DataSourceClass.body;

            message.Body = MessageBody.Text;

            var client = DataSourceClass.client;

            client.EnableSsl = true;

            var EmailSender = new EmailSendServiceClass();

            var Credentials = new NetworkCredential
            {
                UserName = Login.Text,
                SecurePassword = Password.SecurePassword
                //Password = Password.Password
            };

            try
            {
                //client.Send(message);
                EmailSender.SendMail(message, client, Credentials);
                MessageBox.Show("Почта успешно отправлена", "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SmtpException)
            {
                MessageBox.Show("Ошибка атворизации", "Ошибка отпраквки почты", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch(TimeoutException)
            {
                MessageBox.Show("Ошибка адреса сервера", "Ошибка отпраквки почты", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
