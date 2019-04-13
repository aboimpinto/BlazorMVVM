using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorMVVM.Entities;
using BlazorMVVM.Models;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorMVVM.ViewModels
{
    public class FetchDataViewModel : IFetchDataViewModel, ILoadable
    {
        #region Private Fields 
        private readonly IWeatherForecastModel model;
        #endregion

        #region Constructor
        public FetchDataViewModel(IWeatherForecastModel model)
        {
            this.model = model;
        } 
        #endregion

        #region ILoadable implementation  
        public async Task Load()
        {
            Console.WriteLine("FetchDataViewModel Loaded method called.");

            await this.RetrieveWeatherForecast();
        }
        #endregion

        #region IFetchDataViewModel implementation
        public IReadOnlyCollection<WeatherForecast> WeatherForecast { get; private set; }

        public async Task RetrieveWeatherForecast()
        {
            Console.WriteLine("ListWeatherForecast!!!");

            this.WeatherForecast = await this.model.FetchWeatherForecast();
        }
        #endregion
    }    
}