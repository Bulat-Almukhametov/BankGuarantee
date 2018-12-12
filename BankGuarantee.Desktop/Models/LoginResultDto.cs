using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Models
{
    class LoginResultDto
    {
        public bool Success { get; set; }
        public Form NextForm { get; set; }
        public string ErrorText { get; set; }
    }
}
