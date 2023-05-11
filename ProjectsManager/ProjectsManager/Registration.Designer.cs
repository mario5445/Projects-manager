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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.PasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.EmailTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.BackToLoginButton = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Size = new System.Drawing.Size(93, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(840, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 519);
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
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.NameTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.NameTextBox.BorderSize = 2;
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
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.Texts = "";
            this.NameTextBox.UnderlinedStyle = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.PasswordTextBox.BorderSize = 2;
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
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Texts = "";
            this.PasswordTextBox.UnderlinedStyle = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.EmailTextBox.BorderSize = 2;
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
            this.EmailTextBox.TabIndex = 5;
            this.EmailTextBox.Texts = "";
            this.EmailTextBox.UnderlinedStyle = false;
            this.EmailTextBox._TextChanged += new System.EventHandler(this.customTextbox3__TextChanged);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.Indigo;
            this.RegistrationButton.FlatAppearance.BorderSize = 0;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.White;
            this.RegistrationButton.Location = new System.Drawing.Point(369, 400);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(184, 48);
            this.RegistrationButton.TabIndex = 6;
            this.RegistrationButton.Text = "Registrovať";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(272, 346);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(154, 27);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "Zobraziť heslo";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.ConfirmPasswordTextBox.BorderSize = 2;
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
            this.ConfirmPasswordTextBox.TabIndex = 8;
            this.ConfirmPasswordTextBox.Texts = "";
            this.ConfirmPasswordTextBox.UnderlinedStyle = false;
            this.ConfirmPasswordTextBox._TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox__TextChanged);
            // 
            // BackToLoginButton
            // 
            this.BackToLoginButton.BackColor = System.Drawing.Color.Indigo;
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
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Registration";
            this.Text = "Registration";
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
    }
}