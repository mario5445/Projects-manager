using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjectsManager
{
    public static class DB
    {
        #region Fields
        private static string connString = "SERVER=usa.vybrat.eu;PORT=3306;DATABASE=c71_database;UID=c71_admin;PASSWORD=Qw6hVp3T!"; // connection string

        #endregion

        #region Properties
        public static MySqlConnection connection { get; private set; } // property pre pripojenie 

        #endregion

        #region Methods
        /// <summary>
        /// Connects to database
        /// </summary>
        public static void connect()
        {
            MySqlConnection conn = new MySqlConnection(); // novy connection
            try
            {
                conn.ConnectionString = connString; // pripojenie connection stringu k MySqlConnection
                conn.Open(); // pripojenie sa
            }
            catch (Exception ex) // zachytenie erroru
            {
                MessageBox.Show("Error when connecting to database"); // chybova hlaska
                conn.Close(); // odpojenie sa
                conn.Dispose();
                Application.Exit(); // opustenie aplikacie
            }
            connection = conn; // priradenie pripojenia do property
        }
        #endregion
    }
}
