using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankGuarantee.Desktop.Models;

namespace BankGuarantee.Desktop.Interfaces
{
    interface IEntityCreator
    {
        void OnCreated(EntityCreatedDto entityInfo);
    }
}
