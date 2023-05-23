using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public class User
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public int User_class { get; private set; }
        
        public User(string name, string email, string password, string role, int user_class) 
        {
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            User_class = user_class;
        }

        public User(int iD, string name, string email, string password, string role, int user_class)
        {
            ID = iD;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            User_class = user_class;
        }

        public User(int ID, string name, string email, string password, string role)
        {
            this.ID = ID;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            User_class = 0;
        }
    }
}