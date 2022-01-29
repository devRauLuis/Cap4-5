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

        public Table table = new Table { Num = 0 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = table;
        }
        public void OnGetTableClick(object sender, RoutedEventArgs e)
        {
            int n = int.TryParse(NumberTextBox.Text, out n) ? n : 0;
            if (n > 0)
            {
                TableListBox.ItemsSource = GetTable(n);

            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }


        public static List<int> GetTable(int num)
        {
            var list = new List<int>();
            foreach (int value in Enumerable.Range(1, 10).Select(x => x * num))
            {
                list.Add(value);
            }

            return list;
        }

    }
}
