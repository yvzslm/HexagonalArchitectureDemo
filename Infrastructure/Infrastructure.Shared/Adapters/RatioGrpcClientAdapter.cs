using Domain.Shared.Models;
using Domain.Shared.Ports;
using gRPC.Ratio;
using Grpc.Net.Client;
using Mapster;
using System.Threading.Tasks;
using static gRPC.Ratio.Ratio;

namespace Infrastructure.MailOrder.Adapters
{
    public class RatioGrpcClientAdapter : IRatioGrpcClient
    {
        private RatioClient _client;

        public RatioGrpcClientAdapter()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            _client = new RatioClient(channel);
        }

        public async Task<GetRatiosResult> GetRatiosAsync(GetRatiosCommand getRatiosCommand)
        {
            var request = getRatiosCommand.Adapt<GetRatiosRequest>();
            var response = await _client.GetRatiosAsync(request);
            
            return response.Adapt<GetRatiosResult>();
        }
    }
}
