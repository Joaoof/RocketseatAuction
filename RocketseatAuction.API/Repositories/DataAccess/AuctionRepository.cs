using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAcess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly RocktseatAuctionDbContext _dbContext;

        public AuctionRepository(RocktseatAuctionDbContext dbContext)
        {
             _dbContext = dbContext;
        }

        public Auction GetCurrent()
        {
            var today = DateTime.Now;

            return _dbContext.Auctions.Include(auction => auction.Items).FirstOrDefault();
        }
    }
} // Todas as informações sobre o leilão atual são guardadas aqui.
