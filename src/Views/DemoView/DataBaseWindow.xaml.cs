using _DemoViewModel;
using System.Windows;

namespace DemoView
{
    /// <summary>
    /// Логика взаимодействия для DataBaseWindow.xaml
    /// </summary>
    public partial class DataBaseWindow : Window
    {
        public DataBaseWindow()
        {
            InitializeComponent();
            DataContext = new PollutionFieldVm((Application.Current as App)?.Context!);
            //DataContext = new MonitoringVm((Application.Current as App)?.Context!);
        }

        private void VisualPollutionBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExportImageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteMonitoringBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMonitoringBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateMonitoringBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
