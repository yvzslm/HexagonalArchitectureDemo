using Domain.Shared.Models;

namespace Domain.User.Ports.Outgoing
{
    public interface IUserRepository : IRepository<UserEntity>
    {
    }
}
