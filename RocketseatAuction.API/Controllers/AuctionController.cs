using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.UsesCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction() 
        {

            var useCase = new GetCurrentAuctionUseCase();

            useCase.Execute();

            return Ok("Seila");
        }
    }
}
