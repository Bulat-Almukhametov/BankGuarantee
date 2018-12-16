using BankGuarantee.Desktop.DbIntegration;
using BankGuarantee.Desktop.Models;
using BankGuarantee.Desktop.Properties;
using BankGuarantee.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BankGuarantee.Desktop.Controllers
{
    static class OrganizationController
    {
        static BankGuaranteeContext _bankGuaranteeContext;
        static OrganizationController()
        {
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        static internal GetOrganizationNamesResultDto GetOrganizationNames()
        {
            try
            {
                var organizations = _bankGuaranteeContext.Organizations
                    .Select(org => new { org.Id, org.Name })
                    .ToDictionary(org => org.Id, org => org.Name);

                return new GetOrganizationNamesResultDto(organizations);
            }
            catch (Exception ex)
            {
                return new GetOrganizationNamesResultDto(Resources.DatabaseError + ex.Message);
            }
        }
        static internal Organization GetOrganization(int id)
        {
            var organization = _bankGuaranteeContext.Organizations
                .Include(o => o.Founder)
                .Include(o => o.ChiefExecutive)
                .FirstOrDefault(o => o.Id == id);
            if (organization == null)
                throw new ArgumentException(Resources.WrongId);

            return organization;
        }
    }
}
