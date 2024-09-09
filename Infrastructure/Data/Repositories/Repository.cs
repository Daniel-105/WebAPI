using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading;

namespace Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;
        public TEntity Add(TEntity entity)
        {
            return _dbContext.Add(entity).Entity;
        }

        public TEntity Get(
            Expression<Func<TEntity, bool>> filter,
            string? includeProperties = null,
            bool tracked = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
