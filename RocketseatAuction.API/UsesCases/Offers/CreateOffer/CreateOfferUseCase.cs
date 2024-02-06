using RocketseatAuction.API.Comunication.Request;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.UsesCases.Offers.CreateOffer
{
    public class CreateOfferUseCase
    {
        private readonly LoggedUser _loggedUser;

        public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;
        public void Execute(int itemId, RequestCreateOfferJson request)
        {
            var repository = new RocktseatAuctionDbContext();

            var user = _loggedUser.User();

            var offer = new Offer
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = user.Id,

            };

            repository.Offers.Add(offer);

            repository.SaveChanges();
        }
    }
}
