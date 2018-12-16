using BankGuarantee.Desktop.Controllers;
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GuaranteeController.ViewGuaranteeItemClosed(this);
            _backNavigation = true;
            this.Close();
        }
    }
}
