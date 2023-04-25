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
            connString = "";
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
    }
}
