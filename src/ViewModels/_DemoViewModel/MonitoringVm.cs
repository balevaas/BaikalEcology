using _DemoViewModel.DTO;
using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using ViewModelBase;
using ViewModelBase.Commands.AsyncCommands;

namespace _DemoViewModel
{
    public class MonitoringVm : ViewModel
    {
        private readonly DataContext _model;

        public MonitoringVm(DataContext model)
        {
            _model = model;
            // Получение данных из таблицы Monitorings, заполнение таблицы
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
            // Команда для удаления определенной строки из таблицы
            MonitoringDelete = new AsyncCommand(async _ =>
            {
                if (SelectedItem == null) return;
                _model.Monitorings.Remove(await _model.Monitorings.FirstOrDefaultAsync(m => m.ID == SelectedItem.Id));
                Monitorings.Remove(SelectedItem);
                await _model.SaveChangesAsync();
                OnPropertyChanged(nameof(Monitorings));
            });
        }

        public MonitoringDto SelectedItem { private get; set; }
        public ObservableCollection<MonitoringDto> Monitorings { get; }
        public AsyncCommand MonitoringDelete { get; }
    }
}