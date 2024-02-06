using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Comunication.Request;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreateOfferJson request)
        {
            return Created();
        }
    }
}
