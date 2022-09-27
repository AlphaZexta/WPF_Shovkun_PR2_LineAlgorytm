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

namespace WPF_Shovkun_PR2_LineAlgorytm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text = Environment.NewLine + "PR2";
            double x = double.Parse(X.Text);
            Itog.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(Y.Text);
            Itog.Text += Environment.NewLine + "Y = " + y.ToString();

            double a = (x * x / 2);
            double b = (y * y / 4);
            double u = 1 + a + b;

            Itog.Text += Environment.NewLine + "U = " + u.ToString();
        }
    }
}
