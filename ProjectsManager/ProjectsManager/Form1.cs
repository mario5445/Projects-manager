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
            connect();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (emailTextbox.Texts.Trim() == string.Empty || passwordTextbox.Texts.Trim() == string.Empty)
            {
                return;
            }

            LoginHandler loginHandler = new LoginHandler(emailTextbox.Texts.Trim(), passwordTextbox.Texts.Trim());
            int? result = loginHandler.ValidateLogin();
            if (result.HasValue)
            {
                errorLabel.Text = "";
                MessageBox.Show("Ste úspšne prihlasený");
            }
            else
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Nesprávne heslo alebo email";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.PlaceholderText.Trim() != string.Empty && passwordTextbox.Texts.Trim() == string.Empty)
            {
                return;
            }
            passwordTextbox.PasswordChar = checkBox1.Checked ? false : true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.connection.Close();
            DB.connection.Dispose();
        }
    }
}
