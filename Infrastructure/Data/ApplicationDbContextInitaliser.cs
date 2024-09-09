using Application.Common.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Domain.Entities;

namespace Infrastructure.Data;

public class ApplicationDbContextInitaliser
{
    private readonly ApplicationDbContext _dbContext;
    public ApplicationDbContextInitaliser( ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SeedAsync()
    {
        if (!_dbContext.Movie.Any())
        {

            _dbContext.Add(new Movie()
            {
                Title = "Harry Potter",
                Description = $"Harry Potter and the Chamber of Secrets is a 2002 fantasy film directed by Chris Columbus " +
                $"from a screenplay by Steve Kloves. " +
                $"It is based on the 1998 novel Harry Potter and the Chamber of Secrets by J. K. Rowling.",
                Author = "J. K. Rowling",
                Duration = 120,
                Url = "https://www.imdb.com/title/tt0295297/"
            });
        }

        await _dbContext.SaveChangesAsync();
    }


}
