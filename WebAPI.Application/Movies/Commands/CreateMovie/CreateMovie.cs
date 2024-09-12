using Application.Common.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using WebAPI.Domain.Entities;

namespace Application.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandlerMovie(IRepository<Movie> movieRepository)
{
    private readonly IRepository<Movie> _movieRepository = movieRepository;

    public Movie CreateMovie(Movie movie)
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
      
        _movieRepository.Add(movie);
        return movie;
    }

}
