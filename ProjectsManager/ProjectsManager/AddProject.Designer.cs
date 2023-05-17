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
            this.DescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.AddButton = new FontAwesome.Sharp.IconButton();
            this.NameTextBox = new ProjectsManager.CustomComponents.CustomTextbox();
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
            // DescriptionRTB
            // 
            this.DescriptionRTB.AutoWordSelection = true;
            this.DescriptionRTB.BackColor = System.Drawing.Color.White;
            this.DescriptionRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionRTB.Location = new System.Drawing.Point(459, 157);
            this.DescriptionRTB.Name = "DescriptionRTB";
            this.DescriptionRTB.Size = new System.Drawing.Size(437, 331);
            this.DescriptionRTB.TabIndex = 3;
            this.DescriptionRTB.Text = "";
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
            // departmentCombobox
            // 
            this.departmentCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Location = new System.Drawing.Point(80, 258);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(324, 27);
            this.departmentCombobox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.Color.Green;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.AddButton.IconColor = System.Drawing.Color.White;
            this.AddButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddButton.IconSize = 30;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(80, 449);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddButton.Size = new System.Drawing.Size(232, 39);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Pridať";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.NameTextBox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.NameTextBox.BorderSize = 1;
            this.NameTextBox.ForeColor = System.Drawing.Color.Indigo;
            this.NameTextBox.Location = new System.Drawing.Point(80, 157);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(0, 20);
            this.NameTextBox.Multiline = false;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NameTextBox.PasswordChar = false;
            this.NameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.NameTextBox.PlaceholderText = "Názov";
            this.NameTextBox.Size = new System.Drawing.Size(324, 30);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Texts = "";
            this.NameTextBox.UnderlinedStyle = false;
            this.NameTextBox._TextChanged += new System.EventHandler(this.customTextbox1__TextChanged);
            // 
            // AddProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.departmentCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionRTB);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextbox NameTextBox;
        private System.Windows.Forms.RichTextBox DescriptionRTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private FontAwesome.Sharp.IconButton AddButton;
    }
}