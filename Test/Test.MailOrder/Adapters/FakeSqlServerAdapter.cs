using Domain.MailOrder.Models;
using Domain.MailOrder.Ports.Outgoing;
using Domain.Shared;
using System;
using System.Threading.Tasks;

namespace Test.MailOrder.Adapters
{
    public class FakeSqlServerAdapter : IMailOrderRepository
    {
        public Task<MailOrderEntity> AddAsync(MailOrderEntity entity)
        {
            return Task.FromResult(new MailOrderEntity(Guid.NewGuid(), entity.CompanyCode, entity.AgentId, entity.EndUser).WithAddCommissionToAmount(entity.AddCommissionToAmount));
        }

        public Task<Result> UpdateAsync(MailOrderEntity mailOrderEntity)
        {
            return Task.FromResult(new Result() { Message = "İşlem başarılı.", ResultCode = ResultCode.Successful });
        }
    }
}
