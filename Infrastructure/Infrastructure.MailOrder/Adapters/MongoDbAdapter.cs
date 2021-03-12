using Domain.MailOrder.Models;
using Domain.MailOrder.Ports.Outgoing;
using Domain.Shared;
using System;
using System.Threading.Tasks;

namespace Infrastructure.MailOrder.Adapters
{
    public class MongoDbAdapter : IMailOrderRepository
    {
        public Task<MailOrderEntity> AddAsync(MailOrderEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result> UpdateAsync(MailOrderEntity mailOrderEntity)
        {
            throw new NotImplementedException();
        }
    }
}
