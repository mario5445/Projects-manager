namespace ProjectsManager
{
    partial class UserEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.emailTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.classCombobox = new System.Windows.Forms.ComboBox();
            this.ShowPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateButton = new FontAwesome.Sharp.IconButton();
            this.classLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(55, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Meno";
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.White;
            this.nameTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.nameTextbox.BorderSize = 1;
            this.nameTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.nameTextbox.Location = new System.Drawing.Point(59, 74);
            this.nameTextbox.MinimumSize = new System.Drawing.Size(0, 14);
            this.nameTextbox.Multiline = false;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.nameTextbox.PlaceholderText = "";
            this.nameTextbox.Size = new System.Drawing.Size(250, 30);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = true;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.Color.White;
            this.emailTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.emailTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.emailTextbox.BorderSize = 1;
            this.emailTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.emailTextbox.Location = new System.Drawing.Point(59, 208);
            this.emailTextbox.MinimumSize = new System.Drawing.Size(0, 20);
            this.emailTextbox.Multiline = false;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextbox.PasswordChar = false;
            this.emailTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.emailTextbox.PlaceholderText = "";
            this.emailTextbox.Size = new System.Drawing.Size(250, 30);
            this.emailTextbox.TabIndex = 3;
            this.emailTextbox.Texts = "";
            this.emailTextbox.UnderlinedStyle = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(55, 172);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 19);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.White;
            this.passwordTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.passwordTextbox.BorderSize = 1;
            this.passwordTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.passwordTextbox.Location = new System.Drawing.Point(345, 74);
            this.passwordTextbox.MinimumSize = new System.Drawing.Size(0, 20);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextbox.PasswordChar = true;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.passwordTextbox.PlaceholderText = "";
            this.passwordTextbox.Size = new System.Drawing.Size(250, 30);
            this.passwordTextbox.TabIndex = 5;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(341, 38);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 19);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Heslo";
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.BackColor = System.Drawing.Color.White;
            this.confirmPasswordTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmPasswordTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.confirmPasswordTextbox.BorderSize = 1;
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(345, 208);
            this.confirmPasswordTextbox.MinimumSize = new System.Drawing.Size(0, 20);
            this.confirmPasswordTextbox.Multiline = false;
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.confirmPasswordTextbox.PasswordChar = true;
            this.confirmPasswordTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextbox.PlaceholderText = "";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(250, 30);
            this.confirmPasswordTextbox.TabIndex = 7;
            this.confirmPasswordTextbox.Texts = "";
            this.confirmPasswordTextbox.UnderlinedStyle = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(341, 172);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(119, 19);
            this.confirmPasswordLabel.TabIndex = 6;
            this.confirmPasswordLabel.Text = "Zopakujte heslo";
            // 
            // classCombobox
            // 
            this.classCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCombobox.FormattingEnabled = true;
            this.classCombobox.Location = new System.Drawing.Point(59, 294);
            this.classCombobox.Name = "classCombobox";
            this.classCombobox.Size = new System.Drawing.Size(132, 27);
            this.classCombobox.TabIndex = 8;
            // 
            // ShowPasswordCheckbox
            // 
            this.ShowPasswordCheckbox.AutoSize = true;
            this.ShowPasswordCheckbox.BackColor = System.Drawing.Color.White;
            this.ShowPasswordCheckbox.Font = new System.Drawing.Font("Cambria", 12F);
            this.ShowPasswordCheckbox.Location = new System.Drawing.Point(345, 268);
            this.ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            this.ShowPasswordCheckbox.Size = new System.Drawing.Size(129, 23);
            this.ShowPasswordCheckbox.TabIndex = 9;
            this.ShowPasswordCheckbox.Text = "Zobraziť heslo";
            this.ShowPasswordCheckbox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.UpdateButton.Location = new System.Drawing.Point(387, 399);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateButton.Size = new System.Drawing.Size(208, 39);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Aktualizovať";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(59, 256);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(53, 19);
            this.classLabel.TabIndex = 17;
            this.classLabel.Text = "Trieda";
            // 
            // UserEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ShowPasswordCheckbox);
            this.Controls.Add(this.classCombobox);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserEditForm";
            this.Text = "UserEditForm";
            this.Load += new System.EventHandler(this.UserEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private CustomComponents.CustomTextbox nameTextbox;
        private CustomComponents.CustomTextbox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private CustomComponents.CustomTextbox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private CustomComponents.CustomTextbox confirmPasswordTextbox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.ComboBox classCombobox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckbox;
        private FontAwesome.Sharp.IconButton UpdateButton;
        private System.Windows.Forms.Label classLabel;
    }
}