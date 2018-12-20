using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.Models
{
    public class EntityCreatedDto
    {
        static internal EntityCreatedDto Canceled
        {
            get
            {
                return new EntityCreatedDto { Success = false };
            }
        }
        EntityCreatedDto() { }
        internal EntityCreatedDto(int id, string displayValue)
        {
            Id = id;
            DisplayValue = displayValue;
            Success = true;
        }
        public bool Success { get; private set; }
        public int Id { get; }
        public string DisplayValue { get; }
    }
}
