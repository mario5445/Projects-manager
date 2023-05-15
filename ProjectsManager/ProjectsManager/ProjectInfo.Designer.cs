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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.denyButton = new FontAwesome.Sharp.IconButton();
            this.approveButton = new FontAwesome.Sharp.IconButton();
            this.panelName = new System.Windows.Forms.Panel();
            this.projectNameTxtbox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ZapisatButton = new FontAwesome.Sharp.IconButton();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionRtb = new System.Windows.Forms.RichTextBox();
            this.KonzultantLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.consultations = new System.Windows.Forms.TabControl();
            this.consultationFirst = new System.Windows.Forms.TabPage();
            this.addFirstConsultationBtn = new FontAwesome.Sharp.IconButton();
            this.firstConsultationRtb = new System.Windows.Forms.RichTextBox();
            this.consultationSecond = new System.Windows.Forms.TabPage();
            this.addSecondConsultationBtn = new FontAwesome.Sharp.IconButton();
            this.secondConsultationRtb = new System.Windows.Forms.RichTextBox();
            this.consultationThird = new System.Windows.Forms.TabPage();
            this.addThirdConsultationBtn = new FontAwesome.Sharp.IconButton();
            this.thirdConsultationRtb = new System.Windows.Forms.RichTextBox();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelName.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.consultations.SuspendLayout();
            this.consultationFirst.SuspendLayout();
            this.consultationSecond.SuspendLayout();
            this.consultationThird.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.denyButton);
            this.panel1.Controls.Add(this.approveButton);
            this.panel1.Controls.Add(this.panelName);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.ZapisatButton);
            this.panel1.Controls.Add(this.descriptionPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 209);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // denyButton
            // 
            this.denyButton.BackColor = System.Drawing.Color.OrangeRed;
            this.denyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.denyButton.Enabled = false;
            this.denyButton.FlatAppearance.BorderSize = 0;
            this.denyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denyButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.denyButton.ForeColor = System.Drawing.Color.White;
            this.denyButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.denyButton.IconColor = System.Drawing.Color.White;
            this.denyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.denyButton.IconSize = 30;
            this.denyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.denyButton.Location = new System.Drawing.Point(728, 157);
            this.denyButton.Name = "denyButton";
            this.denyButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.denyButton.Size = new System.Drawing.Size(172, 39);
            this.denyButton.TabIndex = 17;
            this.denyButton.Text = "Zamietnuť";
            this.denyButton.UseVisualStyleBackColor = false;
            this.denyButton.Visible = false;
            this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.Green;
            this.approveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approveButton.Enabled = false;
            this.approveButton.FlatAppearance.BorderSize = 0;
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.approveButton.IconColor = System.Drawing.Color.White;
            this.approveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.approveButton.IconSize = 30;
            this.approveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approveButton.Location = new System.Drawing.Point(728, 112);
            this.approveButton.Name = "approveButton";
            this.approveButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.approveButton.Size = new System.Drawing.Size(172, 39);
            this.approveButton.TabIndex = 16;
            this.approveButton.Text = "Schváliť";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Visible = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.projectNameTxtbox);
            this.panelName.Font = new System.Drawing.Font("Cambria", 24.75F);
            this.panelName.Location = new System.Drawing.Point(25, 14);
            this.panelName.Name = "panelName";
            this.panelName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelName.Size = new System.Drawing.Size(697, 39);
            this.panelName.TabIndex = 15;
            // 
            // projectNameTxtbox
            // 
            this.projectNameTxtbox.BackColor = System.Drawing.Color.Indigo;
            this.projectNameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectNameTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectNameTxtbox.Font = new System.Drawing.Font("Cambria", 24.75F);
            this.projectNameTxtbox.ForeColor = System.Drawing.Color.White;
            this.projectNameTxtbox.Location = new System.Drawing.Point(5, 0);
            this.projectNameTxtbox.Name = "projectNameTxtbox";
            this.projectNameTxtbox.ReadOnly = true;
            this.projectNameTxtbox.Size = new System.Drawing.Size(692, 39);
            this.projectNameTxtbox.TabIndex = 15;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.StatusLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(728, 68);
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
            this.ZapisatButton.Location = new System.Drawing.Point(728, 14);
            this.ZapisatButton.Name = "ZapisatButton";
            this.ZapisatButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ZapisatButton.Size = new System.Drawing.Size(172, 39);
            this.ZapisatButton.TabIndex = 13;
            this.ZapisatButton.Text = "Zapísať sa";
            this.ZapisatButton.UseVisualStyleBackColor = false;
            this.ZapisatButton.Click += new System.EventHandler(this.ZapisatButton_Click);
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
            this.descriptionRtb.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            // KonzultantLabel
            // 
            this.KonzultantLabel.AutoSize = true;
            this.KonzultantLabel.Font = new System.Drawing.Font("Cambria", 10F);
            this.KonzultantLabel.ForeColor = System.Drawing.Color.Indigo;
            this.KonzultantLabel.Location = new System.Drawing.Point(22, 228);
            this.KonzultantLabel.Name = "KonzultantLabel";
            this.KonzultantLabel.Size = new System.Drawing.Size(81, 16);
            this.KonzultantLabel.TabIndex = 10;
            this.KonzultantLabel.Text = "Konzultant: ";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Cambria", 10F);
            this.StudentLabel.ForeColor = System.Drawing.Color.Indigo;
            this.StudentLabel.Location = new System.Drawing.Point(22, 271);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(100, 16);
            this.StudentLabel.TabIndex = 11;
            this.StudentLabel.Text = "Pridelený žiak: ";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Cambria", 10F);
            this.departmentLabel.ForeColor = System.Drawing.Color.Indigo;
            this.departmentLabel.Location = new System.Drawing.Point(22, 313);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(52, 16);
            this.departmentLabel.TabIndex = 12;
            this.departmentLabel.Text = "Odbor: ";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Green;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.EditButton.IconColor = System.Drawing.Color.White;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 30;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(20, 25);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EditButton.Size = new System.Drawing.Size(181, 48);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Upraviť";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteButton.IconColor = System.Drawing.Color.White;
            this.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteButton.IconSize = 30;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(213, 25);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeleteButton.Size = new System.Drawing.Size(184, 48);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Zmazať";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.EditButton);
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 25, 10, 25);
            this.panel2.Size = new System.Drawing.Size(407, 98);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.consultations);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(438, 209);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(488, 341);
            this.panel3.TabIndex = 17;
            // 
            // consultations
            // 
            this.consultations.Controls.Add(this.consultationFirst);
            this.consultations.Controls.Add(this.consultationSecond);
            this.consultations.Controls.Add(this.consultationThird);
            this.consultations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultations.Location = new System.Drawing.Point(5, 5);
            this.consultations.Name = "consultations";
            this.consultations.SelectedIndex = 0;
            this.consultations.Size = new System.Drawing.Size(478, 331);
            this.consultations.TabIndex = 0;
            // 
            // consultationFirst
            // 
            this.consultationFirst.Controls.Add(this.addFirstConsultationBtn);
            this.consultationFirst.Controls.Add(this.firstConsultationRtb);
            this.consultationFirst.Font = new System.Drawing.Font("Cambria", 12F);
            this.consultationFirst.Location = new System.Drawing.Point(4, 24);
            this.consultationFirst.Name = "consultationFirst";
            this.consultationFirst.Padding = new System.Windows.Forms.Padding(3);
            this.consultationFirst.Size = new System.Drawing.Size(470, 303);
            this.consultationFirst.TabIndex = 0;
            this.consultationFirst.Text = "Prvá konzultácia";
            this.consultationFirst.UseVisualStyleBackColor = true;
            // 
            // addFirstConsultationBtn
            // 
            this.addFirstConsultationBtn.BackColor = System.Drawing.Color.Green;
            this.addFirstConsultationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFirstConsultationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addFirstConsultationBtn.Enabled = false;
            this.addFirstConsultationBtn.FlatAppearance.BorderSize = 0;
            this.addFirstConsultationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFirstConsultationBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFirstConsultationBtn.ForeColor = System.Drawing.Color.White;
            this.addFirstConsultationBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addFirstConsultationBtn.IconColor = System.Drawing.Color.White;
            this.addFirstConsultationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addFirstConsultationBtn.IconSize = 30;
            this.addFirstConsultationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addFirstConsultationBtn.Location = new System.Drawing.Point(3, 261);
            this.addFirstConsultationBtn.Name = "addFirstConsultationBtn";
            this.addFirstConsultationBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addFirstConsultationBtn.Size = new System.Drawing.Size(464, 39);
            this.addFirstConsultationBtn.TabIndex = 15;
            this.addFirstConsultationBtn.Text = "Pridať konzultáciu";
            this.addFirstConsultationBtn.UseVisualStyleBackColor = false;
            this.addFirstConsultationBtn.Visible = false;
            this.addFirstConsultationBtn.Click += new System.EventHandler(this.addFirstConsultationBtn_Click);
            // 
            // firstConsultationRtb
            // 
            this.firstConsultationRtb.BackColor = System.Drawing.Color.White;
            this.firstConsultationRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstConsultationRtb.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstConsultationRtb.ForeColor = System.Drawing.Color.Indigo;
            this.firstConsultationRtb.Location = new System.Drawing.Point(3, 3);
            this.firstConsultationRtb.Name = "firstConsultationRtb";
            this.firstConsultationRtb.ReadOnly = true;
            this.firstConsultationRtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.firstConsultationRtb.Size = new System.Drawing.Size(464, 255);
            this.firstConsultationRtb.TabIndex = 0;
            this.firstConsultationRtb.Text = "";
            // 
            // consultationSecond
            // 
            this.consultationSecond.Controls.Add(this.addSecondConsultationBtn);
            this.consultationSecond.Controls.Add(this.secondConsultationRtb);
            this.consultationSecond.Location = new System.Drawing.Point(4, 22);
            this.consultationSecond.Name = "consultationSecond";
            this.consultationSecond.Padding = new System.Windows.Forms.Padding(3);
            this.consultationSecond.Size = new System.Drawing.Size(470, 305);
            this.consultationSecond.TabIndex = 1;
            this.consultationSecond.Text = "Druhá konzultácia";
            this.consultationSecond.UseVisualStyleBackColor = true;
            // 
            // addSecondConsultationBtn
            // 
            this.addSecondConsultationBtn.BackColor = System.Drawing.Color.Green;
            this.addSecondConsultationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSecondConsultationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addSecondConsultationBtn.Enabled = false;
            this.addSecondConsultationBtn.FlatAppearance.BorderSize = 0;
            this.addSecondConsultationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSecondConsultationBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addSecondConsultationBtn.ForeColor = System.Drawing.Color.White;
            this.addSecondConsultationBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addSecondConsultationBtn.IconColor = System.Drawing.Color.White;
            this.addSecondConsultationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addSecondConsultationBtn.IconSize = 30;
            this.addSecondConsultationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSecondConsultationBtn.Location = new System.Drawing.Point(3, 263);
            this.addSecondConsultationBtn.Name = "addSecondConsultationBtn";
            this.addSecondConsultationBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addSecondConsultationBtn.Size = new System.Drawing.Size(464, 39);
            this.addSecondConsultationBtn.TabIndex = 17;
            this.addSecondConsultationBtn.Text = "Pridať konzultáciu";
            this.addSecondConsultationBtn.UseVisualStyleBackColor = false;
            this.addSecondConsultationBtn.Visible = false;
            this.addSecondConsultationBtn.Click += new System.EventHandler(this.addSecondConsultationBtn_Click);
            // 
            // secondConsultationRtb
            // 
            this.secondConsultationRtb.BackColor = System.Drawing.Color.White;
            this.secondConsultationRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondConsultationRtb.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondConsultationRtb.Font = new System.Drawing.Font("Cambria", 12F);
            this.secondConsultationRtb.ForeColor = System.Drawing.Color.Indigo;
            this.secondConsultationRtb.Location = new System.Drawing.Point(3, 3);
            this.secondConsultationRtb.Name = "secondConsultationRtb";
            this.secondConsultationRtb.ReadOnly = true;
            this.secondConsultationRtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.secondConsultationRtb.Size = new System.Drawing.Size(464, 255);
            this.secondConsultationRtb.TabIndex = 16;
            this.secondConsultationRtb.Text = "";
            // 
            // consultationThird
            // 
            this.consultationThird.Controls.Add(this.addThirdConsultationBtn);
            this.consultationThird.Controls.Add(this.thirdConsultationRtb);
            this.consultationThird.Location = new System.Drawing.Point(4, 22);
            this.consultationThird.Name = "consultationThird";
            this.consultationThird.Padding = new System.Windows.Forms.Padding(3);
            this.consultationThird.Size = new System.Drawing.Size(470, 305);
            this.consultationThird.TabIndex = 2;
            this.consultationThird.Text = "Tretia konzultácia";
            this.consultationThird.UseVisualStyleBackColor = true;
            // 
            // addThirdConsultationBtn
            // 
            this.addThirdConsultationBtn.BackColor = System.Drawing.Color.Green;
            this.addThirdConsultationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addThirdConsultationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addThirdConsultationBtn.Enabled = false;
            this.addThirdConsultationBtn.FlatAppearance.BorderSize = 0;
            this.addThirdConsultationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addThirdConsultationBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addThirdConsultationBtn.ForeColor = System.Drawing.Color.White;
            this.addThirdConsultationBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addThirdConsultationBtn.IconColor = System.Drawing.Color.White;
            this.addThirdConsultationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addThirdConsultationBtn.IconSize = 30;
            this.addThirdConsultationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addThirdConsultationBtn.Location = new System.Drawing.Point(3, 263);
            this.addThirdConsultationBtn.Name = "addThirdConsultationBtn";
            this.addThirdConsultationBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addThirdConsultationBtn.Size = new System.Drawing.Size(464, 39);
            this.addThirdConsultationBtn.TabIndex = 19;
            this.addThirdConsultationBtn.Text = "Pridať konzultáciu";
            this.addThirdConsultationBtn.UseVisualStyleBackColor = false;
            this.addThirdConsultationBtn.Visible = false;
            this.addThirdConsultationBtn.Click += new System.EventHandler(this.addThirdConsultationBtn_Click);
            // 
            // thirdConsultationRtb
            // 
            this.thirdConsultationRtb.BackColor = System.Drawing.Color.White;
            this.thirdConsultationRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdConsultationRtb.Dock = System.Windows.Forms.DockStyle.Top;
            this.thirdConsultationRtb.Font = new System.Drawing.Font("Cambria", 12F);
            this.thirdConsultationRtb.ForeColor = System.Drawing.Color.Indigo;
            this.thirdConsultationRtb.Location = new System.Drawing.Point(3, 3);
            this.thirdConsultationRtb.Name = "thirdConsultationRtb";
            this.thirdConsultationRtb.ReadOnly = true;
            this.thirdConsultationRtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.thirdConsultationRtb.Size = new System.Drawing.Size(464, 255);
            this.thirdConsultationRtb.TabIndex = 18;
            this.thirdConsultationRtb.Text = "";
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Location = new System.Drawing.Point(25, 341);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(248, 23);
            this.departmentCombobox.TabIndex = 18;
            // 
            // ProjectInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 550);
            this.Controls.Add(this.departmentCombobox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.KonzultantLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectInfo";
            this.Load += new System.EventHandler(this.ProjectInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.consultations.ResumeLayout(false);
            this.consultationFirst.ResumeLayout(false);
            this.consultationSecond.ResumeLayout(false);
            this.consultationThird.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl consultations;
        private System.Windows.Forms.TabPage consultationFirst;
        private System.Windows.Forms.TabPage consultationSecond;
        private System.Windows.Forms.TabPage consultationThird;
        private FontAwesome.Sharp.IconButton addFirstConsultationBtn;
        private System.Windows.Forms.RichTextBox firstConsultationRtb;
        private System.Windows.Forms.TextBox projectNameTxtbox;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.Panel panelName;
        private FontAwesome.Sharp.IconButton addSecondConsultationBtn;
        private System.Windows.Forms.RichTextBox secondConsultationRtb;
        private FontAwesome.Sharp.IconButton addThirdConsultationBtn;
        private System.Windows.Forms.RichTextBox thirdConsultationRtb;
        private FontAwesome.Sharp.IconButton denyButton;
        private FontAwesome.Sharp.IconButton approveButton;
    }
}