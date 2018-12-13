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
            AppStartController.SetStartForm(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Авторизация
            var loginResult = AppStartController.Login(new LoginInputDto
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text
            });

            if (loginResult.Success)
            {
                // Если авторизировались, открываем следующую форму
                this.Hide();
                loginResult.NextForm.Show();
            }
            else
            {
                // Если авторизация не удалась, показываем сообщение
                MessageBox.Show(loginResult.ErrorText);
            }
        }
    }
}
