using BankGuarantee.Desktop.Controllers;
using BankGuarantee.Desktop.Forms.FormHelpers;
using BankGuarantee.Desktop.Interfaces;
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
    public partial class GuaranteesListForm : Form, IGuaranteeViewOpener
    {
        public GuaranteesListForm()
        {
            InitializeComponent();
        }

        private void GuaranteesListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankGuaranteeDataSet.Guarantees". При необходимости она может быть перемещена или удалена.
            this.guaranteesTableAdapter.Fill(this.bankGuaranteeDataSet.Guarantees);

        }

        private void guaranteesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void GuaranteesListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppStartController.CloseApp();
        }

        private void guaranteesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var guaranteeId = (int)senderGrid.Rows[e.RowIndex].Cells["Id"].Value;
                Form guaranteeForm = GuaranteeController.ViewGuaranteeItem(guaranteeId, this);
                this.Hide();
                guaranteeForm.Show();
                LocationHelper.PassLocationToNextForm(this, guaranteeForm);
            }
        }

        public void OnGuaranteeViewClosed(Form guaranteeViewForm)
        {
            LocationHelper.PassLocationToNextForm(guaranteeViewForm, this);
            this.Show();
        }
    }
}
