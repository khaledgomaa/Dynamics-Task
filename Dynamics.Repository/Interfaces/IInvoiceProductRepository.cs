using Dynamics.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository.Interfaces
{
    public interface IInvoiceProductRepository : IRepository<InvoiceProducts>
    {
        void AddRange(IEnumerable<InvoiceProducts> invoiceProducts);
    }
}
