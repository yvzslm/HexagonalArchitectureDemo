using Domain.Shared;
using Domain.User.Models;

namespace Domain.User.Ports.Incoming
{
    public interface ISendMail
    {
        Result SendMail(SendMail sendMail);
    }
}
