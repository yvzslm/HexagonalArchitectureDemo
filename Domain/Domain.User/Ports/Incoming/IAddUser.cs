using Domain.User.Models;

namespace Domain.User.Ports.Incoming
{
    public interface IAddUser
    {
        UserEntity AddUser(AddUser addUser);
    }
}
