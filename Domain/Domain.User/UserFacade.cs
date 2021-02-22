using Domain.Shared;
using Domain.User.Models;
using Domain.User.Ports.Outgoing;

namespace Domain.User
{
    public class UserFacade : IUserFacade
    {
        private IUserRepository _userRepository;
        private IUserNotification _userNotification;

        public UserFacade(IUserRepository userRepository, IUserNotification userNotification)
        {
            _userRepository = userRepository;
            _userNotification = userNotification;
        }

        public UserEntity AddUser(AddUser addUser)
        {
            var user = new UserEntity(addUser.FirstName, addUser.LastName, addUser.Email, addUser.GsmNo);
            return _userRepository.Add(user);
        }

        public Result SendMail(SendMail sendMail)
        {
            return _userNotification.SendMail(sendMail.EmailTo, sendMail.Subject, sendMail.Body);
        }

        public Result SendSms(SendSms sendSms)
        {
            return _userNotification.SendSms(sendSms.GsmNo, sendSms.Message);
        }
    }
}
