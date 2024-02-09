using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuction.API.Comunication.Request;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Enums;
using RocketseatAuction.API.Services;
using RocketseatAuction.API.UsesCases.Auctions.GetCurrent;
using RocketseatAuction.API.UsesCases.Offers.CreateOffer;
using Xunit;

namespace UseCases.Test.Offers.CreateOffer;

public class CreateOffUseCaseTest
{
    [Theory] // testar diversa vezes -> InlineData
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Sucess(int itemId)
    {

        var request = new Faker<RequestCreateOfferJson>().RuleFor(request => request.Price, faker => faker
        .Random.Decimal(1, 10)).Generate();
   

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());
        // ARRANGE 
        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        // ACT
        var act = () => useCase.Execute(0, request);

        //ASSERT
        act.Should().NotThrow(); // não deve lançar uma exceção
    }
}
