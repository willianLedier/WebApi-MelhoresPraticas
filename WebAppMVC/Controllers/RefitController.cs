using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class RefitController : Controller
    {
        private readonly ILogger<RefitController> _logger;
        private readonly IWeatherForecastRefit _weatherForecastRefit;

        public RefitController(ILogger<RefitController> logger,
            IWeatherForecastRefit weatherForecastRefit)
        {
            _logger = logger;
            _weatherForecastRefit = weatherForecastRefit;
        }
        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> Get()
        {
            var response = await _weatherForecastRefit.Get();
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> GetFromRoute(int id)
        {
            var response = await _weatherForecastRefit.GetFromRoute(id);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> GetFromHeader(int id)
        {
            var response = await _weatherForecastRefit.GetFromHeader(id);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> GetFromQuery(int id)
        {
            var response = await _weatherForecastRefit.GetFromQuery(id);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> PostFromBody(WeatherForecastDTO weatherForecastDTO)
        {
            var response = await _weatherForecastRefit.PostFromBody(weatherForecastDTO);
            return View(response);
        }

        public async Task<ActionResult<IEnumerable<WeatherForecastDTO>>> PostFromForm(WeatherForecastDTO weatherForecastDTO)
        {
            var response = await _weatherForecastRefit.PostFromForm(weatherForecastDTO);
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
