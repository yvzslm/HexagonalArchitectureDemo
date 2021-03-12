using Domain.MailOrder.Models;
using Domain.Shared;
using Domain.Shared.Models;
using System.Threading.Tasks;

namespace Domain.MailOrder.Ports.Outgoing
{
    public interface IMailOrderRepository : IRepository<MailOrderEntity>
    {
        Task<Result> UpdateAsync(MailOrderEntity mailOrderEntity);
    }
}
