using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Comunication.Request;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UsesCases.Offers.CreateOffer;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AuthenticationUserAttribute))] // criando autorização para esse endpoint 
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        [Route("{itemId}")]

        public IActionResult CreateOffer([FromRoute] int itemId, 
        [FromBody] RequestCreateOfferJson request, 
        [FromServices] CreateOfferUseCase useCase)
        {
            var id = useCase.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}
