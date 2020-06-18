using Dynamics.Repository.Implementations;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository
{
    public class GenericUnitOfWork : IUnitOfWork
    {
        private DynamicsDbContext dbContext;
        private InvoiceRepository invoiceRepository;
        private InvoiceProductRepository invoiceProductRepository;
        public GenericUnitOfWork(DynamicsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public InvoiceRepository InvoiceRepository
        {
            get
            {
                if (this.invoiceRepository == null)
                    this.invoiceRepository = new InvoiceRepository(dbContext);
                return this.invoiceRepository;
            }
        }

        public IInvoiceProductRepository InvoiceProductRepository
        {
            get
            {
                if (this.invoiceProductRepository == null)
                    this.invoiceProductRepository = new InvoiceProductRepository(dbContext);
                return this.invoiceProductRepository;
            }
        }

        public void Complete()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
