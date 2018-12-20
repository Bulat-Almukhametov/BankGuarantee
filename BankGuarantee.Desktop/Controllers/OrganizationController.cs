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
    // класс, содержащий методы для работы с организациями
    static class OrganizationController
    {
        static BankGuaranteeContext _bankGuaranteeContext;
        static IEntityCreator _organizationCreator;
        static OrganizationController()
        {
            // создаем объект для подключения к БД
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        /// <summary>
        /// Возвращает список с именами и идентификаторами организаций для выбора из списка
        /// </summary>
        /// <returns></returns>
        static internal EntitiesDisplayValuesResultDto GetOrganizationNames()
        {
            try
            {
                // получаем список из БД
                var organizations = _bankGuaranteeContext.Organizations
                    .Select(org => new { org.Id, org.Name })
                    .ToDictionary(org => org.Id, org => org.Name);

                return new EntitiesDisplayValuesResultDto(organizations);
            }
            catch (Exception ex)
            {
                // если при получении из БД произошла ошибка, то выводим сообщение
                return new EntitiesDisplayValuesResultDto(Resources.DatabaseError + ex.Message);
            }
        }

        /// <summary>
        /// добавляем новую организацию в БД
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        internal static OperationExecutedDto AddOrganization(Organization organization)
        {
            try
            {
                // добавляем в БД
                _bankGuaranteeContext.Organizations.Add(organization);
                _bankGuaranteeContext.SaveChanges();
            }
            catch (Exception ex)
            {
                // выводим ошибку при работе с БД
                return new OperationExecutedDto(Resources.DatabaseError + ex.Message);
            }

            // уведомляем страницу, которая открыла окно для создания организаций
            _organizationCreator.OnCreated(new EntityCreatedDto(organization.Id, organization.Name));
            
            return OperationExecutedDto.Success;
        }
        /// <summary>
        /// Получаем подробную информацию об организации по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static internal Organization GetOrganization(int id)
        {
            // ищем в БД
            var organization = _bankGuaranteeContext.Organizations
                .Include(o => o.Founder)
                .Include(o => o.ChiefExecutive)
                .FirstOrDefault(o => o.Id == id);
            // если не найдена, то возвращаем ошибку, что неверный идентификатор
            if (organization == null)
                throw new ArgumentException(Resources.WrongId);

            return organization;
        }
        /// <summary>
        /// Открываем окно для создания новой организации
        /// </summary>
        /// <param name="organizationCreator"></param>
        /// <returns></returns>
        static internal Form CreateNew(IEntityCreator organizationCreator)
        {
            // запоминаем окно, из которого мы перешли на новую страницу
            _organizationCreator = organizationCreator;
            // возвращаем страницу для создания организации
            return new OrganizationCreateForm();
        }

        internal static void CreationCanceled()
        {
            // уведомляем страницу, открывшую окно для создании организации, что произошла отмена
            _organizationCreator.OnCreated(EntityCreatedDto.Canceled);
        }
    }
}
