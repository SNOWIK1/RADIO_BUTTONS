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

namespace Buttons_Switchers_Hints
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

        private void Addition(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) + double.Parse(second.Text)).ToString();
        }

        private void Subtraction(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) - double.Parse(second.Text)).ToString();
        }

        private void Multiplication(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) * double.Parse(second.Text)).ToString();
        }

        private void Division(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) / double.Parse(second.Text)).ToString();
        }
        private void Exponentiation(object sender, RoutedEventArgs e)
        {
            double resultExp = 1;
            for (int i = 0; i < int.Parse(second.Text); i++)
            {
                resultExp *= int.Parse(first.Text);
            }

            result.Text = resultExp.ToString();
        }
        private void Remainder(object sender, RoutedEventArgs e)
        {
            double division = double.Parse(first.Text) / double.Parse(second.Text);

            string digit = division.ToString();
            string[] digits = digit.Split(',');

            result.Text = digits[1];
        }

        private void Task2(object sender, RoutedEventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
            this.Close();
        }

    }
}
