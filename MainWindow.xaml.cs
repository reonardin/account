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

namespace WpfApp3
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(int_income.Text);
            double y = double.Parse(int_expenses.Text);
            double z = double.Parse(int_taget.Text);
            double w = x - y;
            double t = z / w;
            string mystring = t.ToString();
            total.Text = mystring;
            


        }
    }
}