using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Interfaces
{
    interface IGuaranteeViewOpener
    {
        void OnGuaranteeViewClosed(Form guaranteeViewForm);
    }
}
