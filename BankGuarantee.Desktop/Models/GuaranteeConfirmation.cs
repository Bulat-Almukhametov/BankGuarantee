using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.Models
{
    class GuaranteeConfirmation
    {
        public int GuaranteeId { get; set; }
        public bool IsProtocolPublished { get; set; }
        public bool IsRiskTerritory { get; set; }
        public decimal ContractAmount { get; set; }
        public bool GuaranteeAmountLessThanContract { get; set; }
        public bool Confirmed { get; set; }
    }
}
