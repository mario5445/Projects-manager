using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace ProjectsManager
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
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
            DB.connection.Close(); // odpojenie od databazy
            DB.connection.Dispose(); 
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

        private void forgetPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = Interaction.InputBox("Zadajte email, ktorým ste sa registrovali", "Obnova hesla", string.Empty, -1, -1);
            if (email.Length < 1)
            {
                return;
            }
            RegistrationHandler handler = new RegistrationHandler();
            if (!handler.EmailExists(email))
            {
                MessageBox.Show("Zadaný email neexsituje");
                return;
            }
            string query = $"SELECT user_password FROM users WHERE user_email = '{email}'";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            string password = "";
            while (reader.Read())
            {
                password = reader.GetString("user_password");
            }
            reader.Close();
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("mario.lastovica228@gmail.com", "No replay"); //pošiljatelj (vedno enak)
            mail.Subject = "Obnova hesla pre portál SOŠ SPŠ IT KNM";
            mail.Body = "<h1>Obnova hesla</h1><br>" +
                $"<p>Vaše heslo je: {password}<p>";  
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("mario.lastovica228@gmail.com", "yvfdubojiekretof"); // Enter seders User name and password  
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
