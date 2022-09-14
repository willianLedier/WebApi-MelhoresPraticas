using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public class WeatherForecastHttpClient : IWeatherForecastHttpClient
    {

        private readonly IHttpClientCustom _httpClientCustom;
        private readonly IConfiguration _configuration;

        public WeatherForecastHttpClient(IHttpClientCustom httpClientCustom, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientCustom = httpClientCustom;
            _httpClientCustom.BaseAddress = new System.Uri(_configuration.GetSection("URI_WeatherForecastAPI").Value);
        }

        public async Task<IEnumerable<WeatherForecastDTO>> Get()
        {
            return await _httpClientCustom.GetAsync<List<WeatherForecastDTO>>($"/WeatherForecast");
        }

        public async Task<IEnumerable<WeatherForecastDTO>> GetFromHeader(int id)
        {
            return await _httpClientCustom.GetAsync<List<WeatherForecastDTO>>($"/WeatherForecast/GetFromHeader?id={id}");
        }

        public async Task<IEnumerable<WeatherForecastDTO>> GetFromQuery(int id)
        {
            return await _httpClientCustom.GetAsync<List<WeatherForecastDTO>>($"/WeatherForecast/GetFromQuery?id={id}");
        }

        public async Task<IEnumerable<WeatherForecastDTO>> GetFromRoute(int id)
        {
            return await _httpClientCustom.GetAsync<List<WeatherForecastDTO>>($"/WeatherForecast/GetFromRoute/{id}");
        }

        public async Task<IEnumerable<WeatherForecastDTO>> PostFromBody(WeatherForecastDTO value)
        {
            return await _httpClientCustom.PostAsync<List<WeatherForecastDTO>>("/WeatherForecast/PostFromBody", value);
        }

        public async Task<IEnumerable<WeatherForecastDTO>> PostFromForm(WeatherForecastDTO value)
        {
            return await _httpClientCustom.PostAsync<List<WeatherForecastDTO>>("/WeatherForecast/PostFromForm", value);
        }

    }
}
