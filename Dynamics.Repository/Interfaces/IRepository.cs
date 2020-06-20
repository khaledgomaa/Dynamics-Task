using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository.Interfaces
{
    public interface IRepository<TEntity>  where TEntity : class
    {
        void AddRange(IEnumerable<TEntity> entity);
        void Add(TEntity entity);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetById();

        void Remove(TEntity entity);
    }
}
