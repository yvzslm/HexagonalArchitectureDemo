using Domain.Ratio;
using Domain.Ratio.Models;
using Grpc.Core;
using Mapster;
using System.Threading.Tasks;

namespace gRPC.Ratio
{
    public class RatioService : Ratio.RatioBase
    {
        private IRatioFacade _ratioFacade;

        public RatioService(IRatioFacade ratioFacade)
        {
            _ratioFacade = ratioFacade;
        }

        public override async Task<GetRatiosResponse> GetRatios(GetRatiosRequest request, ServerCallContext context)
        {
            var getRatiosCommand = request.Adapt<GetRatiosCommand>();
            var entity = await _ratioFacade.GetRatiosAsync(getRatiosCommand);

            return entity.Adapt<GetRatiosResponse>();
        }
    }
}
