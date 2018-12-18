using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.Models
{
    class EntitiesDisplayValuesResultDto
    {
        public EntitiesDisplayValuesResultDto(string errorText)
        {
            Success = false;
            ErrorText = errorText;
        }
        public EntitiesDisplayValuesResultDto(Dictionary<int, string> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(); 

            Success = true;
            Entities = entities;
        }
        public bool Success { get; }
        public string ErrorText { get; }
        public Dictionary<int, string> Entities { get; }
    }
}
