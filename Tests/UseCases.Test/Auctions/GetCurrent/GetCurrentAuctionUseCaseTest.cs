using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Enums;
using RocketseatAuction.API.UsesCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCaseTest
    {
        [Fact]
        public void Sucess()
        {

            var entity = new Faker<Auction>().RuleFor(auction => auction.Id, faker => faker.Random.Number(1, 10))
                .RuleFor(auction => auction.Name, faker => faker.Lorem.Word())
                .RuleFor(auction => auction.Starts, faker => faker.Date.Past())
                .RuleFor(auction => auction.Ends, faker => faker.Date.Future())
                .RuleFor(auction => auction.Items, (faker, auction) => new List<Item>
                {
                    new Item
                    {
                        Id = faker.Random.Number(1, 10),
                        Name = faker.Commerce.ProductName(),
                        Brand = faker.Commerce.Department(),
                        BasePrice = faker.Random.Decimal(50, 1000),
                        Condition = faker.PickRandom<Condition>(),
                        AuctionId = auction.Id
                    }
                }).Generate();

            var mock = new Mock<IAuctionRepository>();
            mock.Setup(i => i.GetCurrent()).Returns(entity);
            // ARRANGE 
            var useCase = new GetCurrentAuctionUseCase(mock.Object);

            // ACT
            var auction = useCase.Execute();

            //ASSERT
            auction.Should().NotBeNull();
            auction.Id.Should().Be(entity.Id);
            auction.Name.Should().Be(entity.Name);
        }
    }
}
