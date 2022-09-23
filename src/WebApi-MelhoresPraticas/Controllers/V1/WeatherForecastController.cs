using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi_MelhoresPraticas.Models;

namespace WebApi_MelhoresPraticas.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
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

        private ActionResult<IEnumerable<WeatherForecastDTO>> GetResult()
        {
            var rng = new Random();
            var response = Enumerable.Range(1, 5).Select(index => new WeatherForecastDTO
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return Ok(response);

        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecastDTO>> Get()
        {
            return GetResult();
        }

        [HttpGet("GetFromRoute/{id}")]
        public ActionResult<IEnumerable<WeatherForecastDTO>> GetFromRoute([FromRoute] int id)
        {
            return GetResult();
        }

        [HttpGet("GetFromHeader")]
        public ActionResult<IEnumerable<WeatherForecastDTO>> GetFromHeader([FromHeader] int id)
        {
            return GetResult();
        }

        [HttpGet("GetFromQuery")]
        public ActionResult<IEnumerable<WeatherForecastDTO>> GetFromQuery([FromQuery] int id)
        {
            return GetResult();
        }

        [HttpPost("PostFromBody")]
        public ActionResult<IEnumerable<WeatherForecastDTO>> PostFromBody([FromBody] WeatherForecastDTO value)
        {
            return GetResult();
        }

        [HttpPost("PostFromForm")]
        public ActionResult<IEnumerable<WeatherForecastDTO>> PostFromForm([FromForm] WeatherForecastDTO value)
        {
            return GetResult();
        }

    }

}
