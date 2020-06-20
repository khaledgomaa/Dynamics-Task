using Dynamics.Domain;
using Dynamics.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Service.Interfaces
{
    public interface IInvoiceManager : IRepository<Invoice>
    {
        void AddInvoice(Invoice invoice, IEnumerable<InvoiceProducts> invoiceProducts);

        void Complete();
    }
}
