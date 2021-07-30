using DomainEvents.ApiModels;
using DomainEvents.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainEvents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;        
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpPost]
        public void Add(AddWeatherForecast model)
        {
            _weatherForecastService.Add(model.Date, model.TemperatureC, model.Summary);            
        }

        [HttpPut]
        public void Update(UpdateWeatherForecast model)
        {
            _weatherForecastService.Update(model.Date, model.TemperatureC, model.Summary);
        }
    }
}
