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
    public class MonitoringVm : ViewModel
    {
        private readonly DataContext _model;
        public string TypesID;
        public string HarmName;
        public int IDMon;

        public MonitoringVm (DataContext model)
        {
            _model = model;
            Monitorings = new(_model.Monitorings);

        }

        public ObservableCollection<Monitoring> Monitorings { get; }
        public ObservableCollection<MonitoringType> MonitoringTypes { get; }
    }
}
