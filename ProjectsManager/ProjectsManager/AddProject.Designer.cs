namespace ProjectsManager
{
    partial class AddProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new FontAwesome.Sharp.IconButton();
            this.customTextbox1 = new ProjectsManager.CustomComponents.CustomTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pridať projekt";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(459, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(437, 331);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(454, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Popis";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Indigo;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 27);
            this.comboBox1.TabIndex = 5;
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
            this.UpdateButton.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.UpdateButton.IconColor = System.Drawing.Color.White;
            this.UpdateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateButton.IconSize = 30;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(80, 449);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateButton.Size = new System.Drawing.Size(232, 39);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Pridať";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // customTextbox1
            // 
            this.customTextbox1.BackColor = System.Drawing.Color.White;
            this.customTextbox1.BorderColor = System.Drawing.Color.DarkGray;
            this.customTextbox1.BorderFocusColor = System.Drawing.Color.Indigo;
            this.customTextbox1.BorderSize = 1;
            this.customTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextbox1.Location = new System.Drawing.Point(80, 148);
            this.customTextbox1.MinimumSize = new System.Drawing.Size(0, 20);
            this.customTextbox1.Multiline = false;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.Padding = new System.Windows.Forms.Padding(7);
            this.customTextbox1.PasswordChar = false;
            this.customTextbox1.PlaceholderColor = System.Drawing.Color.Gray;
            this.customTextbox1.PlaceholderText = "Názov";
            this.customTextbox1.Size = new System.Drawing.Size(324, 30);
            this.customTextbox1.TabIndex = 2;
            this.customTextbox1.Texts = "";
            this.customTextbox1.UnderlinedStyle = false;
            // 
            // AddProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.customTextbox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextbox customTextbox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton UpdateButton;
    }
}