using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.HttpAggregator.Util;

namespace Web.HttpAggregator.Controllers
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

        
        [HttpGet, Route("GetRestaurants")]
        public async Task<IEnumerable<DropdownDto>> GetRestaurants()
        {
            var restaurants = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44369/Dropdown/GetRestaurants");
            var foods = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44369/Dropdown/GetFoods");
            restaurants.AddRange(foods);
            return restaurants;
        }
    }
}
