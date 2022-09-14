using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public interface IWeatherForecastRefit
    {

        [Get("/WeatherForecast")]
        Task<IEnumerable<WeatherForecastDTO>> Get();

        [Get("/WeatherForecast/GetFromRoute/{id}")]
        Task<IEnumerable<WeatherForecastDTO>> GetFromRoute(int id);

        [Get("/WeatherForecast/GetFromHeader")]
        Task<IEnumerable<WeatherForecastDTO>> GetFromHeader(int id);

        [Get("/WeatherForecast/GetFromQuery")]
        Task<IEnumerable<WeatherForecastDTO>> GetFromQuery(int id);

        [Post("/WeatherForecast/PostFromBody")]
        Task<IEnumerable<WeatherForecastDTO>> PostFromBody(WeatherForecastDTO value);

        [Post("/WeatherForecast/PostFromForm")]
        Task<IEnumerable<WeatherForecastDTO>> PostFromForm(WeatherForecastDTO value);

    }
}
