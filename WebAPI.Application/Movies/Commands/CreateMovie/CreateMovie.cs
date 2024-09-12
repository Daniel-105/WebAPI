using Application.Common.Interfaces;
using AutoMapper;
using WebAPI.Domain.Entities;

namespace Application.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandlerMovie(IRepository<Movie> movieRepository)
{
    private readonly IRepository<Movie> _movieRepository = movieRepository;

    public Movie CreateMovie(Movie movie)
    {
      
        _movieRepository.Add(movie);
        return movie;
    }

}
