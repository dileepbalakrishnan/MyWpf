using System.Windows;
using System.Windows.Controls;

namespace DependencyObjectDemo.Properties
{
    /// <summary>
    ///     Interaction logic for MySimpleControl.xaml
    /// </summary>
    public partial class MySimpleControl : UserControl
    {
        // Using a DependencyProperty as the backing store for YYearPublished.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YearPublishedProperty =
            DependencyProperty.Register("YearPublished", typeof(int), typeof(MySimpleControl),
                new PropertyMetadata(2000));

        public MySimpleControl()
        {
            InitializeComponent();
        }


        public int YearPublished
        {
            get => (int) GetValue(YearPublishedProperty);
            set => SetValue(YearPublishedProperty, value);
        }
    }
}