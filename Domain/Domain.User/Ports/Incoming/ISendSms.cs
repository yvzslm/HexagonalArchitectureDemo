using Domain.Shared;
using Domain.User.Models;

namespace Domain.User.Ports.Incoming
{
    public interface ISendSms
    {
        Result SendSms(SendSms sendSms);
    }
}
