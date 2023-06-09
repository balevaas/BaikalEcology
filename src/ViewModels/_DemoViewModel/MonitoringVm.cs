using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using ViewModelBase;

namespace _DemoViewModel
{
    public class MonitoringVm : ViewModel
    {
        private readonly DataContext _model;
        public int IdMon;
        public int IdDto;

        public MonitoringVm(DataContext model)
        {
            _model = model;
            Monitorings = new(_model.Monitorings.Include(m => m.MonitoringType).Include(m => m.Substance).Select(m =>
                new MonitoringDto()
                {
                    Id = m.ID,
                    MonitoringType = m.MonitoringType.ToString(),
                    Date = m.Date,
                    PointName = m.PointName,
                    PostName = m.PostName,
                    HarmName = m.Substance.ToString(),
                    Quantity = m.Quantity
                }));

        }


        public ObservableCollection<MonitoringDto> Monitorings { get; }
        public class MonitoringDto
        {
            public int Id { get; set; }
            public string MonitoringType { get; set; }
            public DateTime Date { get; set; }
            public string PointName { get; set; }
            public string PostName { get; set; }
            public string HarmName { get; set; }
            public double Quantity { get; set; }
        }


    }
}