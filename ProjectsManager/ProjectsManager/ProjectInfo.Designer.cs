namespace ProjectsManager
{
    partial class ProjectInfo
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
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KonzultantLabel = new System.Windows.Forms.Label();
            this.ZiakLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ZapisatButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Cambria", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProjectNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectNameLabel.Location = new System.Drawing.Point(19, 9);
            this.ProjectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(222, 38);
            this.ProjectNameLabel.TabIndex = 6;
            this.ProjectNameLabel.Text = "nazovprojektu";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 68);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(649, 73);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Popis projektu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.ZapisatButton);
            this.panel1.Controls.Add(this.ProjectNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 159);
            this.panel1.TabIndex = 8;
            // 
            // KonzultantLabel
            // 
            this.KonzultantLabel.AutoSize = true;
            this.KonzultantLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KonzultantLabel.ForeColor = System.Drawing.Color.Indigo;
            this.KonzultantLabel.Location = new System.Drawing.Point(22, 182);
            this.KonzultantLabel.Name = "KonzultantLabel";
            this.KonzultantLabel.Size = new System.Drawing.Size(88, 19);
            this.KonzultantLabel.TabIndex = 10;
            this.KonzultantLabel.Text = "Konzultant:";
            // 
            // ZiakLabel
            // 
            this.ZiakLabel.AutoSize = true;
            this.ZiakLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZiakLabel.ForeColor = System.Drawing.Color.Indigo;
            this.ZiakLabel.Location = new System.Drawing.Point(22, 225);
            this.ZiakLabel.Name = "ZiakLabel";
            this.ZiakLabel.Size = new System.Drawing.Size(110, 19);
            this.ZiakLabel.TabIndex = 11;
            this.ZiakLabel.Text = "Pridelený žiak:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(22, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Odbor:";
            // 
            // ZapisatButton
            // 
            this.ZapisatButton.BackColor = System.Drawing.Color.Green;
            this.ZapisatButton.FlatAppearance.BorderSize = 0;
            this.ZapisatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZapisatButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZapisatButton.ForeColor = System.Drawing.Color.White;
            this.ZapisatButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ZapisatButton.IconColor = System.Drawing.Color.Black;
            this.ZapisatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ZapisatButton.Location = new System.Drawing.Point(728, 14);
            this.ZapisatButton.Name = "ZapisatButton";
            this.ZapisatButton.Size = new System.Drawing.Size(164, 39);
            this.ZapisatButton.TabIndex = 13;
            this.ZapisatButton.Text = "Zapísať sa";
            this.ZapisatButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Green;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.EditButton.IconColor = System.Drawing.Color.White;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 30;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(558, 484);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EditButton.Size = new System.Drawing.Size(164, 39);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Upraviť";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteButton.IconColor = System.Drawing.Color.White;
            this.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteButton.IconSize = 30;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(728, 484);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeleteButton.Size = new System.Drawing.Size(164, 39);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Zmazať";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Green;
            this.StatusLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(775, 89);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(64, 22);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 550);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZiakLabel);
            this.Controls.Add(this.KonzultantLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProjectInfo";
            this.Text = "ProjectInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KonzultantLabel;
        private System.Windows.Forms.Label ZiakLabel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ZapisatButton;
        private System.Windows.Forms.Label StatusLabel;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton DeleteButton;
    }
}