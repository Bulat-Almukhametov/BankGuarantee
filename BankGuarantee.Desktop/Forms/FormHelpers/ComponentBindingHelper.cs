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
        internal static void BindComboboxToDictionary(ComboBox combobox, Dictionary<int, string> dictionary)
        {
            combobox.DataSource = new BindingSource(dictionary, null);
            combobox.DisplayMember = "Value";
            combobox.ValueMember = "Key";
        }

        /// <summary>
        /// значение у выделенного элемента приходит как int или как KeyValuePair<int, string>
        /// </summary>
        /// <param name="sender">ComboBox</param>
        /// <returns>id</returns>         
        internal static int GetComboboxItemKey(object sender)
        {
            var combobox = sender as ComboBox;
            KeyValuePair<int, string>? keyValuePair = combobox.SelectedValue as KeyValuePair<int, string>?;
            int id;
            if (keyValuePair.HasValue)
            {
                id = keyValuePair.Value.Key;
            }
            else
            {
                id = (int)combobox.SelectedValue;
            }

            return id;
        }
    }
}
