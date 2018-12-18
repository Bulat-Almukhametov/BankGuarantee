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
using BankGuarantee.Desktop.Interfaces;
using System.Windows.Forms;
using BankGuarantee.Desktop.Forms;

namespace BankGuarantee.Desktop.Controllers
{
    static class OrganizationController
    {
        static BankGuaranteeContext _bankGuaranteeContext;
        static IOrganizationCreator _organizationCreator;
        static OrganizationController()
        {
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        static internal EntitiesDisplayValuesResultDto GetOrganizationNames()
        {
            try
            {
                var organizations = _bankGuaranteeContext.Organizations
                    .Select(org => new { org.Id, org.Name })
                    .ToDictionary(org => org.Id, org => org.Name);

                return new EntitiesDisplayValuesResultDto(organizations);
            }
            catch (Exception ex)
            {
                return new EntitiesDisplayValuesResultDto(Resources.DatabaseError + ex.Message);
            }
        }

        internal static OperationExecutedDto AddOrganization(Organization organization)
        {
            try
            {
                _bankGuaranteeContext.Organizations.Add(organization);
                _bankGuaranteeContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return new OperationExecutedDto(Resources.DatabaseError + ex.Message);
            }


            _organizationCreator.OnCreated(new EntityCreatedDto(organization.Id, organization.Name));
            
            return OperationExecutedDto.Success;
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
        static internal Form CreateNew(IOrganizationCreator organizationCreator)
        {
            _organizationCreator = organizationCreator;
            return new OrganizationCreateForm();
        }

        internal static void CreationCanceled()
        {
            _organizationCreator.OnCreated(EntityCreatedDto.Canceled);
        }
    }
}
