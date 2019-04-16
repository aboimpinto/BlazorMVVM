using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorMVVM.Entities;
using Microsoft.AspNetCore.Blazor;

namespace BlazorMVVM.Models
{
    public class WeatherForecastModel : IWeatherForecastModel
    {
        private readonly HttpClient http;

        public WeatherForecastModel(HttpClient http)
        {
            this.http = http;
        } 

        public async Task<IReadOnlyCollection<WeatherForecast>> FetchWeatherForecast()
        {
            return await this.http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}