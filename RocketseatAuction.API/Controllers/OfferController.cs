using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        public IActionResult CreateOffer()
        {
            return Created();
        }
    }
}
