using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorMVVM.Entities;

namespace BlazorMVVM.Models
{
    public interface IWeatherForecastModel
    {
         Task<IReadOnlyCollection<WeatherForecast>> FetchWeatherForecast();
    }
}