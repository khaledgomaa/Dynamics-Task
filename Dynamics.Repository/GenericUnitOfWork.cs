using Dynamics.Domain;
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
        private GenericRepository<Invoice> invoiceRepository;
        private GenericRepository<InvoiceProducts> invoiceProductRepository;
        private GenericRepository<Product> productRepository;
        private GenericRepository<Store> storesRepository;
        public GenericUnitOfWork(DynamicsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public GenericRepository<Store> StoresRepository
        {
            get
            {
                if (this.storesRepository == null)
                    this.storesRepository = new GenericRepository<Store>(dbContext);
                return this.storesRepository;
            }
        }

        public GenericRepository<Product> ProductsRepository
        {
            get
            {
                if (this.productRepository == null)
                    this.productRepository = new GenericRepository<Product>(dbContext);
                return this.productRepository;
            }
        }

        public GenericRepository<Invoice> InvoiceRepository
        {
            get
            {
                if (this.invoiceRepository == null)
                    this.invoiceRepository = new GenericRepository<Invoice>(dbContext);
                return this.invoiceRepository;
            }
        }

        public GenericRepository<InvoiceProducts> InvoiceProductRepository
        {
            get
            {
                if (this.invoiceProductRepository == null)
                    this.invoiceProductRepository = new GenericRepository<InvoiceProducts>(dbContext);
                return this.invoiceProductRepository;
            }
        }

        public void Complete()
        {
            dbContext.SaveChanges();
        }

    }
}
