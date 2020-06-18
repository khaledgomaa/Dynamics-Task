using Dynamics.Domain;
using Dynamics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Service.Interfaces
{
    public interface IInvoiceManager : IInvoiceRepository
    {
        void AddInvoice(Invoice invoice , IEnumerable<InvoiceProducts> invoiceProducts);
    }
}
