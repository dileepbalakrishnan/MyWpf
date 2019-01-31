using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConverterDemo
{
    public class ForecastToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var gneralForecast = (GeneralForecast) value;
            switch (gneralForecast)
            {
                case GeneralForecast.Cloudy:
                    return Brushes.Gray;
                case GeneralForecast.Dry:
                    return Brushes.AntiqueWhite;
                case GeneralForecast.Rainy:
                    return Brushes.LightGreen;
                case GeneralForecast.Snowy:
                    return Brushes.LightBlue;
                case GeneralForecast.Sunny:
                    return Brushes.Yellow;
                default: return Binding.DoNothing;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}