using Domain.MailOrder.ValueObjects;
using Domain.Shared.Models;
using System;
using System.Collections.Generic;

namespace Domain.MailOrder.Models
{
    public class MailOrderEntity : EntityBase
    {
        public Guid ID { get; private set; }
        public string CompanyCode { get; private set; }
        public string AgentId { get; private set; }
        public EndUser EndUser { get; private set; }
        public string BankId { get; set; }
        public bool AddCommissionToAmount { get; private set; }
        public IList<int> Instalments { get; private set; }

        public MailOrderEntity(Guid id, string companyCode, string agentId, EndUser endUser)
        {
            ID = id;
            CompanyCode = companyCode;
            AgentId = agentId;
            EndUser = endUser;
        }

        public MailOrderEntity(string companyCode, string agentId, EndUser endUser)
        {
            CompanyCode = companyCode;
            AgentId = agentId;
            EndUser = endUser;
        }

        public MailOrderEntity WithBankId(string bankId)
        {
            BankId = bankId;
            return this;
        }

        public MailOrderEntity WithAddCommissionToAmount(bool addCommissionToAmount)
        {
            AddCommissionToAmount = addCommissionToAmount;
            return this;
        }

        public MailOrderEntity WithInstalments(IList<int> instalments)
        {
            Instalments = instalments;
            return this;
        }
    }
}
