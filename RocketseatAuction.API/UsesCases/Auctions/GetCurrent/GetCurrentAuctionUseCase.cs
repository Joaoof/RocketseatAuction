using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UsesCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCase(IAuctionRepository repository)
        {
            _repository = repository;
        }

        public Auction? Execute()
        {
            return _repository.GetCurrent();
        }
    }
}// É quem nos ajuda a pegar informações sobre o leilão atual.
