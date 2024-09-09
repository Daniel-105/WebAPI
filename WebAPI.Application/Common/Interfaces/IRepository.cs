using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // T - Category Type
        IEnumerable<TEntity> GetAll(string? includeProperties = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter, string? includeProperties = null, bool tracked = false);
        TEntity Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
