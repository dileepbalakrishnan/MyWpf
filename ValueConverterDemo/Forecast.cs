namespace ValueConverterDemo
{
    public enum GeneralForecast
    {
        Sunny,
        Rainy,
        Snowy,
        Cloudy,
        Dry
    }
    public class Forecast
    {
        public GeneralForecast GeneralForecast { get; set; }
        public double TemperatureHigh { get; set; }
        public double TemperatureLow { get; set; }
        public double Percipitation { get; set; }
    }
}