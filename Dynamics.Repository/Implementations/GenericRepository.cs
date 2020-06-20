using Dynamics.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            dbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entity)
        {
            dbContext.Set<TEntity>().AddRange(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>();
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
