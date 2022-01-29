using System;
using System.Globalization;
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
using Humanizer;

namespace Cap4_5
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
        public void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            long b = long.TryParse(BaseTextBox.Text, out b) ? b : 0;

            if (b > 0)
            {
                ResultTextBlock.Text = "= " + b.ToWords(culture: new CultureInfo("es-ES"));
            }
            else
            {
                ResultTextBlock.Text = "";
                MessageBox.Show("Ingrese numeros validos");
            }
        }
        public static double factorial(double number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial(number - 1);
        }
    }
}
