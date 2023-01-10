using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double first;
        private double second;
        public double third;
        
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (First.Text != "")
            {
                first = Convert.ToDouble(First.Text);
            }
            if (Second.Text != "")
            {
                second = Convert.ToDouble(Second.Text);
            }
            if (Operand.Text != "")
            {
                if (Operand.Text == "+")
                {
                    double result = first + second;
                    Result.Text = Convert.ToString(result, CultureInfo.InvariantCulture);
                }
                else if (Operand.Text == "-")
                {
                    Result.Text = Convert.ToString(first - second);
                }
                else if (Operand.Text == "*")
                {
                    Result.Text = Convert.ToString(first * second);
                }
                else if (Operand.Text == "/")
                {
                    if (Second.Text=="0")
                    {
                        Result.Text = ("Зачем делить на ноль?");
                    }

                    else
                    {
                        Result.Text = Convert.ToString(first / second);
                    }
                }

            }


        }

        private void right_TextChanged(Object sender, TextChangedEventArgs e)
        {

        }

        private void left_TextChanged(Object sender, TextChangedEventArgs e)
        {

        }

        private void result_TextChanged(Object sender, TextChangedEventArgs e)
        {

        }
    }
}
