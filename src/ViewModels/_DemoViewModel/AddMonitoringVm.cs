﻿using BaseData.DataProviders.EntityFramework.Contexts;
using BaseData.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _DemoViewModel.DTO;
using ViewModelBase;
using ViewModelBase.Commands.QuickCommands;
using Microsoft.EntityFrameworkCore;
using ViewModelBase.Commands.AsyncCommands;

namespace _DemoViewModel
{
    public class AddMonitoringVm : ViewModel
    {
        private readonly DataContext _model;

        public AddMonitoringVm(DataContext model)
        {
            _model = model;
            Types = new ObservableCollection<MonitoringType>(_model.MonitoringTypes); // получение данных из таблицы MonitoringType
            Harms = new ObservableCollection<HarmSubstance>(_model.HarmSubstances); // получение данных из таблицы HarmSubstance

            SaveDataCommand = new AsyncCommand(SaveData);
        }

        public AsyncCommand SaveDataCommand { get; } // Команда для сохранения новых данных

        private async Task SaveData(CancellationToken _)
        {
            // Если какое-либо поле пустое - завершаем работу
            if (SaveDataCommand == null || SelectType == null || SelectHarmSubstance == null || Date == null
                || NamePoint == null || NamePost == null || QuantityNum == 0) return;
            // Иначе, добавляем новую строку в таблицу Monitorings
            var monitor = new Monitoring()
            {
                MonitoringType = SelectType,
                Date = Date.Value,
                PointName = NamePoint,
                PostName = NamePost,
                Substance = SelectHarmSubstance,
                Quantity = QuantityNum

            };
            await _model.Monitorings.AddAsync(monitor, _);
            await _model.SaveChangesAsync(_);
        }


        #region Обработка введенного текста в простые поля


        private DateTime? _date;
        public DateTime? Date
        {
            get => _date;
            set => Set(ref _date, value);
        }

        private string namePoint;
        public string NamePoint
        {
            get => namePoint;
            set => Set(ref namePoint, value);
        }

        private string namePost;
        public string NamePost
        {
            get => namePost;
            set => Set(ref namePost, value);
        }

        private double quantityNum;
        public double QuantityNum
        {
            get => quantityNum;
            set => Set(ref quantityNum, value);
        }

        #endregion

        #region Выборка типа мониторинга и вредного вещества, получение их ID
        public ObservableCollection<MonitoringType> Types { get; set; }
        public ObservableCollection<HarmSubstance> Harms { get; set; }

        public MonitoringType SelectType { get; set; }
        public HarmSubstance SelectHarmSubstance { get; set; }
        #endregion
    }
}
