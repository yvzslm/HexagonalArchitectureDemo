using Domain.Shared.Models;
using System.Collections.Generic;

namespace Domain.Ratio.Models
{
    public class RatioEntity : EntityBase
    {
        public int ID { get; private set; }
        public IList<string> Banks { get; private set; }
        public IDictionary<string, IList<int>> Instalments { get; private set; }
    }
}
