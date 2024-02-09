using FluentAssertions;
using Moq;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.UsesCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCaseTest
    {
        [Fact]
        public void Sucess()
        {
            var mock = new Mock<IAuctionRepository>();
            mock.Setup(i => i.GetCurrent()).Returns(new RocketseatAuction.API.Entities.Auction());
            // ARRANGE 
            var useCase = new GetCurrentAuctionUseCase(mock.Object);

            // ACT
            var auction = useCase.Execute();

            //ASSERT
            auction.Should().NotBeNull();
        }
    }
}
