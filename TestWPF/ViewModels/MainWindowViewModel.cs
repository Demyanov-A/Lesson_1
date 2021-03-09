using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.ViewModels.Base;

namespace TestWPF.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string _Title = "Test1111";
        public string Title 
        { 
            get => _Title;
            set
            {
                _Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

    }
}
