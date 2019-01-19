using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace PortfolioRebalancer.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        [HttpGet]
        [Route("")]
        [ProducesResponseType(200)]
        public IActionResult SortIterative([FromQuery] List<PortfolioPolicy> portfolioPolicy)
        {
            return Ok(portfolioPolicy);
        }
    }
}