using _DemoViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static _DemoViewModel.MonitoringVm;
using ViewModelBase.Commands.QuickCommands;

namespace DemoView
{
    /// <summary>
    /// Логика взаимодействия для MonitoringWindow.xaml
    /// </summary>
    public partial class MonitoringWindow : Window
    {
        private readonly MonitoringVm _context;
        public MonitoringWindow()
        {
            InitializeComponent();
            _context = new MonitoringVm((Application.Current as App)?.Context!);
            DataContext = _context;
        }

        private void AddMonitoringBtn_Click(object sender, RoutedEventArgs e)
        {
            AddMonitoringWindow add = new();
            add.Show();
        }

        private async void DeleteMonitoringBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту строку?",
                    "Удаление данных",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                await _context.MonitoringDelete.ExecuteAsync();
            }
        }
    }
}
