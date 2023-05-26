using System;
using _DemoViewModel;
using System.Windows;
using System.Windows.Controls;

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
        }

        private void PollutionFieldBtn_Click(object sender, RoutedEventArgs e)
        {
            PollutionFieldWindow window = new();
            window.Show();
        }

        private void MonitoringBtn_Click(object sender, RoutedEventArgs e)
        {
            MonitoringWindow window = new();
            window.Show();
        }
    }
}
