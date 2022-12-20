using BaseData;
using BaseData.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModelBase;
using ViewModelBase.Commands.AsyncCommands;
using ViewModelBase.Commands.QuickCommands;

namespace _DemoViewModel
{
    public class MainViewModel : ViewModel
    {
        private readonly DataManager dataModel = DataManager.Get(DataProvider.Sqlite);
        private string newName = "";

        public string NewName
        {
            get => newName;
            set
            {
                if(Set(ref newName, value))
                {
                    NewUserCommandAsync.RaiseCanExecuteChanged();
                }
            }
        }
        public AsyncCommand NewUserCommandAsync { get; }

        public ObservableCollection<User> Users { get; private set; }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>(dataModel.UserRep.Items);
            NewUserCommandAsync = new AsyncCommand(commAsync,
                () => NewName.Trim().Length > 2);
        }

        private async Task commAsync(CancellationToken arg)
        {
            await dataModel.UserRep.UpdateAsync(new User() { Name = "УДАЛИТЬ", Surname = NewName });
            Users = new ObservableCollection<User>(dataModel.UserRep.Items);
        }
    }
}
