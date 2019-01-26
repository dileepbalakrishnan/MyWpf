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

namespace DataTemplateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person
            {
                Name = "Dileep",
                Age = 35
            };
            _lstPeople.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name = "Dileep",
                    Age = 35
                },
                new Person
                {
                    Name = "Bindu",
                    Age = 35
                },
                new Person
                {
                    Name = "Manu",
                    Age = 35
                }
        };
        }
    }
}
