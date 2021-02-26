using SharedDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks; 

namespace Demoblazor3.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private HttpClient Http;
        public WeatherForecastService(HttpClient Http)
        {
            this.Http = Http;
        }
        async Task<WeatherForecast[]> IWeatherForecastService.GetAll()
        {
            return await Http.GetFromJsonAsync<WeatherForecast[]>("http://localhost:62700/WeatherForecast");
        }
    }
}
