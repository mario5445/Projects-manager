namespace ProjectsManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelside = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btntemporary = new FontAwesome.Sharp.IconButton();
            this.btnreports = new FontAwesome.Sharp.IconButton();
            this.btnprofile = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.panelheader = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new FontAwesome.Sharp.IconButton();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.Indigo;
            this.panelside.Controls.Add(this.LogOutButton);
            this.panelside.Controls.Add(this.iconPictureBox1);
            this.panelside.Controls.Add(this.btntemporary);
            this.panelside.Controls.Add(this.btnreports);
            this.panelside.Controls.Add(this.btnprofile);
            this.panelside.Controls.Add(this.btndashboard);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 599);
            this.panelside.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(47, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // btntemporary
            // 
            this.btntemporary.BackColor = System.Drawing.Color.Transparent;
            this.btntemporary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemporary.FlatAppearance.BorderSize = 0;
            this.btntemporary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemporary.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btntemporary.ForeColor = System.Drawing.Color.White;
            this.btntemporary.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btntemporary.IconColor = System.Drawing.Color.White;
            this.btntemporary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntemporary.IconSize = 24;
            this.btntemporary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntemporary.Location = new System.Drawing.Point(0, 216);
            this.btntemporary.Name = "btntemporary";
            this.btntemporary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btntemporary.Size = new System.Drawing.Size(200, 35);
            this.btntemporary.TabIndex = 2;
            this.btntemporary.Text = "Pridať projekt";
            this.btntemporary.UseVisualStyleBackColor = false;
            this.btntemporary.Click += new System.EventHandler(this.btntemporary_Click);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.Transparent;
            this.btnreports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnreports.ForeColor = System.Drawing.Color.White;
            this.btnreports.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnreports.IconColor = System.Drawing.Color.White;
            this.btnreports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnreports.IconSize = 24;
            this.btnreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.Location = new System.Drawing.Point(0, 180);
            this.btnreports.Name = "btnreports";
            this.btnreports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnreports.Size = new System.Drawing.Size(200, 37);
            this.btnreports.TabIndex = 1;
            this.btnreports.Text = "Moje projekty";
            this.btnreports.UseVisualStyleBackColor = false;
            // 
            // btnprofile
            // 
            this.btnprofile.BackColor = System.Drawing.Color.Transparent;
            this.btnprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprofile.FlatAppearance.BorderSize = 0;
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnprofile.IconColor = System.Drawing.Color.White;
            this.btnprofile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnprofile.IconSize = 24;
            this.btnprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprofile.Location = new System.Drawing.Point(0, 144);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnprofile.Size = new System.Drawing.Size(200, 39);
            this.btnprofile.TabIndex = 1;
            this.btnprofile.Text = "Profil";
            this.btnprofile.UseVisualStyleBackColor = false;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            this.btnprofile.MouseLeave += new System.EventHandler(this.btnprofile_MouseLeave);
            this.btnprofile.MouseHover += new System.EventHandler(this.btnprofile_MouseHover);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.Transparent;
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            this.btndashboard.IconColor = System.Drawing.Color.White;
            this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndashboard.IconSize = 24;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 108);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btndashboard.Size = new System.Drawing.Size(200, 40);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Prehľad";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            this.btndashboard.MouseLeave += new System.EventHandler(this.btndashboard_MouseLeave);
            this.btndashboard.MouseHover += new System.EventHandler(this.btndashboard_MouseHover);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Indigo;
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1161, 30);
            this.panelheader.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainpanel.Location = new System.Drawing.Point(200, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(961, 599);
            this.mainpanel.TabIndex = 2;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.LogOutButton.IconColor = System.Drawing.Color.White;
            this.LogOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOutButton.IconSize = 24;
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.Location = new System.Drawing.Point(0, 564);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LogOutButton.Size = new System.Drawing.Size(200, 35);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Odhlásiť sa";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 629);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hlavné menu";
            this.panelside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton btntemporary;
        private FontAwesome.Sharp.IconButton btnreports;
        private FontAwesome.Sharp.IconButton btnprofile;
        private FontAwesome.Sharp.IconButton btndashboard;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton LogOutButton;
    }
}