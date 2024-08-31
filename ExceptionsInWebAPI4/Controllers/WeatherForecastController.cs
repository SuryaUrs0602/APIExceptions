using ExceptionsInWebAPI4.Exceptions;
using ExceptionsInWebAPI4.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionsInWebAPI4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService, ILogger<WeatherForecastController> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(string cityname)
        {
            return _weatherService.Get(cityname).ToList();           
        }
    }
}
