using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MultiBindingDemo
{
    public class RgbConverter : IMultiValueConverter
    {
        private readonly SolidColorBrush _brush = new SolidColorBrush();

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var color = Color.FromRgb(System.Convert.ToByte(values[0]), System.Convert.ToByte(values[1]),
                System.Convert.ToByte(values[2]));
            _brush.Color = color;
            return _brush;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}