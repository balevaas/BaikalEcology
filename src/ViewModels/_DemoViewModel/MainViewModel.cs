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
using BaseData.DataProviders.EntityFramework.Contexts;
using ViewModelBase;
using ViewModelBase.Commands.AsyncCommands;
using ViewModelBase.Commands.QuickCommands;

namespace _DemoViewModel
{
    public class MainViewModel : ViewModel
    {
        //private readonly DataManager dataModel = DataManager.Get(DataProvider.SqlServer);
        public DataContext Model { private get; set; }

        private string newName = "";

        //public string NewName
        //{
        //    get => newName;
        //    set
        //    {
        //        if(Set(ref newName, value))
        //        {
        //            NewUserCommandAsync.RaiseCanExecuteChanged();
        //        }
        //    }
        //}

        //public AsyncCommand NewUserCommandAsync { get; }

        //public ObservableCollection<User> Users { get; private set; }

        //public MainViewModel()
        //{
           
        //}

        //private async Task commAsync(CancellationToken arg)
        //{
        //    await dataModel.UserRep.UpdateAsync(new User() { Name = "УДАЛИТЬ", Surname = NewName });
        //    Users = new ObservableCollection<User>(dataModel.UserRep.Items);
        //}
    }
}
