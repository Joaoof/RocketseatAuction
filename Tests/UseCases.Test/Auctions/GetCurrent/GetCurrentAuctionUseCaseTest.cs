using RocketseatAuction.API.UsesCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCaseTest
    {
        [Fact]
        public void Sucess()
        {
            // ARRANGE 
            var useCase = new GetCurrentAuctionUseCase(null);

            // ACT
            var auction = useCase.Execute();

            //ASSERT
            Assert.NotNull(auction);
        }
    }
}
