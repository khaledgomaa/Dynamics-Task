using Dynamics.Domain;
using Dynamics.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dynamics.Service.Interfaces
{
    public interface IInvoiceManager : IRepository<Invoice>
    {
        void AddInvoice(Invoice invoice, IEnumerable<InvoiceProducts> invoiceProducts);
        IEnumerable<InvoiceProducts> GetInvoiceProducts(int id);

        void Complete();
    }
}
