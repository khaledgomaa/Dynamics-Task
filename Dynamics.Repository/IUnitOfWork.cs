using Dynamics.Repository.Implementations;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        InvoiceRepository InvoiceRepository { get; }

        IInvoiceProductRepository InvoiceProductRepository { get; }
        void Complete();
    }
}
