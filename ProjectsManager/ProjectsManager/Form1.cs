using System;
using System.Drawing;
using System.Windows.Forms;


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
                MainForm mainForm = new MainForm(loginHandler.username);
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

    }
}
