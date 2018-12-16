using BankGuarantee.Desktop.DbIntegration;
using BankGuarantee.Desktop.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BankGuarantee.Desktop.Interfaces;

namespace BankGuarantee.Desktop.Controllers
{
    internal static class GuaranteeController
    {
        static BankGuaranteeContext _bankGuaranteeContext;
        static IGuaranteeViewOpener _guaranteeFormOpener;

        static GuaranteeController()
        {
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        internal static Form ViewGuaranteeItem(int guaranteeId, IGuaranteeViewOpener guaranteeFormOpener)
        {
            _guaranteeFormOpener = guaranteeFormOpener;

            var guarantee =_bankGuaranteeContext.Guarantees
                .Include(g => g.Organization)
                .Include(g => g.Organization.Founder)
                .Include(g => g.Organization.ChiefExecutive)
                .First(g => g.Id == guaranteeId);

            return new GuaranteeViewForm(guarantee);
        } 

        internal static void ViewGuaranteeItemClosed(Form guaranteeViewForm)
        {
            _guaranteeFormOpener.OnGuaranteeViewClosed(guaranteeViewForm);
        }
    }
}
