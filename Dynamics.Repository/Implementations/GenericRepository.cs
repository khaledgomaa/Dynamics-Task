using Dynamics.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository.Implementations
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DynamicsDbContext dbContext;

        public GenericRepository(DynamicsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            dbContext.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Deleted;
        }
    }
}
