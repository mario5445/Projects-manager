using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectsManager.DB;

namespace ProjectsManager
{
    public class LoginHandler 
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginHandler(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int? ValidateLogin()
        {
            var query = "SELECT id, email, password FROM users WHERE email = @Name";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", username);
            MySqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            string email = "";
            string pass = "";
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            while (reader.Read())
            {
                id = reader.GetInt32("id");
                email = reader.GetString("email");
                pass = reader.GetString("password");
            }
            if (pass == password)
            {
                reader.Close();
                return id;
            }
            else
            {
                reader.Close();
                return null;
            }
        }


    }
}
