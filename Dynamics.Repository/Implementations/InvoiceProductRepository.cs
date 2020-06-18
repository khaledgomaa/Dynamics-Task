using Dynamics.Domain;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository.Implementations
{
    public class InvoiceProductRepository : IInvoiceProductRepository
    {
        private DynamicsDbContext dbContext;

        public InvoiceProductRepository(DynamicsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(InvoiceProducts entity)
        {
            //create procedure to add;
        }

        public void AddRange(IEnumerable<InvoiceProducts> invoiceProducts)
        {
            dbContext.AddRange(invoiceProducts);
        }

        public IEnumerable<InvoiceProducts> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceProducts> GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(InvoiceProducts entity)
        {
            throw new NotImplementedException();
        }
    }
}
