using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dynamics.Domain;
using Dynamics.Domain.ViewModel;
using Dynamics.Service.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Dynamics.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private InvoiceManager invoiceManager;

        public TestsController(InvoiceManager invoiceManager)
        {
            this.invoiceManager = invoiceManager;
        }

        [HttpPost]
        public IActionResult CreateInvoice(InvoiceOrder invoiceOrder)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            //InvoiceId in InvoiceProducts table points to Id in invoice Table
            foreach(InvoiceProducts item in invoiceOrder.InvoiceProducts)
            {
                item.Invoice = invoiceOrder.Invoice;
            }

            invoiceManager.AddInvoice(invoiceOrder.Invoice, invoiceOrder.InvoiceProducts);

            return Ok();
        }
    }
}
