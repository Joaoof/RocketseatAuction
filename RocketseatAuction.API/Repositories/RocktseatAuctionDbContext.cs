using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories
{
    public class RocktseatAuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var teste = optionsBuilder.UseSqlite("Data Source=C:\\Users\\joaod\\Downloads\\leilaoDbNLW.db");
            Console.WriteLine(teste);
        }
    }
}
