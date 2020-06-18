using Dynamics.Domain;
using Dynamics.Repository;
using Dynamics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Service.Implementations
{
    public class InvoiceManager : IInvoiceManager
    {

        private IUnitOfWork iUnitOfWork;

        public InvoiceManager(IUnitOfWork iUnitOfWork)
        {
            this.iUnitOfWork = iUnitOfWork;
        }

        public void AddInvoice(Invoice invoice, IEnumerable<InvoiceProducts> invoiceProducts)
        {
            //add invoice and products;
            iUnitOfWork.InvoiceRepository.Add(invoice);
            iUnitOfWork.InvoiceProductRepository.AddRange(invoiceProducts);
        }
        public void Add(Invoice entity)
        {
            throw new NotImplementedException();
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
