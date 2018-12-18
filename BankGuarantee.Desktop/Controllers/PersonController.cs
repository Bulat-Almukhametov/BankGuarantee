using BankGuarantee.Desktop.DbIntegration;
using BankGuarantee.Desktop.Models;
using BankGuarantee.Desktop.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGuarantee.Desktop.Controllers
{
    static class PersonController
    {
        static BankGuaranteeContext _bankGuaranteeContext;

        static PersonController()
        {
            // создаем объект для работы с БД
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        /// <summary>
        /// Возвращает список всех людей для поля выбора из списка
        /// </summary>
        /// <returns></returns>
        static internal EntitiesDisplayValuesResultDto PeopleList()
        {
            try
            {
                // получаем людей из БД
                var people = _bankGuaranteeContext.People
                     .Select(p => new { p.Id, p.Surname, p.Name, p.Middlename })
                     .ToDictionary(p => p.Id, p => p.Surname + " " + p.Name + " " + p.Middlename);

                return new EntitiesDisplayValuesResultDto(people);
            }
            catch (Exception ex)
            {
                // ошибка при получении из БД
                return new EntitiesDisplayValuesResultDto(Resources.DatabaseError + ex.Message);
            }
        }
    }
}
