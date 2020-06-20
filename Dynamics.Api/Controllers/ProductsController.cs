using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dynamics.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dynamics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductManager productManager;

        public ProductsController(IProductManager productManager)
        {
            this.productManager = productManager;
        }

        
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(productManager.GetAll());
        }
    }
}
