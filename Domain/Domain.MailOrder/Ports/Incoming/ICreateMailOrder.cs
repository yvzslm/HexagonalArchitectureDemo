using Domain.MailOrder.Models;
using System.Threading.Tasks;

namespace Domain.MailOrder.Ports.Incoming
{
    public interface ICreateMailOrder
    {
        Task<MailOrderEntity> CreateMailOrderAsync(CreateMailOrderCommand createMailOrderCommand);
    }
}
