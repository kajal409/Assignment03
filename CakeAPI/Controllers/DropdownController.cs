﻿using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CakeAPI.Services;
using System.Collections.Generic;
using System.Linq;

namespace CakeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropdownController : ControllerBase
    {
        private readonly ILogger<DropdownController> _logger;

        public DropdownController(ILogger<DropdownController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get foods
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetFoods")]
        public IEnumerable<DropdownDto> GetFoods()
        {
            return new CakeServices().GetCake().Select(r => new DropdownDto { Id = r.Id, Name = r.Name });
        }

        /// <summary>
        ///  Get restaurants
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetRestaurants")]
        public IEnumerable<DropdownDto> GetRestaurants()
        {
            return new CustomerServices().GetRestaurants().Select(r => new DropdownDto { Id = r.Id, Name = r.Name });
        }
    }
}
