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

namespace SimpleDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BiindTextBlock();
        }

        private void BiindTextBlock()
        {
            var binding1 = new Binding("Value") {Source = _slider};
            _textBlock2.SetBinding(TextBlock.TextProperty, binding1);
            _textBlock2.SetBinding(TextBlock.FontSizeProperty, binding1);
        }
    }
}
