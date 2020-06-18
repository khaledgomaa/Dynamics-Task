using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dynamics.Domain
{
    public class Store : GenericClass
    {
        [Required]
        public string Name { get; set; }
    }
}
