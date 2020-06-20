using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dynamics.Repository.Interfaces
{
    public interface IRepository<TEntity>  where TEntity : class
    {
        void AddRange(IEnumerable<TEntity> entity);
        void Add(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Remove(TEntity entity);

        IEnumerable<TEntity> GetAllInclude(Expression<Func<TEntity, object>> includes);

    }
}
