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
            int b = int.TryParse(BaseTextBox.Text, out b) ? b : 0;
            int n = int.TryParse(PowerTextBox.Text, out n) ? n : 0;

            if (b > 0 && n > 0)
            {
                ResultTextBlock.Text = "= " + Math.Pow(b, n).ToString();
            }
            else if (b > 0 && n <= 0)
            {
                ResultTextBlock.Text = "= 1";
            }
            else
            {
                ResultTextBlock.Text = "";
                MessageBox.Show("Ingrese numeros validos");
            }
        }
    }
}
