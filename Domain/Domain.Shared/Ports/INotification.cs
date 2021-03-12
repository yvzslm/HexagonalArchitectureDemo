using Domain.Shared.Models;

namespace Domain.Shared.Ports
{
    public interface INotification
    {
        Result SendMail(SendMailCommand sendMailCommand);
        Result SendSms(SendSmsCommand sendSmsCommand);
    }
}
