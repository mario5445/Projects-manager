using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager
{
    public class RegistrationHandler
    {
        public bool EmailExists(string email)
        {
            string query = "SELECT user_email FROM users WHERE user_email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public async void InsertUser(User user)
        {
            string query = $"INSERT INTO users(user_full_name, user_email, user_password, user_role, user_class) VALUES (@Name, @Email, @Password, 'Študent', {user.User_class})";
            MySqlCommand cmd = new MySqlCommand( query, DB.connection);
            string name = user.Name;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            await cmd.ExecuteNonQueryAsync();
        }

        public async void UpdateUser(User user)
        {
            string query = $"UPDATE users SET user_full_name = @Name, user_email = @Email, user_password = @Password, user_class = @Class WHERE user_id = {user.ID}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Class", user.User_class);
            await cmd.ExecuteNonQueryAsync();
        }

        public async void UpdateTeacher(User user)
        {
            string query = $"UPDATE users SET user_full_name = @Name, user_email = @Email, user_password = @Password WHERE user_id = {user.ID}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            await cmd.ExecuteNonQueryAsync();
        }

        public async void InsertTeacher(User user)
        {
            string query = $"INSERT INTO users(user_full_name, user_email, user_password, user_role) VALUES (@Name, @Email, @Password, 'Učiteľ')";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            await cmd.ExecuteNonQueryAsync();
        }

        public bool IsValidEmail(string email)
        {
            bool valid = true;
            if (email.EndsWith("."))
            {
                return false;
            }
            try
            {
                var address = new MailAddress(email);
            }
            catch (Exception)
            {
                valid = false;
            }
            return valid;
        }

    }
}
