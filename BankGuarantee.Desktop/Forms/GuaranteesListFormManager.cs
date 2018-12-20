using BankGuarantee.Desktop.Controllers;
using BankGuarantee.Desktop.Forms.FormHelpers;
using BankGuarantee.Desktop.Interfaces;
using BankGuarantee.Desktop.Models;
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
    public partial class GuaranteesListFormManager : Form, IEntityCreator, IGuaranteeViewOpener
    {
        public GuaranteesListFormManager()
        {
            InitializeComponent();
        }

        private void LoadGridData()
        {
            this.guaranteesTableAdapter.Fill(this.bankGuaranteeDataSet.Guarantees);
        }

        private void GuaranteesListFormManager_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var nextForm = GuaranteeController.CreateNew(this);
            this.Hide();
            nextForm.Show();
            LocationHelper.PassLocationToNextForm(this, nextForm);
        }

        public void OnCreated(EntityCreatedDto entityInfo)
        {
            if (entityInfo.Success)
            {
                LoadGridData();
                this.Show();
            }
        }

        private void GuaranteesListFormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppStartController.CloseApp();
        }

        private void guaranteeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var guaranteeId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
                Form guaranteeForm = GuaranteeController.ViewGuaranteeItem(guaranteeId, this, false);
                this.Hide();
                guaranteeForm.Show();
            }
        }

        public void OnGuaranteeViewClosed(Form guaranteeViewForm)
        {
            this.Show();
            guaranteeViewForm.Hide();
        }
    }
}
