using BankGuarantee.Desktop.Controllers;
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
    public partial class GuaranteeViewForm : Form
    {
        private Guarantee _guarantee;
        private bool _backNavigation = false;
        public GuaranteeViewForm(Guarantee guarantee)
        {
            _guarantee = guarantee;

            InitializeComponent();
        }

        private void GuaranteeViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_backNavigation)
                AppStartController.CloseApp();
        }

        private void GuaranteeViewForm_Load(object sender, EventArgs e)
        {
            captionLabel.Text = _guarantee.Name;

            organizationTextBox.Text = _guarantee.Organization.Name;
            ammountTextBox.Text = _guarantee.Amount.ToString();
            periodTextBox.Text = _guarantee.Days.ToString();

            innTextBox.Text = _guarantee.Organization.Inn;
            ogrnTextBox.Text = _guarantee.Organization.Ogrn;
            companyAgeTextBox.Text = (DateTime.Now.Year - _guarantee.Organization.FoundedYear).ToString();
            companyAdressTextBox.Text = _guarantee.Organization.Address;
            founderTextBox.Text = _guarantee.Organization.Founder.Name;
            chiefExecutiveTextBox.Text = _guarantee.Organization.ChiefExecutive.Name;

            protocolPublishedRadioButton.Checked = _guarantee.IsProtocolPublished;
            notProtocolPublishedRadioButton.Checked = !_guarantee.IsProtocolPublished;

            riskTerritoryRadioButton.Checked = _guarantee.IsRiskTerritory;
            notRiskTerritoryRadioButton.Checked = !_guarantee.IsRiskTerritory;

            contractAmountNumericUpDown.Value = _guarantee.ContractAmount;

            guaranteeAmountLessRadioButton.Checked = _guarantee.GuaranteeAmountLessThanContract;
            notGuaranteeAmountLessRadioButton.Checked = !_guarantee.GuaranteeAmountLessThanContract;

            confirmPanel.Enabled = !_guarantee.Confirmed.HasValue;
            if (_guarantee.Confirmed.HasValue)
            {
                this.Text = _guarantee.Confirmed.Value ? Resources.Confirmed : Resources.Declined;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GuaranteeController.ViewGuaranteeItemClosed(this);
            _backNavigation = true;
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Confirm(bool confirmed)
        {
            var confirmation = new GuaranteeConfirmation
            {
                GuaranteeId = _guarantee.Id,
                ContractAmount = contractAmountNumericUpDown.Value,
                GuaranteeAmountLessThanContract = guaranteeAmountLessRadioButton.Checked,
                IsProtocolPublished = protocolPublishedRadioButton.Checked,
                IsRiskTerritory = riskTerritoryRadioButton.Checked,
                Confirmed = confirmed
            };

            var result = GuaranteeController.Confirm(confirmation);
            if (result.Executed)
            {
                confirmPanel.Enabled = false;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            Confirm(true);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://egrul.nalog.ru");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://zakupki.gov.ru/epz/order/quicksearch/search.html");
        }
    }
}
