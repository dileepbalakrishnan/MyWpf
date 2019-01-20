using System.Windows;

namespace UniformGridDemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateListbox();
        }

        private void PopulateListbox()
        {
            for (var i = 0; i < 100; i++)
                lst1.Items.Add(i);
        }
    }
}