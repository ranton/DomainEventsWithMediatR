﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEvents.ApiModels
{
    public class AddWeatherForecast
    {
        public DateTime Date { get; set; } 
        public int TemperatureC { get; set; } 
        public string Summary { get; set; }
    }

    public class UpdateWeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}
