namespace ProjectsManager
{
    partial class AddUser
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
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.passwordStrengthPanel = new System.Windows.Forms.Panel();
            this.ConfirmPasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.PasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.NameTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUserBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(492, 234);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 30);
            this.classComboBox.TabIndex = 12;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(128, 65);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 15);
            this.errorMessageLabel.TabIndex = 22;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(541, 375);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(11, 15);
            this.passwordStrengthLabel.TabIndex = 21;
            this.passwordStrengthLabel.Text = "-";
            // 
            // passwordStrengthPanel
            // 
            this.passwordStrengthPanel.BackColor = System.Drawing.SystemColors.Control;
            this.passwordStrengthPanel.Location = new System.Drawing.Point(544, 394);
            this.passwordStrengthPanel.Name = "passwordStrengthPanel";
            this.passwordStrengthPanel.Size = new System.Drawing.Size(91, 11);
            this.passwordStrengthPanel.TabIndex = 20;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.BorderSize = 1;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(263, 324);
            this.ConfirmPasswordTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.ConfirmPasswordTextBox.Multiline = false;
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ConfirmPasswordTextBox.PasswordChar = true;
            this.ConfirmPasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordTextBox.PlaceholderText = "Zopakujte heslo";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(372, 37);
            this.ConfirmPasswordTextBox.TabIndex = 17;
            this.ConfirmPasswordTextBox.Texts = "";
            this.ConfirmPasswordTextBox.UnderlinedStyle = false;
            this.ConfirmPasswordTextBox._TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox__TextChanged);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(263, 378);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(154, 27);
            this.ShowPasswordCheckBox.TabIndex = 18;
            this.ShowPasswordCheckBox.Text = "Zobraziť heslo";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.BorderSize = 1;
            this.EmailTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.Location = new System.Drawing.Point(263, 133);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.EmailTextBox.PasswordChar = false;
            this.EmailTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(372, 37);
            this.EmailTextBox.TabIndex = 14;
            this.EmailTextBox.Texts = "";
            this.EmailTextBox.UnderlinedStyle = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.BorderSize = 1;
            this.PasswordTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.Location = new System.Drawing.Point(263, 281);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Heslo";
            this.PasswordTextBox.Size = new System.Drawing.Size(372, 37);
            this.PasswordTextBox.TabIndex = 16;
            this.PasswordTextBox.Texts = "";
            this.PasswordTextBox.UnderlinedStyle = false;
            this.PasswordTextBox._TextChanged += new System.EventHandler(this.PasswordTextBox__TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.NameTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.NameTextBox.BorderSize = 1;
            this.NameTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.NameTextBox.Location = new System.Drawing.Point(263, 90);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.NameTextBox.Multiline = false;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameTextBox.PasswordChar = false;
            this.NameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.NameTextBox.PlaceholderText = "Meno a priezvisko";
            this.NameTextBox.Size = new System.Drawing.Size(372, 37);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.Texts = "";
            this.NameTextBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 57);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pridať užívateľa";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserBtn.AutoSize = true;
            this.AddUserBtn.BackColor = System.Drawing.Color.Green;
            this.AddUserBtn.FlatAppearance.BorderSize = 0;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddUserBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddUserBtn.IconColor = System.Drawing.Color.White;
            this.AddUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddUserBtn.IconSize = 40;
            this.AddUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserBtn.Location = new System.Drawing.Point(344, 474);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddUserBtn.Size = new System.Drawing.Size(233, 56);
            this.AddUserBtn.TabIndex = 23;
            this.AddUserBtn.Text = "Pridať";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.teacherRadioButton);
            this.groupBox1.Controls.Add(this.studentRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(263, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 76);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.Font = new System.Drawing.Font("Cambria", 12F);
            this.teacherRadioButton.Location = new System.Drawing.Point(125, 33);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(67, 23);
            this.teacherRadioButton.TabIndex = 1;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Učiteľ";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Font = new System.Drawing.Font("Cambria", 12F);
            this.studentRadioButton.Location = new System.Drawing.Point(6, 33);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(80, 23);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Študent";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 231;
            this.iconPictureBox1.Location = new System.Drawing.Point(678, 133);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(231, 235);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 25;
            this.iconPictureBox1.TabStop = false;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classLabel.Location = new System.Drawing.Point(488, 211);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(57, 19);
            this.classLabel.TabIndex = 26;
            this.classLabel.Text = "Trieda";
            // 
            // AddUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.passwordStrengthLabel);
            this.Controls.Add(this.passwordStrengthPanel);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private System.Windows.Forms.Panel passwordStrengthPanel;
        private CustomComponents.CustomTextbox ConfirmPasswordTextBox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private CustomComponents.CustomTextbox EmailTextBox;
        private CustomComponents.CustomTextbox PasswordTextBox;
        private CustomComponents.CustomTextbox NameTextBox;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton AddUserBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label classLabel;
    }
}