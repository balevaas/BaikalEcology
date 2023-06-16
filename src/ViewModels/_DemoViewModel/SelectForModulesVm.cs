using _DemoViewModel.DTO;
using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelBase;

namespace _DemoViewModel
{
    public class SelectForModulesVm : ViewModel
    {
        private readonly DataContext _model;
        public SelectForModulesVm(DataContext model) 
        {
            model = _model;
            //WeatherData = new(_model.)
            PollutionData = new(_model.PollutionFields.Include(m => m.LinkFile).Select(m =>
                new PollutionDto()
                {
                    LinkFile = m.LinkFile
                }));
        }
        public ObservableCollection<WeatherDataDto> WeatherData { private get; set; }
        public ObservableCollection<PollutionDto> PollutionData { private get; set;}
        /*Monitorings = new(_model.Monitorings.Include(m => m.MonitoringType).Include(m => m.Substance).Select(m =>
                new MonitoringDto()
                {
                    Id = m.ID,
                    MonitoringType = m.MonitoringType.ToString(),
                    Date = m.Date,
                    PointName = m.PointName,
                    PostName = m.PostName,
                    HarmName = m.Substance.ToString(),
                    Quantity = m.Quantity
                }));*/
    }
}
