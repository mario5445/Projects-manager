namespace ProjectsManager
{
    partial class Profil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oldPasswordBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.passwordStrengthPanel = new System.Windows.Forms.Panel();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.PasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.UpdateButton = new FontAwesome.Sharp.IconButton();
            this.NameTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.classLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 549);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(711, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 549);
            this.panel2.TabIndex = 18;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 187;
            this.iconPictureBox1.Location = new System.Drawing.Point(32, 178);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(187, 190);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.classLabel);
            this.panel3.Controls.Add(this.oldPasswordBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.errorMessageLabel);
            this.panel3.Controls.Add(this.ConfirmPasswordTextBox);
            this.panel3.Controls.Add(this.passwordStrengthLabel);
            this.panel3.Controls.Add(this.passwordStrengthPanel);
            this.panel3.Controls.Add(this.classComboBox);
            this.panel3.Controls.Add(this.ShowPasswordCheckBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.EmailTextBox);
            this.panel3.Controls.Add(this.PasswordTextBox);
            this.panel3.Controls.Add(this.UpdateButton);
            this.panel3.Controls.Add(this.NameTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 549);
            this.panel3.TabIndex = 19;
            // 
            // oldPasswordBox
            // 
            this.oldPasswordBox.BackColor = System.Drawing.Color.White;
            this.oldPasswordBox.BorderColor = System.Drawing.Color.DarkGray;
            this.oldPasswordBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.oldPasswordBox.BorderSize = 1;
            this.oldPasswordBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldPasswordBox.ForeColor = System.Drawing.Color.Indigo;
            this.oldPasswordBox.Location = new System.Drawing.Point(169, 233);
            this.oldPasswordBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.oldPasswordBox.Multiline = false;
            this.oldPasswordBox.Name = "oldPasswordBox";
            this.oldPasswordBox.Padding = new System.Windows.Forms.Padding(7);
            this.oldPasswordBox.PasswordChar = true;
            this.oldPasswordBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.oldPasswordBox.PlaceholderText = "Staré heslo";
            this.oldPasswordBox.Size = new System.Drawing.Size(380, 37);
            this.oldPasswordBox.TabIndex = 25;
            this.oldPasswordBox.Texts = "";
            this.oldPasswordBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 162);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8);
            this.label3.Size = new System.Drawing.Size(76, 38);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(87, 119);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8);
            this.label2.Size = new System.Drawing.Size(74, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "Meno";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(166, 91);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLabel.TabIndex = 21;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.BorderSize = 1;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(169, 319);
            this.ConfirmPasswordTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.ConfirmPasswordTextBox.Multiline = false;
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ConfirmPasswordTextBox.PasswordChar = true;
            this.ConfirmPasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordTextBox.PlaceholderText = "Zopakujte nové heslo";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(380, 37);
            this.ConfirmPasswordTextBox.TabIndex = 20;
            this.ConfirmPasswordTextBox.Texts = "";
            this.ConfirmPasswordTextBox.UnderlinedStyle = false;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(573, 278);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(10, 13);
            this.passwordStrengthLabel.TabIndex = 19;
            this.passwordStrengthLabel.Text = "-";
            // 
            // passwordStrengthPanel
            // 
            this.passwordStrengthPanel.BackColor = System.Drawing.Color.White;
            this.passwordStrengthPanel.Location = new System.Drawing.Point(576, 302);
            this.passwordStrengthPanel.Name = "passwordStrengthPanel";
            this.passwordStrengthPanel.Size = new System.Drawing.Size(91, 11);
            this.passwordStrengthPanel.TabIndex = 18;
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(565, 119);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 30);
            this.classComboBox.TabIndex = 17;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(169, 362);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(154, 27);
            this.ShowPasswordCheckBox.TabIndex = 16;
            this.ShowPasswordCheckBox.Text = "Zobraziť heslo";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(255, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Váš profil";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AutoSize = true;
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.BorderSize = 1;
            this.EmailTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.Location = new System.Drawing.Point(169, 162);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.EmailTextBox.PasswordChar = false;
            this.EmailTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.EmailTextBox.PlaceholderText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(380, 37);
            this.EmailTextBox.TabIndex = 6;
            this.EmailTextBox.Texts = "";
            this.EmailTextBox.UnderlinedStyle = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoSize = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.BorderSize = 1;
            this.PasswordTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.Location = new System.Drawing.Point(169, 276);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Zadajte nové heslo";
            this.PasswordTextBox.Size = new System.Drawing.Size(380, 37);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.Texts = "";
            this.PasswordTextBox.UnderlinedStyle = false;
            this.PasswordTextBox._TextChanged += new System.EventHandler(this.PasswordTextBox__TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.Color.Green;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.UpdateButton.IconColor = System.Drawing.Color.White;
            this.UpdateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateButton.IconSize = 30;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(255, 463);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateButton.Size = new System.Drawing.Size(208, 39);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Aktualizovať";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.NameTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.NameTextBox.BorderSize = 1;
            this.NameTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.NameTextBox.Location = new System.Drawing.Point(169, 119);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.NameTextBox.Multiline = false;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameTextBox.PasswordChar = false;
            this.NameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.NameTextBox.PlaceholderText = "";
            this.NameTextBox.Size = new System.Drawing.Size(380, 37);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.Texts = "";
            this.NameTextBox.UnderlinedStyle = false;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classLabel.Location = new System.Drawing.Point(561, 91);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(67, 22);
            this.classLabel.TabIndex = 26;
            this.classLabel.Text = "Trieda";
            // 
            // Profil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profil";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomTextbox NameTextBox;
        private CustomComponents.CustomTextbox EmailTextBox;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextbox PasswordTextBox;
        private FontAwesome.Sharp.IconButton UpdateButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private System.Windows.Forms.Panel passwordStrengthPanel;
        private CustomComponents.CustomTextbox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomTextbox oldPasswordBox;
        private System.Windows.Forms.Label classLabel;
    }
}