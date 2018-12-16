using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.Models
{
    class GetOrganizationNamesResultDto
    {
        public GetOrganizationNamesResultDto(string errorText)
        {
            Success = false;
            ErrorText = errorText;
        }
        public GetOrganizationNamesResultDto(Dictionary<int, string> organizations)
        {
            if (organizations == null)
                throw new ArgumentNullException();

            Success = true;
            Organizations = organizations;
        }
        public bool Success { get; }
        public string ErrorText { get; }
        public Dictionary<int, string> Organizations { get; }
    }
}
