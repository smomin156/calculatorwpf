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

namespace CalculatorApp
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

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void btnOff_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception )
            {
                txtResult.Text = "Error!";
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (txtResult.Text.Contains("+"))
            {
                iOp = txtResult.Text.IndexOf("+");
            }
            else if (txtResult.Text.Contains("-"))
            {
                iOp = txtResult.Text.IndexOf("-");
            }
            else if (txtResult.Text.Contains("*"))
            {
                iOp = txtResult.Text.IndexOf("*");
            }
            else if (txtResult.Text.Contains("/"))
            {
                iOp = txtResult.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = txtResult.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(txtResult.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(txtResult.Text.Substring(iOp + 1, txtResult.Text.Length - iOp - 1));

            if (op == "+")
            {
                txtResult.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                txtResult.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                txtResult.Text += "=" + (op1 * op2);
            }
            else
            {
                txtResult.Text += "=" + (op1 / op2);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            txtResult.Text += b.Content.ToString();
        }
    }
}
