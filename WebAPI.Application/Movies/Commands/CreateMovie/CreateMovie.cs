using Application.Common.Interfaces;
using AutoMapper;
using WebAPI.Domain.Entities;

namespace Application.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandler(IRepository<Movie> movieRepository)
{
    private readonly IRepository<Movie> _movieRepository;
    public void CreateMovieCommasndHandler(Movie movie)
    {
        _movieRepository.Add(movie);
    }

}
