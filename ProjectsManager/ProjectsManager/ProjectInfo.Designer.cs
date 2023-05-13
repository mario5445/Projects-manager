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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ZapisatButton = new FontAwesome.Sharp.IconButton();
            this.KonzultantLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionRtb = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.ZapisatButton);
            this.panel1.Controls.Add(this.ProjectNameLabel);
            this.panel1.Controls.Add(this.descriptionPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 209);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.StatusLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(761, 68);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(5);
            this.StatusLabel.Size = new System.Drawing.Size(74, 32);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZapisatButton
            // 
            this.ZapisatButton.BackColor = System.Drawing.Color.Green;
            this.ZapisatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZapisatButton.FlatAppearance.BorderSize = 0;
            this.ZapisatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZapisatButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZapisatButton.ForeColor = System.Drawing.Color.White;
            this.ZapisatButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ZapisatButton.IconColor = System.Drawing.Color.White;
            this.ZapisatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ZapisatButton.IconSize = 30;
            this.ZapisatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZapisatButton.Location = new System.Drawing.Point(720, 14);
            this.ZapisatButton.Name = "ZapisatButton";
            this.ZapisatButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ZapisatButton.Size = new System.Drawing.Size(172, 39);
            this.ZapisatButton.TabIndex = 13;
            this.ZapisatButton.Text = "Zapísať sa";
            this.ZapisatButton.UseVisualStyleBackColor = false;
            // 
            // KonzultantLabel
            // 
            this.KonzultantLabel.AutoSize = true;
            this.KonzultantLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KonzultantLabel.ForeColor = System.Drawing.Color.Indigo;
            this.KonzultantLabel.Location = new System.Drawing.Point(22, 228);
            this.KonzultantLabel.Name = "KonzultantLabel";
            this.KonzultantLabel.Size = new System.Drawing.Size(92, 19);
            this.KonzultantLabel.TabIndex = 10;
            this.KonzultantLabel.Text = "Konzultant: ";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentLabel.ForeColor = System.Drawing.Color.Indigo;
            this.StudentLabel.Location = new System.Drawing.Point(22, 271);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(114, 19);
            this.StudentLabel.TabIndex = 11;
            this.StudentLabel.Text = "Pridelený žiak: ";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.departmentLabel.ForeColor = System.Drawing.Color.Indigo;
            this.departmentLabel.Location = new System.Drawing.Point(22, 313);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(61, 19);
            this.departmentLabel.TabIndex = 12;
            this.departmentLabel.Text = "Odbor: ";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Green;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // descriptionPanel
            // 
            this.descriptionPanel.AutoScroll = true;
            this.descriptionPanel.Controls.Add(this.descriptionRtb);
            this.descriptionPanel.Location = new System.Drawing.Point(26, 68);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Padding = new System.Windows.Forms.Padding(5);
            this.descriptionPanel.Size = new System.Drawing.Size(696, 120);
            this.descriptionPanel.TabIndex = 14;
            // 
            // descriptionRtb
            // 
            this.descriptionRtb.BackColor = System.Drawing.Color.Indigo;
            this.descriptionRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRtb.Font = new System.Drawing.Font("Cambria", 12F);
            this.descriptionRtb.ForeColor = System.Drawing.Color.White;
            this.descriptionRtb.Location = new System.Drawing.Point(5, 5);
            this.descriptionRtb.Name = "descriptionRtb";
            this.descriptionRtb.ReadOnly = true;
            this.descriptionRtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRtb.Size = new System.Drawing.Size(686, 110);
            this.descriptionRtb.TabIndex = 16;
            this.descriptionRtb.Text = "";
            // 
            // ProjectInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 550);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.KonzultantLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProjectInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectInfo";
            this.Load += new System.EventHandler(this.ProjectInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KonzultantLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label departmentLabel;
        private FontAwesome.Sharp.IconButton ZapisatButton;
        private System.Windows.Forms.Label StatusLabel;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton DeleteButton;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.RichTextBox descriptionRtb;
    }
}