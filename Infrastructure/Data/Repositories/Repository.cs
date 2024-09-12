using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading;

namespace Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private readonly ApplicationDbContext _dbContext;
        public void Add(T entity)
            
        {
            _dbContext.Add(entity);
        }

        public T Get(
            Expression<Func<T, bool>> filter,
            string? includeProperties = null,
            bool tracked = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
