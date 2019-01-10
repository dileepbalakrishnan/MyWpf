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

namespace PropertyInheritance
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

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            TextBlock4.ClearValue(TextBlock.FontSizeProperty);
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            TextBlock4.SetValue(TextBlock.FontSizeProperty, 35.0);
        }
    }
}
