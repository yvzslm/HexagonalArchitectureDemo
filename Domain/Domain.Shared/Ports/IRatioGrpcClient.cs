using Domain.Shared.Models;
using System.Threading.Tasks;

namespace Domain.Shared.Ports
{
    public interface IRatioGrpcClient
    {
        Task<GetRatiosResult> GetRatiosAsync(GetRatiosCommand getRatiosCommand);
    }
}
