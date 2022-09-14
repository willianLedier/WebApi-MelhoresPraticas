using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using WebAppMVC.Models;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class HttpClientController : Controller
    {
        private readonly ILogger<HttpClientController> _logger;
        private readonly IWeatherForecastHttpClient _weatherForecastHttpClient;

        public HttpClientController(ILogger<HttpClientController> logger,
            IWeatherForecastHttpClient weatherForecastHttpClient)
        {
            _logger = logger;
            _weatherForecastHttpClient = weatherForecastHttpClient;
        }
        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> Get()
        {
            var response = await _weatherForecastHttpClient.Get();
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> GetFromRoute(int id)
        {
            var response = await _weatherForecastHttpClient.GetFromRoute(id);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> GetFromHeader(int id)
        {
            var response = await _weatherForecastHttpClient.GetFromHeader(id);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> GetFromQuery(int id)
        {
            var response = await _weatherForecastHttpClient.GetFromQuery(id);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> PostFromBody(WeatherForecastDTO weatherForecastDTO)
        {
            var response = await _weatherForecastHttpClient.PostFromBody(weatherForecastDTO);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> PostFromForm(WeatherForecastDTO weatherForecastDTO)
        {
            var response = await _weatherForecastHttpClient.PostFromForm(weatherForecastDTO);
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
