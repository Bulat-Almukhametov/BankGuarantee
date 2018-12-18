using BankGuarantee.Desktop.Controllers;
using BankGuarantee.Desktop.Forms.FormHelpers;
using BankGuarantee.Domain.Models;
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
    public partial class OrganizationCreateForm : Form
    {
        public OrganizationCreateForm()
        {
            InitializeComponent();
        }

        private void OrganizationCreateForm_Load(object sender, EventArgs e)
        {
            var peopleResult = PersonController.PeopleList();
            if (!peopleResult.Success)
            {
                MessageBox.Show(peopleResult.ErrorText);
                return;
            }

            ComponentBindingHelper.BindComboboxToDictionary(founderComboBox, peopleResult.Entities);
            ComponentBindingHelper.BindComboboxToDictionary(chiefComboBox, peopleResult.Entities);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(foundedYearTextBox.Text, out var foundedYear);
            var addOrganizationResult = OrganizationController.AddOrganization(new Organization
            {
                Name = nameTextBox.Text,
                Inn = innTextBox.Text,
                Ogrn = ogrnTextBox.Text,
                FoundedYear = foundedYear,
                Address = addressTextBox.Text,
                FounderId = ComponentBindingHelper.GetComboboxItemKey(founderComboBox),
                ChiefExecutiveId = ComponentBindingHelper.GetComboboxItemKey(chiefComboBox)
            });

            if (addOrganizationResult.Executed)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(addOrganizationResult.ErrorText);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OrganizationController.CreationCanceled();
        }
    }
}
