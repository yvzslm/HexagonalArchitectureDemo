using Domain.Shared;

namespace Domain.User.Ports.Outgoing
{
    public interface IUserNotification
    {
        Result SendMail(string emailTo, string subject, string body);
        Result SendSms(string gsmNo, string message);
    }
}
