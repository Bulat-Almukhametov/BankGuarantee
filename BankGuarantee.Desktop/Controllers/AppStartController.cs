using BankGuarantee.Desktop.DbIntegration;
using BankGuarantee.Desktop.Models;
using System;
using System.Linq;
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
            // создаем объект для подключения к БД
            _bankGuaranteeContext = new BankGuaranteeContext();
        }

        /// <summary>
        /// запоминаем форму связанную с приложением
        /// </summary>
        /// <param name="form"></param>
        static internal void SetStartForm(Form form)
        {
            _startForm = form;
        }

        /// <summary>
        /// закрываем приложение
        /// </summary>
        static internal void CloseApp()
        {
            _startForm.Close();
        }

        /// <summary>
        /// логинимся в системе
        /// </summary>
        /// <param name="input">данные передаваемые для логина</param>
        /// <returns></returns>
        static internal LoginResultDto Login(LoginInputDto input)
        {
            // Проверяем логин и пароль, получаем данные о человеке
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
                // при ошибке с БД возвращаем информацию об ошибке
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

            // 
            if (result.Success)
            {
                // открываем соответствующие страницы для менеджера и специалиста
                if (person.Appointment == Appointment.Manager)
                    result.NextForm = new GuaranteeCreateForm();
                else
                    result.NextForm = new GuaranteesListForm();
            }
            else
            {
                // если человек не найден, то выводим ошибку, что данные введены некорректно
                result.ErrorText = Resources.CredentialsDenied;
            }

            return result;
        }
    }
}
