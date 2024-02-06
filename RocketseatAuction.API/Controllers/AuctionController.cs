using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction()
        {
            return Ok("Seila");
        }
    }
}
