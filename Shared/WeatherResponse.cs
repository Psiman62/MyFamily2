namespace BlazorApp.Shared
{
    public class WeatherResponse
    {
        public WeatherForecast[] Forecasts { get; set; }
        public ServerInfo ServerInfo { get; set; }
    }
}
