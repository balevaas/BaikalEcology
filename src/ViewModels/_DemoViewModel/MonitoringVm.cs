using BaseData.DataProviders.EntityFramework.Contexts;
using BaseData.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelBase;

namespace _DemoViewModel
{
    public class MonitoringVm : ViewModel
    {
        private readonly DataContext _model;

        public MonitoringVm (DataContext model)
        {
            _model = model;
            Monitors = new(_model.Monitorings);
        }

        public ObservableCollection<Monitoring> Monitors { get; } 

    }
}
