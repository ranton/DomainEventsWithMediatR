using System;

namespace DomainEvents
{
    public class WeatherForecast
    {
        public WeatherForecast(DateTime date, int temperatureC, string summary)
        {
            this.Date = date;
            this.TemperatureC = temperatureC;
            this.Summary = summary;
        }

        public DateTime Date { get; }

        public int TemperatureC { get; private set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; private set; }       
        

        public void UpdateForecast(int temperatureC, string summary)
        {
            this.TemperatureC = temperatureC;
            this.Summary = summary;

            DomainEvents.Raise(new UpdateForecastEvent()
            {
                Date = this.Date,
                TemperatureC = temperatureC
            }).Wait();
        }
    }
}
