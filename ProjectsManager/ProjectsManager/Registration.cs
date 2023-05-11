using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class Registration : Form
    {

        private Form1 LoginForm { get; set; }

        public Registration(Form1 loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;  
        }

        private void customTextbox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.PlaceholderText.Trim() != string.Empty && PasswordTextBox.Texts.Trim() == string.Empty)
            {
                return;
            }
            PasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? false : true;

            if (ConfirmPasswordTextBox.PlaceholderText.Trim() != string.Empty && ConfirmPasswordTextBox.Texts.Trim() == string.Empty)
            {
                return;
            }
            ConfirmPasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? false : true;
        }

        private void ConfirmPasswordTextBox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
