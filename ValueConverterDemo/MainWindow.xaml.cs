using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace ValueConverterDemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbDays.ItemsSource = Enumerable.Range(1,10);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var forecasts = new List<Forecast>();
            var days = (int) cmbDays.SelectedItem;
            var rand = new Random();

            for (int i = 0; i < days; i++)
            {
                var temp = rand.Next(10, 50);
                var forecast = new Forecast
                {
                    GeneralForecast = (GeneralForecast)rand.Next(Enum.GetNames(typeof(GeneralForecast)).Length),
                    TemperatureLow = temp,
                    TemperatureHigh = temp + 10,
                    Percipitation = temp - 10
                };
                forecasts.Add(forecast);
            }
            DataContext = forecasts;
        }
    }
}