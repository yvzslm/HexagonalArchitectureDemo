using Domain.Ratio.Models;
using Domain.Ratio.Ports.Outgoing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Ratio
{
    public class RatioFacade : IRatioFacade
    {
        private IRatioRepository _ratioRepository;

        public RatioFacade(IRatioRepository ratioRepository)
        {
            _ratioRepository = ratioRepository;
        }

        public async Task<IList<RatioEntity>> GetRatiosAsync(GetRatiosCommand getRatiosCommand)
        {
            return await _ratioRepository.GetRatiosAsync(getRatiosCommand);
        }
    }
}
