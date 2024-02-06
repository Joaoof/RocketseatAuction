using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.UsesCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)] // Indicar para o swagger o que ele deve retornar!
        [ProducesResponseType(StatusCodes.Status204NoContent)] // Caso o resultado no swagger seja null
        public IActionResult GetCurrentAuction() 
        {

            var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();

            if (result is null)
            { 
                return NoContent();
            }

            return Ok(result);
        }
    }
}
