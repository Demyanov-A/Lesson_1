using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.ViewModels.Base;

namespace TestWPF.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string _Title = "Test";
        public string Title 
        { 
            get => _Title;
            //set
            //{
            //    //if (_Title == value) return;
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();                
            //}
            set => Set(ref _Title, value);
        }

    }
}
