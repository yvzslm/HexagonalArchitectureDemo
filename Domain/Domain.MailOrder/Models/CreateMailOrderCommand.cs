using System.Collections.Generic;

namespace Domain.MailOrder.Models
{
    public class CreateMailOrderCommand
    {
        public string CompanyCode { get; private set; }
        public string AgentId { get; private set; }
        public string EndUserName { get; private set; }
        public string EndUserSurname { get; private set; }
        public string EndUserMail { get; private set; }
        public string EndUserPhone { get; private set; }
        public string BankId { get; set; }
        public bool AddCommissionToAmount { get; private set; }
        public IList<int> Instalments { get; private set; }

        public CreateMailOrderCommand(string companyCode, string agentId, string endUserName, string endUserSurname, string endUserMail)
        {
            CompanyCode = companyCode;
            AgentId = agentId;
            EndUserName = endUserName;
            EndUserSurname = endUserSurname;
            EndUserMail = endUserMail;
        }

        public CreateMailOrderCommand WithEndUserPhone(string endUserPhone)
        {
            EndUserPhone = endUserPhone;
            return this;
        }

        public CreateMailOrderCommand WithBankId(string bankId)
        {
            BankId = bankId;
            return this;
        }

        public CreateMailOrderCommand WithAddCommissionToAmount(bool addCommissionToAmount)
        {
            AddCommissionToAmount = addCommissionToAmount;
            return this;
        }

        public CreateMailOrderCommand WithInstalments(IList<int> instalments)
        {
            Instalments = instalments;
            return this;
        }
    }
}
