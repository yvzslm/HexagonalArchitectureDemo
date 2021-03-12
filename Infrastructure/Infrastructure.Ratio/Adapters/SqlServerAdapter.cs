using Domain.Ratio.Models;
using Domain.Ratio.Ports.Outgoing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Ratio
{
    public class SqlServerAdapter : IRatioRepository
    {
        public Task<RatioEntity> AddAsync(RatioEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<RatioEntity>> GetRatiosAsync(GetRatiosCommand getRatiosCommand)
        {
            throw new NotImplementedException();
        }
    }
}
