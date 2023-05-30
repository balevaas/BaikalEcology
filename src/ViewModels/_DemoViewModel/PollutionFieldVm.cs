using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using BaseData.DataProviders.EntityFramework.Contexts;
using BaseData.Entities;
using Microsoft.EntityFrameworkCore;
using ViewModelBase;
using ViewModelBase.Commands.AsyncCommands;
using ViewModelBase.Commands.QuickCommands;

namespace _DemoViewModel
{
    public class PollutionFieldVm : ViewModel
    {
        private readonly DataContext _model;

        public PollutionFieldVm(DataContext model)
        {
            _model = model;
            Dates = new(model.PollutionFields.Select(p => p.Date));

            SelectDateCommand = new Command<DateTime>(SelectDate);
            SelectNameCommand = new Command<string>(SelectName);
        }

        private void SelectDate(DateTime date)
        {
            Names = new ObservableCollection<string>(_model.PollutionFields.Where(f => f.Date == date).Select(f => f.Name));
            OnPropertyChanged(nameof(Names));
        }

        private void SelectName (string name)
        {
            LinkImages = new ObservableCollection<string>(_model.PollutionFields.Where(r => r.Name == name).Select(r => r.LinkImage));
            SoftModules = new ObservableCollection<SoftModule>(_model.PollutionFields.Where(f => f.Name == name).Select(f => f.SoftModule));
            OnPropertyChanged(nameof(LinkImages));
        }


        public Command<DateTime> SelectDateCommand { get; }
        public Command<string> SelectNameCommand { get; }

        public ObservableCollection<DateTime> Dates { get; set; }

        public ObservableCollection<string> Names { get; private set; } = new ObservableCollection<string>();

        public ObservableCollection<string> LinkImages { get; private set; } = new ObservableCollection<string>();

        public ObservableCollection<SoftModule> SoftModules { get; private set;} = new ObservableCollection<SoftModule>();

       
    }
}
