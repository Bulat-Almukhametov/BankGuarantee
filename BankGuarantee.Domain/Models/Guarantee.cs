using System;
using System.Collections.Generic;
using System.Text;

namespace BankGuarantee.Domain.Models
{
    public class Guarantee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Organization Organization { get; set; }
        public int OrganizationId { get; set; }
        public decimal Amount { get; set; }
        public int Days { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsProtocolPublished { get; set; }
        public bool IsRiskTerritory { get; set; }
        public decimal ContractAmount { get; set; }
        public bool GuaranteeAmountLessThanContract { get; set; }
        public bool? Confirmed { get; set; }
    }
}
