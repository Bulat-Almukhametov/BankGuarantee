using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Forms.FormHelpers
{
    static class ComponentBindingHelper
    {
        /// <summary>
        /// Привязка словаря к полю с выбором, чтобы видеть название и получить идентификатор
        /// </summary>
        /// <param name="combobox"></param>
        /// <param name="dictionary"></param>
        internal static void BindComboboxToDictionary(ComboBox combobox, Dictionary<int, string> dictionary)
        {
            combobox.DataSource = new BindingSource(dictionary, null);
            combobox.DisplayMember = "Value";
            combobox.ValueMember = "Key";
        }

        /// <summary>
        /// Получаем значение из списка для выбора
        /// </summary>
        /// <param name="sender">ComboBox</param>
        /// <returns>id</returns>         
        internal static int GetComboboxItemKey(object sender)
        {
            // поле со списком
            var combobox = sender as ComboBox;
            // если страница только загрузилась, то в SelectedValue хранится
            // ссылка на пару "ключ-значение", но если пользователь выбрал
            // значение, то там хранится идентификатор
            KeyValuePair<int, string>? keyValuePair = combobox.SelectedValue as KeyValuePair<int, string>?;
            int id;
            // если это пара ключ-значение, то получаем ключ как идентификатор
            if (keyValuePair.HasValue)
            {
                id = keyValuePair.Value.Key;
            }
            else
            {
                // иначе сразу возвращаем идентификатор
                id = (int)combobox.SelectedValue;
            }

            return id;
        }
    }
}
