using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UsesCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction Execute()
        {
            var repository = new RocktseatAuctionDbContext();

            return repository.Auctions.First();
        }
    }
}
