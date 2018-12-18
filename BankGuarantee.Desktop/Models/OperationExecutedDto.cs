using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.Models
{
    class OperationExecutedDto
    {
        internal static OperationExecutedDto Success
        {
            get
            {
                return new OperationExecutedDto { Executed = true };
            }
        }
        private OperationExecutedDto() { }

        internal OperationExecutedDto(string errorText)
        {
            ErrorText = errorText;
        }
        public bool Executed { get; private set; }
        public string ErrorText { get; }
    }
}
