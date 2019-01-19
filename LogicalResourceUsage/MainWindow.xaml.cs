using System.Windows;
using System.Windows.Media;

namespace LogicalResourceUsage
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            var brush2 = (Brush)TryFindResource("brush2");
            if (brush2 != null)
            {
                Resources["brush3"] = brush2;
            }
        }
    }
}