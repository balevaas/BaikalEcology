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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
