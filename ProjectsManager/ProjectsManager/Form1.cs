using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ProjectsManager.DB;

namespace ProjectsManager
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        string connString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connection();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (emailTextbox.Text == string.Empty || passwordTextbox.Text == string.Empty)
            {
                return;
            }

            LoginHandler loginHandler = new LoginHandler(emailTextbox.Texts.Trim(), passwordTextbox.Texts.Trim());
            int? result = loginHandler.ValidateLogin(conn);
            if (result.HasValue)
            {
                errorLabel.Text = "";
                MessageBox.Show("Login successfull");
            }
            else
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Incorrect password or email";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.PlaceholderText != string.Empty && passwordTextbox.Texts == string.Empty)
            {
                return;
            }
            passwordTextbox.PasswordChar = checkBox1.Checked ? false : true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
