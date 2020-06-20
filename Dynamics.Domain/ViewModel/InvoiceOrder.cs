using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dynamics.Domain.ViewModel
{
    public class InvoiceOrder
    {
        [Required]
        public Invoice Invoice { get; set; }

        [Required]
        public IEnumerable<InvoiceProducts> InvoiceProducts { get; set; }
    }
}
