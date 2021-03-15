using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lesson_1.Infrastructure;
using Lesson_1.Models;
using Lesson_1.ViewModels;
using MailSender.lib.ViewModels.Base;
using MailSender.lib.Commands;

namespace Lesson_1.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private ServersRepository _Servers;

        private string _Title = "Рассыльщик";
        public string Title { get => _Title; set => Set(ref _Title, value); }

        private string _Status = "Готово";
        
        public string Status { get => _Status; set => Set(ref _Status, value); }

        public ObservableCollection<Server> Servers { get; } = new();

        #region Команды

        private ICommand _LoadServersCommand;

        public ICommand LoadServersCommand => _LoadServersCommand
            ??= new LambdaCommand(OnLoadServersCommandExecuted, CanLoadServersCommandExecute);

        private bool CanLoadServersCommandExecute(object p) => Servers.Count == 0;

        private void OnLoadServersCommandExecuted(object p)
        {
            LoadServers();
        }

        #endregion

        public MainWindowViewModel(ServersRepository Servers) { _Servers = Servers; }

        private void LoadServers()
        {
            foreach (var server in _Servers.GetAll())
                Servers.Add(server);
        }
    }
}
