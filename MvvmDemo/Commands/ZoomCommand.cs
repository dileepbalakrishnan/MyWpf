using System;
using System.Windows.Input;

namespace MvvmDemo.Commands
{
    public class ZoomCommand : ICommand
    {
        private readonly ImageData _imageData;

        public ZoomCommand(ImageData imageData)
        {
            _imageData = imageData;
        }

        public bool CanExecute(object parameter)
        {
            return _imageData.ImagePath != null;
        }

        public void Execute(object parameter)
        {
            var zoomType = (ZoomType) Enum.Parse(typeof(ZoomType), (string) parameter, true);
            switch (zoomType)
            {
                case ZoomType.ZoomIn:
                    _imageData.Zoom *= 1.2;
                    break;
                case ZoomType.ZoomOut:
                    _imageData.Zoom /= 1.2;
                    break;
                case ZoomType.ZoomNormal:
                    _imageData.Zoom = 1.0;
                    break;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }

    internal enum ZoomType
    {
        ZoomIn,
        ZoomOut,
        ZoomNormal
    }
}