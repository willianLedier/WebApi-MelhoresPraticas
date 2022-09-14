using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public interface IWeatherForecastHttpClient
    {

        Task<IEnumerable<WeatherForecastDTO>> Get();

        Task<IEnumerable<WeatherForecastDTO>> GetFromRoute(int id);

        Task<IEnumerable<WeatherForecastDTO>> GetFromHeader(int id);

        Task<IEnumerable<WeatherForecastDTO>> GetFromQuery(int id);

        Task<IEnumerable<WeatherForecastDTO>> PostFromBody(WeatherForecastDTO value);

        Task<IEnumerable<WeatherForecastDTO>> PostFromForm(WeatherForecastDTO value);

    }
}
