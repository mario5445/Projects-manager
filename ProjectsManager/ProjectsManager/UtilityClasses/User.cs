using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int User_class { get; set; }
        
        public User(string name, string email, string password, string role, int user_class) 
        {
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            User_class = user_class;
        }
    }
}