using BankGuarantee.Desktop.Controllers;
using BankGuarantee.Desktop.Forms.FormHelpers;
using BankGuarantee.Desktop.Interfaces;
using BankGuarantee.Desktop.Models;
using BankGuarantee.Desktop.Properties;
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
    public partial class GuaranteeCreateForm : Form, IEntityCreator
    {
        const int CREATE_NEW_KEY = -1;
        private Dictionary<int, string> _organizationsDictionary;
        private bool _closeApp = true;
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

            _organizationsDictionary = organizationsResult.Entities;
            _organizationsDictionary.Add(CREATE_NEW_KEY, Resources.CreateNew);
            ComponentBindingHelper.BindComboboxToDictionary(organizationsComboBox, _organizationsDictionary);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GuaranteeCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeApp)
                AppStartController.CloseApp();
        }

        private void organizationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ComponentBindingHelper.GetComboboxItemKey(sender);
            if (id == CREATE_NEW_KEY)
            {
                var nextForm = OrganizationController.CreateNew(this);
                nextForm.TopMost = true;
                nextForm.Show();
            }
            else
            {
                var organization = OrganizationController.GetOrganization(id);
                FillOrganizationFields(organization);
            }
        }

        private void FillOrganizationFields(Domain.Models.Organization organization)
        {
            innTextBox.Text = organization.Inn;
            ogrnTextBox.Text = organization.Ogrn;
            founderTextBox.Text = organization.Founder.Name;
            chiefTextBox.Text = organization.ChiefExecutive.Name;
            addressTextBox.Text = organization.Address;
            ageTextBox.Text = (DateTime.Now.Year - organization.FoundedYear).ToString();
        }

        void IEntityCreator.OnCreated(EntityCreatedDto entityInfo)
        {
            if (entityInfo.Success)
            {
                var source = (BindingSource)organizationsComboBox.DataSource;
                // вставляем новую организацию предпоследней перед кнопкой "Создать"
                source.Insert(source.Count - 1, new KeyValuePair<int, string>(entityInfo.Id, entityInfo.DisplayValue));
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(amountTextBox.Text, out var amount);
            Int32.TryParse(periodTextBox.Text, out var days);
            var guaranteeAddResult = GuaranteeController.AddGuarantee(new Guarantee
            {
                Name = Resources.BankGuarantee + organizationsComboBox.Text,
                Amount = amount,
                Days = days,
                StartDate = DateTime.Now,
                OrganizationId = ComponentBindingHelper.GetComboboxItemKey(organizationsComboBox)
            });

            if (guaranteeAddResult.Executed)
            {
                _closeApp = false;
                this.Close();
            }
            else
            {
                MessageBox.Show(guaranteeAddResult.ErrorText);
            }
        }
    }
}
