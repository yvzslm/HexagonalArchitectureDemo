using Domain.User;
using Domain.User.Ports.Outgoing;

namespace Test.User.Adapters
{
    public class FakeUserRepository : IUserRepository
    {
        public UserEntity Add(UserEntity user)
        {
            return new UserEntity(1, user.FirstName, user.LastName, user.Email, user.GsmNo);
        }
    }
}
