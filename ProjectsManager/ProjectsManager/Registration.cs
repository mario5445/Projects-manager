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
    public partial class Registration : Form
    {
        private RegistrationHandler handler;

        private Form1 LoginForm { get; set; }

        public Registration(Form1 loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;  
            handler = new RegistrationHandler();
        }

        private void customTextbox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.PlaceholderText.Trim() != string.Empty && PasswordTextBox.Texts.Trim() == string.Empty)
            {
                return;
            }
            PasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? false : true;

            if (ConfirmPasswordTextBox.PlaceholderText.Trim() != string.Empty && ConfirmPasswordTextBox.Texts.Trim() == string.Empty)
            {
                return;
            }
            ConfirmPasswordTextBox.PasswordChar = ShowPasswordCheckBox.Checked ? false : true;
        }

        private void ConfirmPasswordTextBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Texts.Trim().Length >= 32)
            {
                MessageBox.Show("Meno je príliš dlhé");
                return;
            }
            if (EmailTextBox.Texts.Trim().Length >= 255)
            {
                MessageBox.Show("Email je príliš veľký");
                return;
            }
            if (PasswordTextBox.Texts.Trim().Length >= 60)
            {
                MessageBox.Show("Heslo je príliš dlhé");
                return;
            }
            if (NameTextBox.Texts.Trim() == string.Empty || EmailTextBox.Texts.Trim() == string.Empty || PasswordTextBox.Texts.Trim() == string.Empty || ConfirmPasswordTextBox.Texts.Trim() == string.Empty || classComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vyplňte prosím všetky polia");
                return;
            }
            string name = NameTextBox.Texts.Trim();
            string email = EmailTextBox.Texts.Trim();
            string password = PasswordTextBox.Texts.Trim();
            int user_class = ((ComboItem)classComboBox.SelectedItem).Value;
            if (!handler.IsValidEmail(email))
            {
                MessageBox.Show("Zadajte platnú emailovú adresu");
                EmailTextBox.Texts = string.Empty;
                return;
            }
            if (handler.EmailExists(email))
            {
                errorMessageLabel.ForeColor = Color.Red;
                errorMessageLabel.Text = "Zadaný email už existuje";
                return;
            }
            if (ConfirmPasswordTextBox.Texts.Trim() != password)
            {
                ConfirmPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            handler.InsertUser(new User(name, email, password, "Študent", user_class));
            MessageBox.Show("Používateľ úspešne zaregistrovaný");
            LoginForm.Show();
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            classComboBox.Items.Add(new ComboItem("Trieda", 0));
            string classes_query = "SELECT class_id, class_name FROM classes;";
            MySqlCommand cmd = new MySqlCommand(classes_query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                classComboBox.Items.Add(new ComboItem(reader.GetString("class_name"), reader.GetInt32("class_id")));
            }
            reader.Close();
            classComboBox.SelectedIndex = 0;
        }

        private void PasswordTextBox__TextChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = false;
                ConfirmPasswordTextBox.PasswordChar = false;
            }
            string password = PasswordTextBox.Texts.Trim();
            if (password == string.Empty)
            {
                passwordStrengthLabel.Text = "-";
                passwordStrengthPanel.BackColor = Color.Gray;
                return;
            }
            PasswordScore score = PassworChecker.CheckStrength(password);

            switch (score)
            {
                case PasswordScore.TooShort:
                    passwordStrengthLabel.Text = "Príliš krátke";
                    passwordStrengthPanel.BackColor = Color.DarkRed;
                    break;
                case PasswordScore.VeryWeak:
                    passwordStrengthLabel.Text = "Veľmi slabé";
                    passwordStrengthPanel.BackColor = Color.Red;
                    break;
                case PasswordScore.Weak:
                    passwordStrengthLabel.Text = "Slabé";
                    passwordStrengthPanel.BackColor = Color.Salmon;
                    break;
                case PasswordScore.Medium:
                    passwordStrengthLabel.Text = "Medium";
                    passwordStrengthPanel.BackColor = Color.Orange;
                    break;
                case PasswordScore.Strong:
                    passwordStrengthLabel.Text = "Silné";
                    passwordStrengthPanel.BackColor = Color.Lime;
                    break;
                case PasswordScore.VeryStrong:
                    passwordStrengthLabel.Text = "Veľmi silné";
                    passwordStrengthPanel.BackColor = Color.DarkGreen;
                    break;
            }
        }
    }
}
