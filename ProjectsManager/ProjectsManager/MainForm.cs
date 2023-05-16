using FontAwesome.Sharp;
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
            loadForm(new Prehlad(this.user_id, this.user_role));
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
            if (currentButton != btndashboard)
            {
                btndashboard.BackColor = Color.FromArgb(152, 15, 255);
            }
        }

        private void btndashboard_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != btndashboard)
            {
                btndashboard.BackColor = Color.Indigo;
            }
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
        #endregion

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
            if (currentButton != btnprofile)
            {
                btnprofile.BackColor = Color.FromArgb(152, 15, 255);
            }
        }

        private void btnprofile_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != btnprofile)
            {
                btnprofile.BackColor = Color.Indigo;
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete sa naozaj odhlásiť?", "odhlásenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
            
        }

        private void btntemporary_Click(object sender, EventArgs e)
        {
            if (currentForm == "Pridat")
            {
                return;
            }
            this.Text = "Pridať";
            loadForm(new AddProject());
            currentForm = "Pridat";
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
            currentButton = btntemporary;
            setCurrentBtnProperties(currentButton);
        }
    }
}
