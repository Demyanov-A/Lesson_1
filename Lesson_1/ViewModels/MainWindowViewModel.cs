using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.ViewModels.Base;

namespace Lesson_1.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Рассыльщик";
        public string Title { get => _Title; set => Set(ref _Title, value); }

        private string _Status = "Готово";
        public string Status { get => _Status; set => Set(ref _Status, value); }
    }
}
