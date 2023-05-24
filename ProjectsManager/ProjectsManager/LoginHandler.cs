using MySql.Data.MySqlClient;
using System;

namespace ProjectsManager
{
    public class LoginHandler 
    {
        #region Properties
        private string user_email { get; set; }
        private string password { get; set; }
        public string username { get; private set; }
        public string user_role { get; private set; }
        public int user_id { get; private set; }

        #endregion

        #region Constructor
        public LoginHandler(string user_email, string password)
        {
            this.user_email = user_email;
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
            string query = "SELECT user_id, user_email, user_password, user_full_name, user_role FROM users WHERE user_email = @Name"; // sql query
            MySqlCommand cmd = new MySqlCommand(query, DB.connection); // novy command
            cmd.Parameters.AddWithValue("@Name", user_email); // sql injection
            MySqlDataReader reader = cmd.ExecuteReader(); // citac dat
            string pass = ""; // premenna na ulozenie hesla
            if (!reader.HasRows) // kontrola ci query nevratila prazdnu tabulku
            {
                reader.Close(); // zatvorenie citaca
                return null;
            }
            while (reader.Read()) // citanie dat
            {
                this.user_id = reader.GetInt32("user_id"); // priradenie do premennej podla nazvu stlpca
                pass = reader.GetString("user_password");
                this.username = reader.GetString("user_full_name");
                this.user_role = reader.GetString("user_role");
            }
            if (pass == password) // kontrola ci sa heslo v databaze zhoduje so zadanym heslom
            {
                reader.Close();
                return this.user_id; // navratova hodnota
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public void EmailUser()
        {

        }

        #endregion
    }
}
