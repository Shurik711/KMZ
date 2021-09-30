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
using MySql.Data.MySqlClient;

namespace KMZ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Первоначальная страница
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, e) => { TIME.Text = DateTime.Now.ToLongTimeString(); };
            //Запуск таймер
            timer.Start();
        }

        private void BtnBuy(object sender, RoutedEventArgs e)
        {
            Slad1.Navigate(new Page3());
        }
        private void FrameOp2(object sender, RoutedEventArgs e)
        {
            Slad1.Navigate(new Page2());
        }

        private void FrameOp1(object sender, RoutedEventArgs e)
        {
            Slad1.Navigate(new Page1());
        }

        private void Input4(object sender, RoutedEventArgs e)
        {

            string conn = "server=localhost;user=root;database=kmz;password=13579;";
            MySqlConnection mycon = new MySqlConnection(conn);
            mycon.Open();
            MessageBox.Show("BD Connect");
            mycon.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}

