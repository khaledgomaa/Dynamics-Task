using Dynamics.Domain;
using Dynamics.Repository;
using Dynamics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Add(Invoice entity)
        {
            iUnitOfWork.InvoiceRepository.Add(entity);           
        }

        public IEnumerable<Invoice> GetAll()
        {
            return iUnitOfWork.InvoiceRepository.GetAll().ToList();
        }

        public Invoice GetById(int id)
        {
            return iUnitOfWork.InvoiceRepository.GetById(id);
        }

        public void Remove(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public void Complete()
        {
            iUnitOfWork.Complete();
        }

        public void AddInvoice(Invoice invoice, IEnumerable<InvoiceProducts> invoiceProducts)
        {
            iUnitOfWork.InvoiceRepository.Add(invoice);
            iUnitOfWork.InvoiceProductRepository.AddRange(invoiceProducts);
        }

        public void AddRange(IEnumerable<Invoice> entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceProducts> GetInvoiceProducts(int id)
        {
            return iUnitOfWork.InvoiceProductRepository.GetAll().Where(i=>i.InvoiceId == id);
        }

        public IEnumerable<Invoice> GetAllInclude(Expression<Func<Invoice, object>> includes)
        {
            throw new NotImplementedException();
        }
    }
}
