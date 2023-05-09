﻿namespace ProjectsManager
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
            this.panelside = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btntemporary = new FontAwesome.Sharp.IconButton();
            this.btnreports = new FontAwesome.Sharp.IconButton();
            this.btnprofile = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.panelheader = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.Indigo;
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
            this.btntemporary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.btntemporary.Text = "+1";
            this.btntemporary.UseVisualStyleBackColor = false;
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
            this.btnreports.Text = "Oznámenia";
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
            this.mainpanel.Controls.Add(this.iconPictureBox2);
            this.mainpanel.Controls.Add(this.TextLabel);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainpanel.Location = new System.Drawing.Point(200, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(961, 599);
            this.mainpanel.TabIndex = 2;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.React;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 365;
            this.iconPictureBox2.Location = new System.Drawing.Point(298, 52);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(376, 365);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Cambria", 40F, System.Drawing.FontStyle.Bold);
            this.TextLabel.ForeColor = System.Drawing.Color.Black;
            this.TextLabel.Location = new System.Drawing.Point(25, 485);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(459, 63);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Vitajte v systéme ";
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
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hlavné menu";
            this.panelside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label TextLabel;
    }
}