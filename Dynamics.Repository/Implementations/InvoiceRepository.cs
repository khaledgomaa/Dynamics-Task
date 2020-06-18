using Dynamics.Domain;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository.Implementations
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private DynamicsDbContext dbContext;

        public InvoiceRepository(DynamicsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Invoice entity)
        {
            //create a procedure to add inside this table
        }

        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetById()
        {
            throw new NotImplementedException();
        }

        public void Remove(Invoice entity)
        {
            throw new NotImplementedException();
        }
    }
}
