using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CakeAPI.Services;
using CakeEntities.Entities;
using System.Collections.Generic;

namespace CakeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get restaurants
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetRestaurants")]
        public IEnumerable<Customer> Get()
        {
            return new CustomerServices().GetRestaurants();
        }

        
    }
}
