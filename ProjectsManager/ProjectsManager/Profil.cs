using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class Profil : Form
    {

        #region Fields
        private RegistrationHandler handler;
        #endregion

        #region Properties
        private int user_id { get; set; }
        private string user_email {get; set;}
        #endregion

        #region Constructor
        public Profil(int user_id)
        {
            InitializeComponent();
            passwordStrengthLabel.Font = new Font("Cambria", 10F);
            handler = new RegistrationHandler();
            this.user_id = user_id;
        }
        #endregion

        private void OnFormLoad()
        {
            NameTextBox.ForeColor = Color.Indigo;
            classComboBox.Items.Clear();
            classComboBox.Items.Add(new ComboItem("Trieda", 0));
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
                classComboBox.Items.Add(new ComboItem(reader.GetString("class_name"), reader.GetInt32("class_id")));
            }
            reader.Close();
            classComboBox.SelectedIndex = 0;
            string user_query = $"SELECT user_full_name, user_email, user_password, user_role, user_class FROM users WHERE user_id = {this.user_id}";
            MySqlCommand comm = new MySqlCommand(user_query, DB.connection);
            MySqlDataReader dataReader = comm.ExecuteReader();
            if (!dataReader.HasRows)
            {
                dataReader.Close();
                return;
            }
            while (dataReader.Read())
            {
                string username = dataReader.GetString("user_full_name");
                string password = dataReader.GetString("user_password");
                this.user_email = dataReader.GetString("user_email");
                string user_role = dataReader.GetString("user_role");
                int user_class = !dataReader.IsDBNull(4) ? dataReader.GetInt32("user_class") : 0;
                NameTextBox.Texts = username;
                PasswordTextBox.Texts = password;
                EmailTextBox.Texts = this.user_email;
                classComboBox.SelectedIndex = user_class;
                ConfirmPasswordTextBox.Texts = string.Empty;
            }
            dataReader.Close();
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

        private void Profil_Load(object sender, EventArgs e)
        {
            OnFormLoad();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Texts.Trim() == string.Empty || EmailTextBox.Texts.Trim() == string.Empty || PasswordTextBox.Texts.Trim() == string.Empty || ConfirmPasswordTextBox.Texts.Trim() == string.Empty || classComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Vyplňte prosím všetky polia");
                return;
            }
            string name = NameTextBox.Texts.Trim();
            string email = EmailTextBox.Texts.Trim();
            string password = PasswordTextBox.Texts.Trim();
            int user_class = ((ComboItem)classComboBox.SelectedItem).Value;

            if (email != this.user_email)
            {
                if (handler.EmailExists(email))
                {
                    errorMessageLabel.ForeColor = Color.Red;
                    errorMessageLabel.Text = "Zadaný email už existuje";
                    return;
                }
            }
            if (ConfirmPasswordTextBox.Texts.Trim() != password)
            {
                ConfirmPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            this.user_email = email;
            handler.UpdateUser(new User(this.user_id, name, email, password, "Študent", user_class));
            MessageBox.Show("Profil úspešne aktualizovaný");
            OnFormLoad();
        }
    }
}
