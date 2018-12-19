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
using BankGuarantee.Desktop.Models;
using BankGuarantee.Domain.Models;
using BankGuarantee.Desktop.Properties;

namespace BankGuarantee.Desktop.Controllers
{
    /// <summary>
    /// Класс для методов по работе с банковскими гарантиями
    /// </summary>
    internal static class GuaranteeController
    {
        static BankGuaranteeContext _bankGuaranteeContext;
        static IGuaranteeViewOpener _guaranteeFormOpener;

        static GuaranteeController()
        {
            // создаем объект для доступа к БД
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        /// <summary>
        /// Открывает форму для просмотра подробностей для конкретной бг
        /// </summary>
        /// <param name="guaranteeId">идентификатор записи</param>
        /// <param name="guaranteeFormOpener">ссылка на форму, открывшую подробности</param>
        /// <returns></returns>
        internal static Form ViewGuaranteeItem(int guaranteeId, IGuaranteeViewOpener guaranteeFormOpener)
        {
            _guaranteeFormOpener = guaranteeFormOpener;

            var guarantee = _bankGuaranteeContext.Guarantees
                .Include(g => g.Organization)
                .Include(g => g.Organization.Founder)
                .Include(g => g.Organization.ChiefExecutive)
                .First(g => g.Id == guaranteeId);

            return new GuaranteeViewForm(guarantee);
        }

        /// <summary>
        /// Происходит при закрытии формы для просмотра бг 
        /// </summary>
        /// <param name="guaranteeViewForm">форма для просмотра бг</param>
        internal static void ViewGuaranteeItemClosed(Form guaranteeViewForm)
        {
            _guaranteeFormOpener.OnGuaranteeViewClosed(guaranteeViewForm);
        }
        internal static OperationExecutedDto AddGuarantee(Guarantee guarantee)
        {
            try
            {
                _bankGuaranteeContext.Guarantees.Add(guarantee);
                _bankGuaranteeContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return new OperationExecutedDto(Resources.DatabaseError + ex.Message);
            }

            return OperationExecutedDto.Success;
        }

        internal static OperationExecutedDto Confirm(GuaranteeConfirmation confirmation)
        {
            try
            {
                var guarantee = _bankGuaranteeContext.Guarantees.First(g => g.Id == confirmation.GuaranteeId);

                guarantee.IsProtocolPublished = confirmation.IsProtocolPublished;
                guarantee.IsRiskTerritory = confirmation.IsRiskTerritory;
                guarantee.ContractAmount = confirmation.ContractAmount;
                guarantee.GuaranteeAmountLessThanContract = confirmation.GuaranteeAmountLessThanContract;
                guarantee.Confirmed = confirmation.Confirmed;

                _bankGuaranteeContext.Entry(guarantee).State = EntityState.Modified;
                _bankGuaranteeContext.SaveChanges();

                return OperationExecutedDto.Success;
            }
            catch (Exception ex)
            {
                return new OperationExecutedDto(Resources.DatabaseError + ex.Message);
            }
        }
    }
}
