using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_MelhoresPraticas.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        private ActionResult<IEnumerable<WeatherForecast>> GetResult()
        {
            var rng = new Random();
            var response = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return Ok(response);

        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            return GetResult();
        }

        [HttpGet("GetFromRoute/{id}")]
        public ActionResult<IEnumerable<WeatherForecast>> GetFromRoute([FromRoute] int id)
        {
            return GetResult();
        }

        [HttpGet("GetFromHeader")]
        public ActionResult<IEnumerable<WeatherForecast>> GetFromHeader([FromHeader] int id)
        {
            return GetResult();
        }

        [HttpGet("GetFromQuery")]
        public ActionResult<IEnumerable<WeatherForecast>> GetFromQuery([FromQuery] int id)
        {
            return GetResult();
        }

        [HttpPost("PostFromBody")]
        public ActionResult<IEnumerable<WeatherForecast>> PostFromBody([FromBody] WeatherForecast value)
        {
            return GetResult();
        }

        [HttpPost("PostFromForm")]
        public ActionResult<IEnumerable<WeatherForecast>> PostFromForm([FromForm] WeatherForecast value)
        {
            return GetResult();
        }

    }

}
