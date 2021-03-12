using Domain.Ratio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Ratio.Ports.Incoming
{
    public interface IGetRatios
    {
        Task<IList<RatioEntity>> GetRatiosAsync(GetRatiosCommand getRatiosCommand);
    }
}
