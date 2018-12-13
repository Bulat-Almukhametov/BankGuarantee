using BankGuarantee.Desktop.Controllers;
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
    public partial class GuaranteesListForm : Form
    {
        public GuaranteesListForm()
        {
            InitializeComponent();
        }

        private void GuaranteesListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankGuaranteeDataSet1.Guarantees". При необходимости она может быть перемещена или удалена.
            this.guaranteesTableAdapter.Fill(this.bankGuaranteeDataSet1.Guarantees);

        }

        private void guaranteesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void GuaranteesListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppStartController.CloseApp();
        }
    }
}
