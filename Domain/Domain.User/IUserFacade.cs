using Domain.User.Ports.Incoming;

namespace Domain.User
{
    public interface IUserFacade : IAddUser, ISendMail, ISendSms
    {
    }
}
