using System.Windows;
using static ConnectionConfig.Strings;

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
            WindRoseBtn.CommandParameter = GetPath(Globa);
            //BenzopyreneBtn.CommandParameter = GetPath(Berezina);
            //DustBtn.CommandParameter = GetPath(Safronov);
            //MercuryBtn.CommandParameter = GetPath(Markov);
            ImpuritiesBtn.CommandParameter = GetPath(Slyusar);
            //Correlation1Btn1.CommandParameter = GetPath(Pavlov);
            MinimaxBtn1.CommandParameter = GetPath(Pinigin);
            //Correlation2Btn1.CommandParameter = GetPath(Biryukov);
        }

        private void DataBaseBtn_Click(object sender, RoutedEventArgs e)
        {
            DataBaseWindow dataBase = new();
            dataBase.Show();
        }
    }
}
