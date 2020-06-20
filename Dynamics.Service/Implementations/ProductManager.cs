using Dynamics.Domain;
using Dynamics.Repository;
using Dynamics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamics.Service.Implementations
{
    public class ProductManager : IProductManager
    {
        private IUnitOfWork unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add(Product entity)
        {
            unitOfWork.ProductsRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public void Complete()
        {
            unitOfWork.Complete();
        }

        public IEnumerable<Product> GetAll()
        {
            return unitOfWork.ProductsRepository.GetAll().Where(p=>p.Amount > 0).ToList();
        }

        public IEnumerable<Product> GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
