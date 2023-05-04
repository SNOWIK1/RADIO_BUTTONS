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

namespace Buttons_Switchers_Hints
{
    /// <summary>
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        public void RED (Object sender, RoutedEventArgs e)
        {
            yellow.Background = Brushes.LightGray;
            green.Background = Brushes.LightGray;
            red.Background = Brushes.Red;
        }

        public void YELLOW(Object sender, RoutedEventArgs e)
        {
            green.Background = Brushes.LightGray;
            red.Background = Brushes.LightGray;
            yellow.Background = Brushes.Yellow;
        }

        public void GREEN(Object sender, RoutedEventArgs e)
        {
            red.Background = Brushes.LightGray;
            yellow.Background = Brushes.LightGray;
            green.Background = Brushes.Green;
        }

        private void Task3 (Object sender, RoutedEventArgs e)
        {
            Window1 task3 = new Window1();
            task3.Show();
            this.Close();
        }
    }
}
