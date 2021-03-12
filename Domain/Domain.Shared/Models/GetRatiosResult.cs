using System.Collections.Generic;

namespace Domain.Shared.Models
{
    public class GetRatiosResult
    {
        public int ID { get; set; }
        public IList<string> Banks { get; set; }
        public IDictionary<string, IList<int>> Instalments { get; set; }
    }
}
