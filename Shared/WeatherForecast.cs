using System;

namespace BlazorApp.Shared
{
    public class ServerInfo
    {
        public string FileVersion { get; set; }

        public ServerInfo(string fileVersion)
        {
            FileVersion = fileVersion;
        }
    }
    public class WeatherResponse
    {
        public WeatherForecast[] Forecasts { get; set; }
        public ServerInfo ServerInfo { get; set; }
    }
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
