using Dynamics.Domain;
using Dynamics.Repository.Implementations;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository
{
    public interface IUnitOfWork 
    {
        GenericRepository<Product> ProductsRepository { get; }

        GenericRepository<Store> StoresRepository { get; }
        GenericRepository<Invoice> InvoiceRepository { get; }

        GenericRepository<InvoiceProducts> InvoiceProductRepository { get; }
        void Complete();
    }
}
