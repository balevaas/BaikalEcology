using BaseData.DataProviders.EntityFramework.Contexts;
using BaseData.Entities;
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
        public ObservableCollection<string> Types { get; set; }
        public ObservableCollection<string> Harms { get; set; }
        public ObservableCollection<int> TypeId { get; set; }
        public ObservableCollection<int> HarmId { get; set; }
        public Command<string> SelectTypeCommand { get; }
        public Command<string> SelectHarmCommand { get; }
                
        public AddMonitoringVm(DataContext model) 
        { 
            _model = model;
            Types = new(model.MonitoringTypes.Select(p => p.Type));
            Harms = new(model.HarmSubstances.Select(m => m.Name));

            SelectTypeCommand = new Command<string>(SelectType);
            SelectHarmCommand = new Command<string>(SelectHarm);
            SaveData = new Command(SaveMonitoring);
        }

        public int HarmID;
        private void SelectHarm(string obj)
        {
            HarmId = new ObservableCollection<int>(_model.HarmSubstances.Where(p => p.Name == obj).Select(p => p.ID));
            HarmID = HarmId.ElementAt(0); 
            OnPropertyChanged(nameof(HarmID));
        }

        public int TypeID;
        private void SelectType(string obj)
        {
            TypeId = new ObservableCollection<int>(_model.MonitoringTypes.Where(p => p.Type == obj).Select(p => p.ID));
            TypeID = TypeId.ElementAt(0);
            OnPropertyChanged(nameof(TypeID));
        }        

        private string namePoint;
        public string NamePoint
        {
            get { return namePoint; }
            set {
                namePoint = value;
                OnPropertyChanged(nameof(NamePoint));
            }
        }

        private string namePost;
        public string NamePost
        {
            get => namePost; 
            set { 
                namePost = value; 
                OnPropertyChanged(nameof(NamePost));
            }
        }

        private double quantityNum;
        public double QuantityNum
        {
            get => quantityNum;
            set
            {
                quantityNum = value;
                OnPropertyChanged(nameof(QuantityNum));
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public ObservableCollection<Monitoring> Monitorings { get; set; }
        public Monitoring Monitor;

        public Command SaveData { get; set; }
        private void SaveMonitoring()
        {
            //Monitor.Date = this.Date;
            Monitor.PointName = this.namePoint;
            Monitor.PostName = this.NamePost;
            Monitor.Quantity = this.QuantityNum;
            _model.SaveChanges();
        }
        
    }
}
