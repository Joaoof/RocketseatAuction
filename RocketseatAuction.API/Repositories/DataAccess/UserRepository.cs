using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly RocktseatAuctionDbContext _dbContext;

        public UserRepository(RocktseatAuctionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ExistUserWithEmail(string email)
        {
            return _dbContext.Users.Any(user => user.Email.Equals(email)); // Verificando se existir o email do token
        }

        public User GetUserByEmail(string email)
        {
            return _dbContext.Users.First(user => user.Email.Equals(email));
        }
    }
}
