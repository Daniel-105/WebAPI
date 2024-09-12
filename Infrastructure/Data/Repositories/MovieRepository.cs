using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Entities;

namespace Infrastructure.Data.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieRepository(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public Movie Get(Expression<Func<Movie, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
