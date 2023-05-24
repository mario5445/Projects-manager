using FontAwesome.Sharp;
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
    public partial class MainForm : Form
    {
        #region Fields
        private IconButton currentButton = null;
        private string currentForm = null;
        private Form currentForm_Form = null;
        private PlaceholderFormForMainForm placeholderForm;
        #endregion

        #region Properties
        private int user_id { get; set; }
        private string username { get; set; }
        private string user_role { get; set; }
        #endregion

        #region Constructor
        public MainForm(string username, int user_id, string user_role)
        {
            InitializeComponent();
            placeholderForm = new PlaceholderFormForMainForm(username);
            loadForm(placeholderForm);
            this.username = username;
            this.user_id = user_id;
            this.user_role = user_role;
            LogOutButton.IconChar = IconChar.RightFromBracket;
            
        }

        #endregion

        #region Methods
        /// <summary>
        /// Loads Form in panel
        /// </summary>
        /// <param name="Form">Form you want to load</param>
        private void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
                if (currentForm_Form != null && currentForm_Form != placeholderForm)
                {
                    currentForm_Form.Close();
                    currentForm_Form = null;
                }
            }
            Form f = Form as Form;
            f.TopLevel = false; // nastavenie properties pre form
            f.Dock= DockStyle.Fill;
            currentForm_Form = f;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.BringToFront();
            f.Show();
        }

        /// <summary>
        /// Sets colors for currently selected button
        /// </summary>
        /// <param name="button"></param>
        private void setCurrentBtnProperties(IconButton button)
        {
            button.BackColor = Color.Yellow;
            button.ForeColor = Color.Black;
            button.IconColor = Color.Black;
        }

        /// <summary>
        /// Sets default colors for button when it's unselected
        /// </summary>
        /// <param name="button"></param>
        private void removeCurrentBtnProperties(IconButton button)
        {
            button.BackColor = Color.Indigo;
            button.ForeColor = Color.White;
            button.IconColor = Color.White;
        }

        #endregion

        #region Events
        private void btndashboard_Click(object sender, EventArgs e)
        {
            if (currentForm == "Prehľad")
            {
                return;
            }
            this.Text = "Prehľad";
            loadForm(new Prehlad(this.user_id, this.user_role, DashboardType.Classic));
            currentForm = "Prehľad";
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
            currentButton = btndashboard;
            setCurrentBtnProperties(currentButton);
        }

        private void btndashboard_MouseHover(object sender, EventArgs e)
        {
            //if (currentButton != btndashboard)
            //{
            //    btndashboard.BackColor = Color.FromArgb(152, 15, 255);
            //}
        }

        private void btndashboard_MouseLeave(object sender, EventArgs e)
        {
            //if (currentButton != btndashboard)
            //{
            //    btndashboard.BackColor = Color.Indigo;
            //}
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            loadForm(placeholderForm);
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
            this.Text = "Hlavné menu";
            currentForm = null;
            currentButton = null;
        }
        

        private void btnprofile_Click(object sender, EventArgs e)
        {
            if (currentForm == "Profil")
            {
                return;
            }
            this.Text = "Profil";
            loadForm(new Profil(user_id));
            currentForm = "Profil";
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
            currentButton = btnprofile;
            setCurrentBtnProperties(currentButton);
        }

        private void btnprofile_MouseHover(object sender, EventArgs e)
        {
            //if (currentButton != btnprofile)
            //{
            //    btnprofile.BackColor = Color.FromArgb(152, 15, 255);
            //}
        }

        private void btnprofile_MouseLeave(object sender, EventArgs e)
        {
            //if (currentButton != btnprofile)
            //{
            //    btnprofile.BackColor = Color.Indigo;
            //}
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete sa naozaj odhlásiť?", "Odhlásenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
            
        }

        private void btntemporary_Click(object sender, EventArgs e)
        {
            if (this.user_role == "Učiteľ")
            {
                if (currentForm == "Pridat")
                {
                    return;
                }
                this.Text = "Pridať";
                loadForm(new AddProject(this.user_id));
                currentForm = "Pridat";
                if (currentButton != null)
                {
                    removeCurrentBtnProperties(currentButton);
                }
                currentButton = btntemporary;
                setCurrentBtnProperties(currentButton);
            }
            else if (this.user_role == "Admin")
            {
                if (currentForm == "Pridat_Uzivatela")
                {
                    return;
                }
                this.Text = "Pridať užívateľa";
                loadForm(new AddUser());
                currentForm = "Pridat_Uzivatela";
                if (currentButton != null)
                {
                    removeCurrentBtnProperties(currentButton);
                }
                currentButton = btntemporary;
                setCurrentBtnProperties(currentButton);
            }
        }

        private void btntemporary_MouseHover(object sender, EventArgs e)
        {
            //if (currentButton != btntemporary)
            //{
            //    btntemporary.BackColor = Color.FromArgb(152, 15, 255);
            //}
        }

        private void btntemporary_MouseLeave(object sender, EventArgs e)
        {
            //if (currentButton != btntemporary)
            //{
            //    btntemporary.BackColor = Color.Indigo;
            //}
        }

        private void LogOutButton_MouseHover(object sender, EventArgs e)
        {
            //LogOutButton.BackColor = Color.FromArgb(152, 15, 255);
        }

        private void LogOutButton_MouseLeave(object sender, EventArgs e)
        {
            //LogOutButton.BackColor = Color.Indigo;
        }

        private void btnMyProjects_Click(object sender, EventArgs e)
        {
            if (currentForm == "MyProjects")
            {
                return;
            }

            if (this.user_role == "Učiteľ")
            {
                this.Text = "Moje projekty";
                loadForm(new Prehlad(this.user_id, this.user_role, DashboardType.MyProjects));
                currentForm = "MyProjects";
                if (currentButton != null)
                {
                    removeCurrentBtnProperties(currentButton);
                }
                currentButton = btnMyProjects;
                setCurrentBtnProperties(currentButton);
            }
            else if (this.user_role == "Študent")
            {
                this.Text = "Môj projekt";
                string query = $"SELECT project_id FROM projects WHERE project_student = {this.user_id} LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, DB.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    int project_id = 0;
                    while (reader.Read())
                    {
                        project_id = reader.GetInt32("project_id");
                    }
                    reader.Close();
                    ProjectInfo info = new ProjectInfo(project_id, user_id, user_role);
                    info.FormBorderStyle = FormBorderStyle.None;
                    loadForm(info);
                    currentForm = "MyProjects";
                    if (currentButton != null)
                    {
                        removeCurrentBtnProperties(currentButton);
                    }
                    currentButton = btnMyProjects;
                    setCurrentBtnProperties(currentButton);
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Text = "Užívatelia";
                loadForm(new UsersDashboard());
                currentForm = "MyProjects";
                if (currentButton != null)
                {
                    removeCurrentBtnProperties(currentButton);
                }
                currentButton = btnMyProjects;
                setCurrentBtnProperties(currentButton);
            }
        }
        #endregion

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (currentForm == "Statistics")
            {
                return;
            }
            this.Text = "Štatistiky";
            loadForm(new Statistics());
            currentForm = "Statistics";
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
            currentButton = btnStatistics;
            setCurrentBtnProperties(currentButton);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.user_role == "Študent")
            {
                btnMyProjects.Text = "Môj projekt";
                btntemporary.Enabled = false;
                btntemporary.Visible = false;
            }
            if (this.user_role == "Admin")
            {
                btnMyProjects.Text = "Užívatelia";
                btnMyProjects.IconChar = IconChar.User;
                btntemporary.Text = "Pridať užívateľa";
                btntemporary.IconChar = IconChar.UserPlus;
                btnSettings.Visible = true;
                btnSettings.Enabled = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (currentForm == "Settings")
            {
                return;
            }
            this.Text = "Nastavenia";
            loadForm(new SettingsForm());
            currentForm = "Settings";
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
            currentButton = btnSettings;
            setCurrentBtnProperties(currentButton);
        }
    }
}
