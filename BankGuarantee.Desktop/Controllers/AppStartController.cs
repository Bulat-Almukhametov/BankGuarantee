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
using BankGuarantee.Desktop.Forms;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Controllers
{
    static class AppStartController
    {
        static BankGuaranteeContext _bankGuaranteeContext;
        static Form _startForm;

        static AppStartController()
        {
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        static internal void SetStartForm(Form form)
        {
            _startForm = form;
        }

        static internal void CloseApp()
        {
            _startForm.Close();
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
                if (person.Appointment == Appointment.Manager)
                    result.NextForm = new GuaranteeCreateForm();
                else
                    result.NextForm = new GuaranteesListForm();
            }
            else
            {
                result.ErrorText = Resources.CredentialsDenied;
            }

            return result;
        }
    }
}
