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

        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person { Age = 0 });
            AgesDataGrid.ItemsSource = people;
        }
        public void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            AvgTextBlock.Text = $"Promedio: {((double)people.Sum(p => p.Age) / people.Count):N2}";
            MaxTextBlock.Text = $"Mayor: {people.Max(p => p.Age)}";
            MinTextBlock.Text = $"Menor: {people.Min(p => p.Age)}";
        }
    }
}
