using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Comunication.Request;
using RocketseatAuction.API.Filters;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AuthenticationUserAttribute))] // criando autorização para esse endpoint 
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
