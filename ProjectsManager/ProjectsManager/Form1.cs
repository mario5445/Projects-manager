using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ProjectsManager
{
    public partial class Form1 : Form
    {
        private bool InternetConnection = true;
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DB.checkInternetConnection())
            {
                InternetConnection = false;
                MessageBox.Show("Žiadne internetové pripojenie");
                Environment.Exit(0);
                
            }
            DB.connect(); // pripojenie sa do databazy
            this.ActiveControl = null;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (emailTextbox.Texts.Trim() == string.Empty || passwordTextbox.Texts.Trim() == string.Empty) // overenie ci textboxy nie su prazdne
            {
                return;
            }

            LoginHandler loginHandler = new LoginHandler(emailTextbox.Texts.Trim(), passwordTextbox.Texts.Trim()); // vytvorenie instancie objektu
            int? result = loginHandler.ValidateLogin(); // validovanie loginu a ulozenie vysledku do premennej
            if (result.HasValue) // kontrola ci vysledok nie je null
            {
                errorLabel.Text = ""; // vymazanie textu chybovej hlasky
                MainForm mainForm = new MainForm(loginHandler.username, loginHandler.user_id, loginHandler.user_role);
                this.Hide();
                mainForm.Show();
                emailTextbox.Texts = string.Empty;
                passwordTextbox.Texts = string.Empty;
                mainForm.FormClosed += (s, d) => this.Show();
            }
            else
            {
                errorLabel.ForeColor = Color.Red; // nastavenie farby textu chybovej hlasky
                errorLabel.Text = "Nesprávne heslo alebo email"; // nastavenie textu chybovej hlasky
                passwordTextbox.Texts = string.Empty;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.PlaceholderText.Trim() != string.Empty && passwordTextbox.Texts.Trim() == string.Empty)
            {
                return;
            }
            passwordTextbox.PasswordChar = checkBox1.Checked ? false : true; // zobrazenie hesla v citatelnej forme alebo v gulickach
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (InternetConnection)
            {
                DB.connection.Close(); // odpojenie od databazy
                DB.connection.Dispose();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration(this);
            reg.Show();
            this.Hide();
            emailTextbox.Texts = string.Empty;
            passwordTextbox.Texts = string.Empty;
            reg.FormClosed += (s, d) => this.Show();
        }

        private void passwordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signInBtn.PerformClick();
                this.ActiveControl = null;
            }
        }

        private async void forgetPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = Interaction.InputBox("Zadajte email, ktorým ste sa registrovali", "Obnova hesla", string.Empty, -1, -1).Trim();
            if (email.Length < 1)
            {
                MessageBox.Show("Email musí byť vyplnený!");
                return;
            }
            RegistrationHandler handler = new RegistrationHandler();
            if (!handler.EmailExists(email))
            {
                MessageBox.Show("Zadaný email neexsituje");
                return;
            }
            string query = $"SELECT user_password FROM users WHERE user_email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = cmd.ExecuteReader();
            string password = "";
            while (reader.Read())
            {
                password = reader.GetString("user_password");
            }
            reader.Close();
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("mario.lastovica228@gmail.com", "No reply"); 
            mail.Subject = "Obnova hesla pre portál SOČ SPŠ IT KNM";
            mail.Body = "<h1>Obnova hesla</h1><br>" +
                $"<p>Vaše heslo je: <strong>{password}</strong><p>" +
                $"<p>Ak ste si tento email nevyžiadali, prosím nevšímajte si ho</p>";  
            mail.IsBodyHtml = true;
            await Task.Run(() => SendMail(mail));
        }

        private async Task SendMail(MailMessage mail)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("mario.lastovica228@gmail.com", "yvfdubojiekretof");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email sa nepodarilo odoslať");
                return;
            }
        }


        private void passwordTextbox__TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                passwordTextbox.PasswordChar = true;
            }
        }
    }
}
