namespace ProjectsManager
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToLoginButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordStrengthPanel = new System.Windows.Forms.Panel();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmPasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.EmailTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.PasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.NameTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.BackToLoginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 507);
            this.panel1.TabIndex = 0;
            // 
            // BackToLoginButton
            // 
            this.BackToLoginButton.BackColor = System.Drawing.Color.Indigo;
            this.BackToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLoginButton.FlatAppearance.BorderSize = 0;
            this.BackToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToLoginButton.ForeColor = System.Drawing.Color.White;
            this.BackToLoginButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackToLoginButton.IconColor = System.Drawing.Color.White;
            this.BackToLoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackToLoginButton.IconSize = 40;
            this.BackToLoginButton.Location = new System.Drawing.Point(0, 12);
            this.BackToLoginButton.Name = "BackToLoginButton";
            this.BackToLoginButton.Size = new System.Drawing.Size(93, 36);
            this.BackToLoginButton.TabIndex = 9;
            this.BackToLoginButton.UseVisualStyleBackColor = false;
            this.BackToLoginButton.Click += new System.EventHandler(this.BackToLoginButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(838, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 507);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(336, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrácia";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.Indigo;
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.White;
            this.RegistrationButton.Location = new System.Drawing.Point(374, 426);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(184, 48);
            this.RegistrationButton.TabIndex = 7;
            this.RegistrationButton.Text = "Registrovať";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(272, 347);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(154, 27);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Zobraziť heslo";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // passwordStrengthPanel
            // 
            this.passwordStrengthPanel.BackColor = System.Drawing.SystemColors.Control;
            this.passwordStrengthPanel.Location = new System.Drawing.Point(553, 363);
            this.passwordStrengthPanel.Name = "passwordStrengthPanel";
            this.passwordStrengthPanel.Size = new System.Drawing.Size(91, 11);
            this.passwordStrengthPanel.TabIndex = 9;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(550, 345);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(11, 15);
            this.passwordStrengthLabel.TabIndex = 10;
            this.passwordStrengthLabel.Text = "-";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(269, 83);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 15);
            this.errorMessageLabel.TabIndex = 11;
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(692, 111);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 30);
            this.classComboBox.TabIndex = 0;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.BorderSize = 1;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(272, 290);
            this.ConfirmPasswordTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.ConfirmPasswordTextBox.Multiline = false;
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.ConfirmPasswordTextBox.PasswordChar = true;
            this.ConfirmPasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.ConfirmPasswordTextBox.PlaceholderText = "Zopakujte heslo";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(372, 37);
            this.ConfirmPasswordTextBox.TabIndex = 4;
            this.ConfirmPasswordTextBox.Texts = "";
            this.ConfirmPasswordTextBox.UnderlinedStyle = false;
            this.ConfirmPasswordTextBox._TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox__TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.BorderSize = 1;
            this.EmailTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.Location = new System.Drawing.Point(272, 169);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.EmailTextBox.PasswordChar = false;
            this.EmailTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(372, 37);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.Texts = "";
            this.EmailTextBox.UnderlinedStyle = false;
            this.EmailTextBox._TextChanged += new System.EventHandler(this.customTextbox3__TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.BorderSize = 1;
            this.PasswordTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.Location = new System.Drawing.Point(272, 229);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Heslo";
            this.PasswordTextBox.Size = new System.Drawing.Size(372, 37);
            this.PasswordTextBox.TabIndex = 3;
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
            this.NameTextBox.Location = new System.Drawing.Point(272, 111);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(0, 23);
            this.NameTextBox.Multiline = false;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameTextBox.PasswordChar = false;
            this.NameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.NameTextBox.PlaceholderText = "Meno a priezvisko";
            this.NameTextBox.Size = new System.Drawing.Size(372, 37);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Texts = "";
            this.NameTextBox.UnderlinedStyle = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.passwordStrengthLabel);
            this.Controls.Add(this.passwordStrengthPanel);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextbox NameTextBox;
        private CustomComponents.CustomTextbox PasswordTextBox;
        private CustomComponents.CustomTextbox EmailTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private FontAwesome.Sharp.IconButton BackToLoginButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private CustomComponents.CustomTextbox ConfirmPasswordTextBox;
        private System.Windows.Forms.Panel passwordStrengthPanel;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.ComboBox classComboBox;
    }
}