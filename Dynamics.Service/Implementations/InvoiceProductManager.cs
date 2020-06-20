using Dynamics.Domain;
using Dynamics.Repository;
using Dynamics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dynamics.Service.Implementations
{
    public class InvoiceProductManager : IInvoiceProducts
    {

        private IUnitOfWork unitOfWork;

        public InvoiceProductManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(InvoiceProducts entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<InvoiceProducts> entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceProducts> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceProducts> GetAllInclude(Expression<Func<InvoiceProducts, object>> includes)
        {
            return unitOfWork.InvoiceProductRepository.GetAllInclude(includes);
        }

        public InvoiceProducts GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(InvoiceProducts entity)
        {
            throw new NotImplementedException();
        }
    }
}
