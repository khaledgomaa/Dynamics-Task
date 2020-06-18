using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Domain.ViewModel
{
    public class InvoiceOrder
    {
        public Invoice Invoice { get; set; }

        public IEnumerable<InvoiceProducts> InvoiceProducts { get; set; }
    }
}
