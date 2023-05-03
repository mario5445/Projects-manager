namespace ProjectsManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.emailTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TextLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 450);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 150;
            this.iconPictureBox1.Location = new System.Drawing.Point(106, 44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(49, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 56);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Registrovať sa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextLabel.ForeColor = System.Drawing.Color.White;
            this.TextLabel.Location = new System.Drawing.Point(12, 197);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(352, 64);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Vitajte v systéme na správu \r\nročníkových projektov!";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Cambria", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Indigo;
            this.LoginLabel.Location = new System.Drawing.Point(486, 42);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Padding = new System.Windows.Forms.Padding(3);
            this.LoginLabel.Size = new System.Drawing.Size(201, 85);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Indigo;
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(78, 331);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(264, 56);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Prihlásiť";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(389, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 27);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Zobraziť heslo";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(388, 123);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 19);
            this.errorLabel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signInBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(375, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 450);
            this.panel2.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.White;
            this.passwordTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.passwordTextbox.BorderSize = 1;
            this.passwordTextbox.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.passwordTextbox.Location = new System.Drawing.Point(388, 226);
            this.passwordTextbox.MinimumSize = new System.Drawing.Size(0, 22);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextbox.PasswordChar = true;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.passwordTextbox.PlaceholderText = "Heslo";
            this.passwordTextbox.Size = new System.Drawing.Size(388, 35);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = false;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.Color.White;
            this.emailTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.emailTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.emailTextbox.BorderSize = 1;
            this.emailTextbox.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.emailTextbox.Location = new System.Drawing.Point(388, 157);
            this.emailTextbox.MinimumSize = new System.Drawing.Size(0, 22);
            this.emailTextbox.Multiline = false;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.emailTextbox.PasswordChar = false;
            this.emailTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.emailTextbox.PlaceholderText = "Email";
            this.emailTextbox.Size = new System.Drawing.Size(388, 35);
            this.emailTextbox.TabIndex = 0;
            this.emailTextbox.Texts = "";
            this.emailTextbox.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label errorLabel;
        private CustomComponents.CustomTextbox emailTextbox;
        private CustomComponents.CustomTextbox passwordTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

