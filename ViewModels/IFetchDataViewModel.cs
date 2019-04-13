using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorMVVM.Entities;

namespace BlazorMVVM.ViewModels
{
    public interface IFetchDataViewModel
    {
        IReadOnlyCollection<WeatherForecast> WeatherForecast { get; }

         Task RetrieveWeatherForecast();
    }
}