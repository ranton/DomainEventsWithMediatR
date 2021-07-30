using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEvents.Services
{
    public interface IWeatherForecastService
    {
        void Add(DateTime date, int temperatureC, string summary);
        void Update(DateTime date, int temperatureC, string summary);
    }

    public class WeatherForecastService : IWeatherForecastService
    {
        public static List<WeatherForecast> WeatherForecasts = new() {
            new WeatherForecast(DateTime.MinValue, 12, "Summary") };

        public void Add(DateTime date, int temperatureC, string summary)
        {
            WeatherForecasts.Add(
                        new WeatherForecast(
                            date,
                            temperatureC,
                            summary
                        ));
        }

        public void Update(DateTime date, int temperatureC, string summary)
        {
            var weatherForecast = WeatherForecasts.FirstOrDefault(x => x.Date == date);
            weatherForecast.UpdateForecast(temperatureC, summary);
        }
    }    
}
