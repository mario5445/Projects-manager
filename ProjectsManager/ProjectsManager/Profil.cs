using MySql.Data.MySqlClient;
using System;
using System.Drawing;
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
        private string user_email { get; set;}
        private string user_password { get; set;}
        private string user_role { get; set;}
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
                this.user_password = dataReader.GetString("user_password");
                this.user_email = dataReader.GetString("user_email");
                this.user_role = dataReader.GetString("user_role");
                if (user_role == "Učiteľ" || user_role == "Admin")
                {
                    classLabel.Visible = false;
                    classLabel.Enabled = false;
                }
                int user_class = !dataReader.IsDBNull(4) ? dataReader.GetInt32("user_class") : 1;
                NameTextBox.Texts = username;
                EmailTextBox.Texts = this.user_email;
                classComboBox.SelectedIndex = user_class - 1;
                ConfirmPasswordTextBox.Texts = string.Empty;
                PasswordTextBox.Texts = string.Empty;
                oldPasswordBox.Texts = string.Empty;
                classComboBox.Enabled = user_role == "Študent" ? true : false;
                classComboBox.Visible = user_role == "Študent" ? true : false;
            }
            dataReader.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (oldPasswordBox.Texts.Trim() == string.Empty && oldPasswordBox.PlaceholderText.Trim() != string.Empty)
            {
                return;
            }
            oldPasswordBox.PasswordChar = ShowPasswordCheckBox.Checked ? false : true;

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
            }
            else
            {
                PasswordTextBox.PasswordChar = true;
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
            if (NameTextBox.Texts.Trim() == string.Empty || EmailTextBox.Texts.Trim() == string.Empty || PasswordTextBox.Texts.Trim() == string.Empty || ConfirmPasswordTextBox.Texts.Trim() == string.Empty || oldPasswordBox.Texts.Trim() == string.Empty)
            {
                if (PasswordTextBox.Texts.Trim() == string.Empty && oldPasswordBox.Texts.Trim() != string.Empty)
                {

                }
                else
                {
                    MessageBox.Show("Vyplňte prosím všetky polia");
                    return;
                }
            }
            if (oldPasswordBox.Texts != this.user_password)
            {
                errorMessageLabel.ForeColor = Color.Red;
                errorMessageLabel.Text = "Staré heslo sa nezhoduje!";
                oldPasswordBox.Texts = string.Empty;
                return;
            }
            string name = NameTextBox.Texts.Trim();
            string email = EmailTextBox.Texts.Trim();
            string password = PasswordTextBox.Texts.Trim() != string.Empty ? PasswordTextBox.Texts.Trim():oldPasswordBox.Texts.Trim();
           
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
            if (ConfirmPasswordTextBox.Texts.Trim() != password && PasswordTextBox.Texts.Trim() != string.Empty)
            {
                ConfirmPasswordTextBox.BorderColor = Color.Red;
                return;
            }
            this.user_email = email;
            if (this.user_role == "Študent")
            {
                handler.UpdateUser(new User(this.user_id, name, email, password, this.user_role, user_class));
            }
            else
            {
                handler.UpdateTeacher(new User(this.user_id, name, email, password, user_role));
            }
            MessageBox.Show("Profil úspešne aktualizovaný");
            OnFormLoad();
            errorMessageLabel.Visible = false;
            errorMessageLabel.Enabled = false;
        }

        private void oldPasswordBox__TextChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                oldPasswordBox.PasswordChar = false;
            }
            else
            {
                oldPasswordBox.PasswordChar = true;
            }
        }

        private void ConfirmPasswordTextBox__TextChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                ConfirmPasswordTextBox.PasswordChar = false;
            }
            else
            {
                ConfirmPasswordTextBox.PasswordChar = true;
            }
        }
    }
}
