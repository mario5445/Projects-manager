using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public static class DB
    {
        public static string connString = "SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c71_database;UID=c71_admin;PASSWORD=Qw6hVp3T!";

        public static MySqlConnection connection() 
        {
            var conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when connecting to database");
                conn.Close();
                conn.Dispose();
                Application.Exit();
            }
            return conn;
        }
    }
}
