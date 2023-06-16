using System;
using System.Collections.ObjectModel;
using System.Linq;
using BaseData.DataProviders.EntityFramework.Contexts;
using BaseData.Entities;
using ViewModelBase;
using ViewModelBase.Commands.QuickCommands;

namespace _DemoViewModel
{
    public class PollutionFieldVm : ViewModel
    {
        private readonly DataContext _model;
        public ObservableCollection<DateTime> Dates { get; set; }

        public PollutionFieldVm(DataContext model)
        {
            _model = model;
            Dates = new(model.PollutionFields.Select(p => p.Date));

            SelectDateCommand = new Command<DateTime>(SelectDate);
            SelectNameCommand = new Command<string>(SelectName);
        }

        #region Обработка Combobox'ов
        public ObservableCollection<string> Names { get; private set; } = new ObservableCollection<string>();
        public ObservableCollection<string> LinkImages { get; private set; } = new ObservableCollection<string>();
        public ObservableCollection<SoftModule> SoftId { get; private set; } = new ObservableCollection<SoftModule>();
        public Command<DateTime> SelectDateCommand { get; }
        public Command<string> SelectNameCommand { get; }

        public string NameSoft;
        private void SelectDate(DateTime date)
        {
            Names = new ObservableCollection<string>(_model.PollutionFields.Where(f => f.Date == date).Select(f => f.Name));
            OnPropertyChanged(nameof(Names));
        }

        private void SelectName(string name)
        {
            LinkImages = new ObservableCollection<string>(_model.PollutionFields.Where(r => r.Name == name).Select(r => r.LinkImage));
            SoftId = new ObservableCollection<SoftModule>(_model.PollutionFields.Where(h => h.Name == name).Select(h => h.SoftModule));
            NameSoft = SoftId.ElementAt(0).Name;
            OnPropertyChanged(nameof(LinkImages));
            OnPropertyChanged(nameof(NameSoft));
        }
        #endregion               
    }
}
