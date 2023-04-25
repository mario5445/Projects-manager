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
            connString = "SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c71_database;UID=c71_admin;PASSWORD=Qw6hVp3T!";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MessageBox.Show("Connection successfull");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when connecting to database");
                Environment.Exit(1);
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == string.Empty || passwordTextbox.Text == string.Empty)
            {
                return;
            }

            LoginHandler loginHandler = new LoginHandler(usernameTextbox.Text.Trim(), passwordTextbox.Text.Trim());
            loginHandler.ValidateLogin();

        }
    }
}
