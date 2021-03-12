using Domain.MailOrder.Models;
using Domain.MailOrder.Ports.Outgoing;
using Domain.MailOrder.ValueObjects;
using Domain.Shared.Models;
using Domain.Shared.Ports;
using System;
using System.Threading.Tasks;

namespace Domain.MailOrder
{
    public class MailOrderFacade : IMailOrderFacade
    {
        private IMailOrderRepository _mailOrderRepository;
        private INotification _notification;
        private IRatioGrpcClient _ratioGrpcClient;

        public MailOrderFacade(IMailOrderRepository mailOrderRepository, INotification notification, IRatioGrpcClient ratioGrpcClient)
        {
            _mailOrderRepository = mailOrderRepository;
            _notification = notification;
            _ratioGrpcClient = ratioGrpcClient;
        }

        public async Task<MailOrderEntity> CreateMailOrderAsync(CreateMailOrderCommand createMailOrdercommand)
        {
            var ratios = await _ratioGrpcClient.GetRatiosAsync(new GetRatiosCommand()
            {
                CompanyCode = createMailOrdercommand.CompanyCode,
                AgentId = createMailOrdercommand.AgentId,
                BankId = createMailOrdercommand.BankId,
                AddCommissionToAmount = true,
                Instalments = createMailOrdercommand.Instalments
            });

            if (ratios == null)
                throw new Exception("Ratio not found.");

            var endUser = new EndUser(createMailOrdercommand.EndUserName, createMailOrdercommand.EndUserSurname,
                                      createMailOrdercommand.EndUserMail, createMailOrdercommand.EndUserPhone);

            var mailOrderEntity = new MailOrderEntity(createMailOrdercommand.CompanyCode, createMailOrdercommand.AgentId, endUser);

            var entity = await _mailOrderRepository.AddAsync(mailOrderEntity);

            _notification.SendMail(new SendMailCommand(mailOrderEntity.EndUser.EndUserMail, "mail subject", "mail body"));
            _notification.SendSms(new SendSmsCommand(mailOrderEntity.EndUser.EndUserPhone, "sms message"));

            return entity;
        }
    }
}
