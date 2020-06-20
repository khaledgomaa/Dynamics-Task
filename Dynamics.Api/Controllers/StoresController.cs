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
    public class StoresController : ControllerBase
    {
        private IStoreManager storeManager;

        public StoresController(IStoreManager storeManager)
        {
            this.storeManager = storeManager;
        }

        [HttpGet]
        public IActionResult GetStores()
        {
            return Ok(storeManager.GetAll());
        }
    }
}
