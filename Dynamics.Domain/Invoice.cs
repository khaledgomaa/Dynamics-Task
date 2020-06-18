using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dynamics.Domain
{
    public class Invoice : GenericClass
    {
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }

        public float Total { get; set; }

        public float Taxes { get; set; }

        public float Net { get; set; }
    }
}
