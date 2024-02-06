﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UsesCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? Execute()
        {
            var repository = new RocktseatAuctionDbContext();

            var today = DateTime.Now;

            return repository.Auctions.Include(auction => auction.Items).FirstOrDefault();
        }
    }
}
