using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager
{
    public class LoginHandler : DB
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginHandler(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void ValidateLogin()
        {
            var query = $"SELECT id, email, password FROM users WHERE email = '{username}'";
            MySqlCommand cmd = new MySqlCommand(query, connection());


        }


    }
}
