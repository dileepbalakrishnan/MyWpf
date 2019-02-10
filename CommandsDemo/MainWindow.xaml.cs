using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using CommandsDemo.Annotations;
using Microsoft.Win32;

namespace CommandsDemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageData _imageData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif"
            };
            if (dlg.ShowDialog() == true)
            {
                _imageData = new ImageData(dlg.FileName);
                DataContext = _imageData;
            }
        }

        private void OnDecreaseZoom(object sender, ExecutedRoutedEventArgs e)
        {
            _imageData.Zoom /= 1.2;
        }

        private void OnImageExist(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _imageData != null;
        }

        private void OnIncreaseZoom(object sender, ExecutedRoutedEventArgs e)
        {
            _imageData.Zoom *= 1.2;
        }

        private void OnNormal(object sender, ExecutedRoutedEventArgs e)
        {
            _imageData.Zoom = 1.0;
        }
    }

    public class ImageData : INotifyPropertyChanged
    {
        private double _zoom = 1.0;

        public ImageData(string imagePath)
        {
            ImagePath = imagePath;
        }

        public string ImagePath { get; }

        public double Zoom
        {
            get => _zoom;
            set
            {
                _zoom = value;
                OnPropertyChanged(nameof(Zoom));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public static class Commands
    {
        private static readonly RoutedUICommand _zoomNormalCommand =
            new RoutedUICommand("Zoom Normal", "Original", typeof(Commands), new InputGestureCollection{new KeyGesture(Key.N,ModifierKeys.Alt)});

        public static RoutedUICommand ZoomNormalCommand => _zoomNormalCommand;
    }
}