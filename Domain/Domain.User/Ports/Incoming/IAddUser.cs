using Domain.User.Models;
using System.Threading.Tasks;

namespace Domain.User.Ports.Incoming
{
    public interface IAddUser
    {
        Task<UserEntity> AddUserAsync(AddUserCommand addUser);
    }
}
