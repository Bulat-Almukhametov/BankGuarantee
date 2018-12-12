using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Domain.Models
{
    public class Credential
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public string Login { get; set; }
        public string PasswordEncrypt { get; set; }
    }
}
