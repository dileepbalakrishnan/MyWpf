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

namespace TypedDataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            var people = new List<Person>
            {
                new Person
                {
                    Name = "Dileep",
                    Age = 35
                },
                new Engineer
                {
                    Name = "Dileep",
                    Age = 35,
                    Stream = "Computer"
                },
                new Engineer
                {
                    Name = "Dileep",
                    Age = 35,
                    Stream = "Electronics"
                }
            };
            DataContext = people;
        }
    }
}
