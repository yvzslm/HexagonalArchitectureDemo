namespace Domain.Ratio.Models
{
    public class GetRatiosCommand
    {
        public string CompanyCode { get; set; }
        public string AgentId { get; set; }
        public string BankId { get; set; }
        public bool AddCommissionToAmount { get; set; }
        public int Instalment { get; set; }
    }
}
