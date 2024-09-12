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
        private readonly CreateMovieCommandHandler _createMovieCommandHandler;

        public MovieController(ILogger<MovieController> logger, CreateMovieCommandHandler createMovieCommandHandler)
        {
            _logger = logger;
            _createMovieCommandHandler = createMovieCommandHandler;
        }

        [HttpGet(Name = "GetMovie")]
        public IEnumerable<Movie> Get()
        {
            Movie myMovie = _createMovieCommandHandler.HandleSingleOperation();
            IEnumerable<Movie> movies = new List<Movie>();
            return movies;

        }
    }
}
