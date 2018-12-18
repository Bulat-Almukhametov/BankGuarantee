using BankGuarantee.Desktop.Controllers;
using BankGuarantee.Desktop.Forms.FormHelpers;
using System;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Forms
{
    public partial class QuestionsForm : Form
    {
        // закрывать приложение, если форма закрылась
        private bool _closeApp = true;
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeApp)
                AppStartController.CloseApp();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var contractSum = (int)contractNumericUpDown.Value;

            // заканчиваем отвечать на вопросы и переходим к следующей форме
            var nextForm = AppStartController.AnswerQuestions(contractSum);
            nextForm.Show();
            LocationHelper.PassLocationToNextForm(this, nextForm);

            // закрываем форму но не приложение
            _closeApp = false;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://egrul.nalog.ru");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://zakupki.gov.ru/epz/order/quicksearch/search.html");
        }

        private void contractNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
