using System;

namespace WebApi_MelhoresPraticas.Models
{
    public class WeatherForecastDTO : BaseDTOEntity<int>
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
