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

        #region Constructor
        public MainForm(string username)
        {
            InitializeComponent();
            placeholderForm = new PlaceholderFormForMainForm(username);
            loadForm(placeholderForm);
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
                //this.mainpanel.Controls.RemoveAt(0);
                //currentForm_Form.Close();
                //currentForm_Form = null;
                //currentForm = null;
                return;
            }
            this.Text = "Prehľad";
            loadForm(new Prehlad());
            currentForm = "Prehľad";
            currentButton = btndashboard;
            if (currentButton != null)
            {
                removeCurrentBtnProperties(currentButton);
            }
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
    }
}
