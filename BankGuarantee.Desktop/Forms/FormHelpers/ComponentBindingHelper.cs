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
    }
}
