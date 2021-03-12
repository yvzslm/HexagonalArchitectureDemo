using Domain.Ratio.Models;
using Domain.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Ratio.Ports.Outgoing
{
    public interface IRatioRepository : IRepository<RatioEntity>
    {
        Task<IList<RatioEntity>> GetRatiosAsync(Models.GetRatiosCommand getRatiosCommand);
    }
}
