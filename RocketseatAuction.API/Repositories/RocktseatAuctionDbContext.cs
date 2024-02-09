using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories
{
    public class RocktseatAuctionDbContext : DbContext
    {
        public RocktseatAuctionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Auction> Auctions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Offer> Offers { get; set; }
    }
}
