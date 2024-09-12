using Application.Movies.Commands.CreateMovie;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly ILogger<MovieController> _logger;
        private readonly CreateMovieCommandHandlerMovie _createMovieCommandHandler;

        public MovieController(ILogger<MovieController> logger, CreateMovieCommandHandlerMovie createMovieCommandHandler)
        {
            _logger = logger;
            _createMovieCommandHandler = createMovieCommandHandler;
        }

        [HttpGet(Name = "GetMovie")]
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
            Movie myMovie = _createMovieCommandHandler.CreateMovie(harryPotter);
            return myMovie;

        }
    }
}
