using ConsoleAppRefit.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleAppRefit.Services
{
    public interface IWeatherForecastRefit
    {
       
        [Get("/WeatherForecast")]
        Task<WeatherForecastDTO> Get();

        [Get("/WeatherForecast/GetFromRoute/{id}")]
        Task<WeatherForecastDTO> GetFromRoute(int id, WeatherForecastDTO value);

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
