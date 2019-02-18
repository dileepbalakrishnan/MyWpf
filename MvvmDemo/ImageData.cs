using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommandsDemo.Annotations;
using MvvmDemo.Commands;

namespace MvvmDemo
{
    public class ImageData : INotifyPropertyChanged
    {
        private double _zoom = 1.0;
        private string _imagePath;
        private ICommand _openImageFileCommand;
        private ICommand _zoomCommand;

        public ImageData()
        {
            _openImageFileCommand = new OpenImageFileCommand(this);
            _zoomCommand = new ZoomCommand(this);
        }
        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }

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

        public ICommand OpenImageFileCommand => _openImageFileCommand;

        public ICommand ZoomCommand => _zoomCommand;
    }
}