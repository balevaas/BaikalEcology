using _DemoViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DemoView
{
    /// <summary>
    /// Логика взаимодействия для PollutionFieldWindow.xaml
    /// </summary>
    public partial class PollutionFieldWindow : Window
    {
        private readonly PollutionFieldVm _context;
        public PollutionFieldWindow()
        {
            InitializeComponent();
            _context = new PollutionFieldVm((Application.Current as App)?.Context!);
            DataContext = _context;
        }

        private void DatePollutionCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox box || box.SelectedItem == null) return;
            _context.SelectDateCommand?.Execute((DateTime)DatePollutionCB.SelectedItem);
        }

        private void NamePollutionCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox box || box.SelectedItem == null) return;
            _context.SelectNameCommand?.Execute((String)NamePollutionCB.SelectedItem);
        }

        private void ExportImageBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void VisualPollutionBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}