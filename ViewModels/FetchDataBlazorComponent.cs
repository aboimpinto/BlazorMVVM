using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorMVVM.Entities;
using BlazorMVVM.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorMVVM.ViewModels
{
    public class FetchDataBlazorComponent : BlazorComponent
    {
        [Inject]
        public IWeatherForecastModel WeatherForecastModel { get; set; }

        public IReadOnlyCollection<WeatherForecast> WeatherForecast { get; private set; }

        protected override async Task OnInitAsync()
        {
            await this.FetchWeatherForecast();
        }

        public async Task FetchWeatherForecast()
        {
            this.WeatherForecast = await this.WeatherForecastModel.FetchWeatherForecast();
        }
    }
}