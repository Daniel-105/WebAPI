using Application.Common.Interfaces;
using AutoMapper;
using WebAPI.Domain.Entities;

namespace Application.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandlerMovie(IRepository<Movie> movieRepository)
{
    private readonly IRepository<Movie> _movieRepository;
    public CreateMovieCommandHandlerMovie(IRepository<Movie> movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public void CreateMovie(Movie movie)
    {
        _movieRepository.Add(movie);
    }

}
