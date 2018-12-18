using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Domain.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Ammount { get; set; }
    }
}
