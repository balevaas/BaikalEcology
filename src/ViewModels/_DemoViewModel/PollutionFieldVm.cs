using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseData.DataProviders.EntityFramework.Contexts;
using ViewModelBase;

namespace _DemoViewModel
{
    public class PollutionFieldVm : ViewModel
    {
        private readonly DataContext _model;

        public PollutionFieldVm(DataContext model)
        {
            _model = model;
            Dates = new (model.PollutionFields.Select(p => p.Date));
        }

        public ObservableCollection<DateTime> Dates { get; set; }
    }
}
