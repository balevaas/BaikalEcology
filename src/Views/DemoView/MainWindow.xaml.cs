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
using System.Windows.Navigation;
using System.Windows.Shapes;
using _DemoViewModel;

namespace DemoView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void windRoseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void benzopyreneBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mercuryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dustBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void impuritiesBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void correlationBtn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void minimaxBtn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void correlation2Btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataBaseBtn_Click(object sender, RoutedEventArgs e)
        {
            DataBaseWindow dataBase = new DataBaseWindow();
            dataBase.Show();
        }
    }
}
