using BankGuarantee.Desktop.Controllers;
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

namespace BankGuarantee.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginResult = AuthenticationController.Login(new LoginInputDto
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text
            });

            if (loginResult.Success)
            {
                MessageBox.Show("Ура");
            }
            else
            {
                MessageBox.Show(loginResult.ErrorText);
            }
        }
    }
}
