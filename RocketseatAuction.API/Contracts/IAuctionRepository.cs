using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts
{
    public interface IAuctionRepository
    {
        Auction? GetCurrent();
    }
} // É como uma lista de instruções para encontrar informações sobre o leilão atual.
