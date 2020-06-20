using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dynamics.Domain;
using Dynamics.Domain.ViewModel;
using Dynamics.Repository;
using Dynamics.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dynamics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private IInvoiceManager invoiceManager;
        private IProductManager productManager;

        public InvoicesController(IInvoiceManager invoiceManager , IProductManager productManager)
        {
            this.invoiceManager = invoiceManager;
            this.productManager = productManager;
        }

        [HttpPost]
        public IActionResult CreateInvoice(InvoiceOrder invoiceOrder)
        {
            if (!ModelState.IsValid || invoiceOrder.InvoiceProducts.Count() ==0)
                return BadRequest();

            foreach(InvoiceProducts product in invoiceOrder.InvoiceProducts)
            {
                product.Invoice = invoiceOrder.Invoice;
            }

            invoiceOrder.Invoice.Date = DateTime.UtcNow;

            UpdateProductsAmount(invoiceOrder.InvoiceProducts);

            invoiceManager.AddInvoice(invoiceOrder.Invoice, invoiceOrder.InvoiceProducts);

            invoiceManager.Complete();

            return Ok();
        }

        private void UpdateProductsAmount(IEnumerable<InvoiceProducts> invoiceProducts)
        {
            IEnumerable<Product> productsInDb = productManager.GetAll();


            foreach(InvoiceProducts invoiceproduct in invoiceProducts)
            {
                if(productsInDb.Where(p => p.Id == invoiceproduct.ProductId)
                            .FirstOrDefault().Amount >= invoiceproduct.Qty)
                {
                    productsInDb.Where(p => p.Id == invoiceproduct.ProductId)
                            .FirstOrDefault().Amount -= invoiceproduct.Qty;
                }
                
            }
        }
    }
}
