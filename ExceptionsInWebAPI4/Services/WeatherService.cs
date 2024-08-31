using ExceptionsInWebAPI4.Exceptions;

namespace ExceptionsInWebAPI4.Services
{

    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get(string cityname);
    }

    public class WeatherService : IWeatherService
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> Get(string cityname)
        {
            if (cityname == "Bengaluru")
                throw new DomainNotFoundException("NO weather data for Bengaluru");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
