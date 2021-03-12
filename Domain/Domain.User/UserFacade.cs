using Domain.User.Models;
using Domain.User.Ports.Outgoing;
using System.Threading.Tasks;

namespace Domain.User
{
    public class UserFacade : IUserFacade
    {
        private IUserRepository _userRepository;

        public UserFacade(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserEntity> AddUserAsync(AddUserCommand addUser)
        {
            var user = new UserEntity(addUser.FirstName, addUser.LastName, addUser.Email, addUser.GsmNo);
            return await _userRepository.AddAsync(user);
        }
    }
}
