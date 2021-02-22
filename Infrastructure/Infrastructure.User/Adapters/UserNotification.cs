using Domain.Shared;
using Domain.User.Ports.Outgoing;
using System.Net.Mail;

namespace Infrastructure.User
{
    public class UserNotification : IUserNotification
    {
        public Result SendMail(string emailTo, string subject, string body)
        {
            string host = "mail.com.tr";
            int port = 25;

            var smtpClient = new SmtpClient(host, port);
            var mailMessage = new MailMessage("from@mail.com.tr", emailTo, subject, body);
            smtpClient.Send(mailMessage);

            return new Result() { ResultCode = ResultCode.Successful, Message = $"Mail was succesfully sent to {emailTo}" };
        }

        public Result SendSms(string gsmNo, string message)
        {
            return new Result() { ResultCode = ResultCode.Successful, Message = $"Sms was succesfully sended to {gsmNo}" };
        }
    }
}
