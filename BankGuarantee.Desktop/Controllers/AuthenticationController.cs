using BankGuarantee.Desktop.DbIntegration;
using BankGuarantee.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BankGuarantee.Desktop.Properties;
using BankGuarantee.Domain.Models;

namespace BankGuarantee.Desktop.Controllers
{
    static class AuthenticationController
    {
        static BankGuaranteeContext _bankGuaranteeContext;

        static AuthenticationController()
        {
            _bankGuaranteeContext = new BankGuaranteeContext();
        }
        static internal LoginResultDto Login(LoginInputDto input)
        {
            Person person;
            try
            {
                person = _bankGuaranteeContext.Credentials
                    .Include(c => c.Person)
                    .FirstOrDefault(c => c.Login == input.Login && c.PasswordEncrypt == input.Password)
                    ?.Person;
            }
            catch (Exception ex)
            {
                return new LoginResultDto
                {
                    Success = false,
                    ErrorText = Resources.DatabaseError + ": " + ex.Message
                };
            }


            var result = new LoginResultDto
            {
                Success = person != null
            };

            if (result.Success)
            {
                result.NextForm = new System.Windows.Forms.Form();
            }
            else
            {
                result.ErrorText = Resources.CredentialsDenied;
            }

            return result;
        }
    }
}
