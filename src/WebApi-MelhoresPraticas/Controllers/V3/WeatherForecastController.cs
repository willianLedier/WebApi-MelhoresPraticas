using Microsoft.AspNetCore.Mvc;
using WebApi_MelhoresPraticas.Controllers.Base;
using WebApi_MelhoresPraticas.Models;
using WebApi_MelhoresPraticas.Services;

namespace WebApi_MelhoresPraticas.Controllers.v3
{

    [ApiVersion("3.0")]
    public class WeatherForecastController : BaseController<WeatherForecastDTO, int>

    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appService"></param>
        public WeatherForecastController(IWeatherForecastAppService appService) : base(appService) { }

    }

}
