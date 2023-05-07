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
        private IconButton currentButton = null;
        private string currentForm = null;
        public MainForm(string username)
        {
            InitializeComponent();
            if (username.Length > 17)
            {
                TextLabel.Text = string.Empty;
                TextLabel.Font = new Font("Cambria", 35F, FontStyle.Bold);
                TextLabel.Text += "Vitajte v systéme ";
            }
            TextLabel.Text += username + "!";
        }
        private void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.BringToFront();
            f.Show();
        }
        private void setCurrentBtnProperties(IconButton button)
        {
            button.BackColor = Color.Yellow;
            button.ForeColor = Color.Black;
            button.IconColor = Color.Black;
        }

        private void removeCurrentBtnProperties(IconButton button)
        {
            button.BackColor = Color.Indigo;
            button.ForeColor = Color.White;
            button.IconColor = Color.White;
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            if (currentForm == "Prehľad")
            {
                return;
            }
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

        }
    }
}
