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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        bool isBi = false;
        bool isOct = false;

        public void Exit (Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void bi(Object sender, RoutedEventArgs e)
        {
            isBi = true;
            isOct = false;
        }

        public void oct(Object sender, RoutedEventArgs e)
        {
            isBi = false;
            isOct = true;
        }

        public void Calculate(Object sender, RoutedEventArgs e)
        {
            if (isBi is true)
            {
                userOutput.Text = Convert.ToString( int.Parse(userInput.Text), 2 );
            }

            if (isOct is true)
            {
                userOutput.Text = Convert.ToString(int.Parse(userInput.Text), 8);
            }
        }

        public void Reset(Object sender, RoutedEventArgs e)
        {
            userInput.Text = "";
            userOutput.Text = "";
        }
    }
}
