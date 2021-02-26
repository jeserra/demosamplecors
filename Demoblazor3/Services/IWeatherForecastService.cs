using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedDemo;

namespace Demoblazor3.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetAll();
    }
}
