using BaseData.DataProviders.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelBase;
using ViewModelBase.Commands.QuickCommands;

namespace _DemoViewModel
{
    public class AddMonitoringVm : ViewModel
    {
        private readonly DataContext _model;
        public int HarmID, TypeID;
        public AddMonitoringVm(DataContext model) 
        { 
            _model = model;
            Types = new(model.MonitoringTypes.Select(p => p.Type));
            Harms = new(model.HarmSubstances.Select(m => m.Name));

            SelectTypeCommand = new Command<string>(SelectType);
            SelectHarmCommand = new Command<string>(SelectHarm);
        }

        private void SelectHarm(string obj)
        {
            HarmId = new ObservableCollection<int>(_model.HarmSubstances.Where(p => p.Name == obj).Select(p => p.ID));
            HarmID = HarmId.ElementAt(0); 
            OnPropertyChanged(nameof(HarmID));
        }

        private void SelectType(string obj)
        {
            TypeId = new ObservableCollection<int>(_model.MonitoringTypes.Where(p => p.Type == obj).Select(p => p.ID));
          //  TypeID = new ObservableCollection<int>(_model.HarmSubstances.Add(TypeID));
            OnPropertyChanged(nameof(TypeId));
        }

        public ObservableCollection<string> Types { get; set; }
        public ObservableCollection<string> Harms { get; set; }

        public ObservableCollection<int> TypeId { get; set; }
        public ObservableCollection<int> HarmId { get; set; }

        public Command<string> SelectTypeCommand { get; }
        public Command<string> SelectHarmCommand { get; }

        
    }
}
