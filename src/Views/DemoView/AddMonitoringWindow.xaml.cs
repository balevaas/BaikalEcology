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

namespace DemoView
{
    /// <summary>
    /// Логика взаимодействия для AddMonitoringWindow.xaml
    /// </summary>
    public partial class AddMonitoringWindow : Window
    {
        private readonly AddMonitoringVm _context;
        public AddMonitoringWindow()
        {
            InitializeComponent();
            _context = new AddMonitoringVm((Application.Current as App)?.Context!);
            DataContext = _context;
        }

        private void TypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox box || box.SelectedItem == null) return;
            _context.SelectTypeCommand?.Execute((string)TypeCB.SelectedItem);
        }

        private void HarmCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox box || box.SelectedItem == null) return;
            _context.SelectHarmCommand?.Execute((string)HarmCB.SelectedItem);
        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
