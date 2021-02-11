using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CakeAPI.Services;
using CakeEntities.Entities;
using System.Collections.Generic;

namespace CakeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CakeController : ControllerBase
    {
        private readonly ILogger<CakeController> _logger;

        public CakeController(ILogger<CakeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get foods
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetFoods")]
        public IEnumerable<Cake> Get()
        {
            return new CakeServices().GetCake();
        }
    }
}
