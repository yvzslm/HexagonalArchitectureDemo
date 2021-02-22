using Domain.Shared;
using Domain.User.Ports.Outgoing;

namespace Test.User.Adapters
{
    public class FakeUserNotification : IUserNotification
    {
        public Result SendMail(string emailTo, string subject, string body)
        {
            return new Result() { ResultCode = ResultCode.Successful, Message = $"Mail was succesfully sended to {emailTo}" };
        }

        public Result SendSms(string gsmNo, string message)
        {
            return new Result() { ResultCode = ResultCode.Successful, Message = $"Sms was succesfully sended to {gsmNo}" };
        }
    }
}
