using BankGuarantee.Desktop.Controllers;
using BankGuarantee.Desktop.Forms.FormHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Forms
{
    public partial class GuaranteeCreateForm : Form
    {
        public GuaranteeCreateForm()
        {
            InitializeComponent();
        }

        private void GuaranteeCreateForm_Load(object sender, EventArgs e)
        {
            var organizationsResult = OrganizationController.GetOrganizationNames();
            if (!organizationsResult.Success)
            {
                MessageBox.Show(organizationsResult.ErrorText);
                return;
            }

            ComponentBindingHelper.BindComboboxToDictionary(organizationsComboBox, organizationsResult.Organizations);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GuaranteeCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppStartController.CloseApp();
        }

        private void organizationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = GetComboboxItemKey(sender);
            var organization = OrganizationController.GetOrganization(id);

            innTextBox.Text = organization.Inn;
            ogrnTextBox.Text = organization.Ogrn;
            founderTextBox.Text = organization.Founder.Name;
            chiefTextBox.Text = organization.ChiefExecutive.Name;
            addressTextBox.Text = organization.Address;
            ageTextBox.Text = (DateTime.Now.Year - organization.FoundedYear).ToString();
        }

        // значение у выделенного элемента приходит как int или как KeyValuePair<int, string>
        private static int GetComboboxItemKey(object sender)
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
