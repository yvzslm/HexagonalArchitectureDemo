using Domain.User;
using Domain.User.Ports.Outgoing;
using System.Threading.Tasks;

namespace Test.User.Adapters
{
    public class FakeSqlServerAdapter : IUserRepository
    {
        public async Task<UserEntity> AddAsync(UserEntity entity)
        {
            return await Task.FromResult(new UserEntity(1, entity.FirstName, entity.LastName, entity.Email, entity.GsmNo));
        }
    }
}
