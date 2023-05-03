using MySql.Data.MySqlClient;
using System;

namespace ProjectsManager
{
    public class LoginHandler 
    {
        #region Properties
        private string username { get; set; }
        private string password { get; set; }

        #endregion

        #region Constructor
        public LoginHandler(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Validates login 
        /// </summary>
        /// <returns>ID of user or null</returns>
        public int? ValidateLogin() // int? -> moze vratit aj null
        {
            string query = "SELECT user_id, user_email, user_password FROM users WHERE user_email = @Name"; // sql query
            MySqlCommand cmd = new MySqlCommand(query, DB.connection); // novy command
            cmd.Parameters.AddWithValue("@Name", username); // sql injection
            MySqlDataReader reader = cmd.ExecuteReader(); // citac dat
            int id = 0; // premenna na ulozenie idcka
            string pass = ""; // premenna na ulozenie hesla
            if (!reader.HasRows) // kontrola ci query nevratila prazdnu tabulku
            {
                reader.Close(); // zatvorenie citaca
                return null;
            }
            while (reader.Read()) // citanie dat
            {
                id = reader.GetInt32("user_id"); // priradenie do premennej podla nazvu stlpca
                pass = reader.GetString("user_password");
            }
            if (pass == password) // kontrola ci sa heslo v databaze zhoduje so zadanym heslom
            {
                reader.Close();
                return id; // navratova hodnota
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        #endregion
    }
}
