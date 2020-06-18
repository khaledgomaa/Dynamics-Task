using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dynamics.Domain
{
    public class InvoiceProducts : GenericClass
    {
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Qty { get; set; }

        public float Price { get; set; }

        public decimal? Discount { get; set; }
    }
}
