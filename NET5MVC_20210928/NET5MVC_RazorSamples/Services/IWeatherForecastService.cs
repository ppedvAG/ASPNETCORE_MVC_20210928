using NET5MVC_RazorSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.Services
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> WeatherForecasts();
    }
}
