using System.Collections.Generic;
using System.Windows;

namespace SharedRowColumnSizeDemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBoxes();
        }

        private void PopulateListBoxes()
        {
            var people = new List<Person>
            {
                new Person
                {
                    Name = "Dileep",
                    Age = 35
                },
                new Person
                {
                    Name = "Bindu",
                    Age = 32
                },
                new Person
                {
                    Name = "Kukkudu",
                    Age = 2
                }
            };

            people.ForEach(p =>
            {
                lst1.Items.Add(p);
                lst2.Items.Add(p);
            });
        }
    }
}