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
    /// Логика взаимодействия для DataBaseWindow.xaml
    /// </summary>
    public partial class DataBaseWindow : Window
    {
        public DataBaseWindow()
        {
            InitializeComponent();
        }

        private void pollBtn_Click(object sender, RoutedEventArgs e)
        {
            PollutionFieldWindow pollutionFieldWindow = new PollutionFieldWindow();
            pollutionFieldWindow.Show();
        }

        private void atmBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void snowBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bioBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
        }
    }
}
