using Domain.Shared;
using Domain.Shared.Models;
using Domain.Shared.Ports;
using System;

namespace Infrastructure.Shared.Adapters
{
    public class NotificationAdapter : INotification
    {
        public Result SendMail(SendMailCommand sendMailCommand)
        {
            throw new NotImplementedException();
        }

        public Result SendSms(SendSmsCommand sendSmsCommand)
        {
            throw new NotImplementedException();
        }
    }
}
