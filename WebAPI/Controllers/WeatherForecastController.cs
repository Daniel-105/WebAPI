using Application.Movies.Commands.CreateMovie;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly CreateMovieCommandHandlerMovie _createMovieCommandHandlerMovie;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, CreateMovieCommandHandlerMovie createMovieCommandHandlerMovie)
        {
            _logger = logger;
            _createMovieCommandHandlerMovie = createMovieCommandHandlerMovie;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Movie Get()
        {
            Movie harryPotter = new()
            {
                Title = "Harry Potter",
                Description = $"Harry Potter and the Chamber of Secrets is a 2002 fantasy film directed by Chris Columbus " +
              $"from a screenplay by Steve Kloves. " +
              $"It is based on the 1998 novel Harry Potter and the Chamber of Secrets by J. K. Rowling.",
                Author = "J. K. Rowling",
                Duration = 120,
                Url = "https://www.imdb.com/title/tt0295297/"
            };
            Movie movie = _createMovieCommandHandlerMovie.CreateMovie(harryPotter);
            return movie;
        }
    }
}
