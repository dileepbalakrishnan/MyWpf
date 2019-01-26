using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CollectionBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> _people = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            PopulatePeople();
            DataContext = _people;
        }

        private void PopulatePeople()
        {
            _people.Add(new Person{Name = "Dileep", Age = 35});
            _people.Add(new Person { Name = "Manu", Age = 45 });
            _people.Add(new Person { Name = "Balaji", Age = 32});
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return Name + " is " + Age + " years old.";
        }
    }
}
