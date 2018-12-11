using System;
using System.Collections.Generic;
using System.Text;

namespace BankGuarantee.Domain.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public Person ChiefExecutive  { get; set; }
        public int ChiefExecutiveId { get; set; }
        public Person Founder { get; set; }
        public int FounderId { get; set; }
        public string Address { get; set; }
        public int FoundedYear { get; set; }
    }
}
