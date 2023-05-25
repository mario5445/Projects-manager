using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class UserEditForm : Form
    {
        private int user_id { get; set; }
        private string user_role { get; set; }
        private string user_email { get; set; }

        public UserEditForm(int user_id, string user_role)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.user_role = user_role;
            if (this.user_role == "Učiteľ")
            {
                classCombobox.Enabled = false;
                classCombobox.Visible = false;
                classLabel.Enabled = false;
                classLabel.Visible = false;
            }
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            GetDataForClassCombobox();
            LoadData();
        }

        private void LoadData()
        {
            string query = $"SELECT user_full_name, user_email, user_password, user_class FROM users WHERE user_id = {this.user_id} LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Užívateľ sa nenašiel");
                this.Close();
                return;
            }
            while (reader.Read())
            {
                string user_full_name = reader.GetString("user_full_name");
                this.user_email = reader.GetString("user_email");
                string password = reader.GetString("user_password");
                int user_class = reader.IsDBNull(3) ? 0 : reader.GetInt32("user_class");
                nameTextbox.Texts = user_full_name;
                emailTextbox.Texts = this.user_email;
                passwordTextbox.Texts = password;
                if (user_class != 0)
                {
                    classCombobox.SelectedIndex = user_class - 1;
                }
                else
                {
                    classCombobox.SelectedIndex = 0;
                }
            }
            reader.Close();
        }

        private void GetDataForClassCombobox()
        {
            string classes_query = "SELECT class_id, class_name FROM classes ORDER BY class_id ASC;";
            MySqlCommand cmd = new MySqlCommand(classes_query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                classCombobox.Items.Add(new ComboItem(reader.GetString("class_name"), reader.GetInt32("class_id")));
            }
            reader.Close();
            classCombobox.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.PlaceholderText.Trim() != string.Empty && passwordTextbox.Texts.Trim() == string.Empty)
            {
                return;
            }
            passwordTextbox.PasswordChar = ShowPasswordCheckbox.Checked ? false : true;

            if (confirmPasswordTextbox.PlaceholderText.Trim() != string.Empty && confirmPasswordTextbox.Texts.Trim() == string.Empty)
            {
                return;
            }
            confirmPasswordTextbox.PasswordChar = ShowPasswordCheckbox.Checked ? false : true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Texts.Trim().Length >= 32)
            {
                MessageBox.Show("Meno je príliš dlhé");
                return;
            }
            if (emailTextbox.Texts.Trim().Length >= 255)
            {
                MessageBox.Show("Email je príliš veľký");
                return;
            }
            if (passwordTextbox.Texts.Trim().Length >= 60)
            {
                MessageBox.Show("Heslo je príliš dlhé");
                return;
            }
            RegistrationHandler handler = new RegistrationHandler();
            string name = nameTextbox.Texts.Trim();
            string email = emailTextbox.Texts.Trim();
            string password = passwordTextbox.Texts.Trim();
            string confirmedPassword = confirmPasswordTextbox.Texts.Trim();
            if (name == string.Empty || email == string.Empty || password == string.Empty || confirmedPassword == string.Empty)
            {
                MessageBox.Show("Všetky polia musia byť vyplnené");
                return;
            }
            if (password != confirmedPassword)
            {
                confirmPasswordTextbox.BorderColor = Color.Red;
                return;
            }
            if (!handler.IsValidEmail(email))
            {
                MessageBox.Show("Zadajte platnú emailovú adresu!");
                emailTextbox.Texts = string.Empty;
                return;
            }
            if (email != this.user_email)
            {
                if (handler.EmailExists(email))
                {
                    MessageBox.Show("Vami zadaný email už existuje");
                    emailTextbox.Texts = string.Empty;
                    return;
                }
            }
            if (this.user_role == "Študent")
            {
                int class_id = ((ComboItem)classCombobox.SelectedItem).Value;
                handler.UpdateUser(new User(this.user_id, name, email, password, this.user_role, class_id));
            }
            else if (this.user_role == "Učiteľ")
            {
                handler.UpdateTeacher(new User(this.user_id, name, email, password, this.user_role));
            }
            MessageBox.Show("Užívateľ úspešne aktualizovaný");
            this.Close();
        }
    }
}
