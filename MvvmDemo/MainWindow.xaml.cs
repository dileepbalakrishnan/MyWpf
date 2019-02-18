using System.Windows;

namespace MvvmDemo
{
    public partial class MainWindow : Window
    {
        private ImageData _imageData;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ImageData();
        }
    }
}