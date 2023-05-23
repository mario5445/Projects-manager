namespace ProjectsManager
{
    partial class SettingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.classesDatagridview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trieda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.departmentsDatagridview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddClassBtn = new FontAwesome.Sharp.IconButton();
            this.AddDepartmentBtn = new FontAwesome.Sharp.IconButton();
            this.deleteClassBtn = new FontAwesome.Sharp.IconButton();
            this.deleteDepBtn = new FontAwesome.Sharp.IconButton();
            this.AddDepartmentTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.AddClassTextbox = new ProjectsManager.CustomComponents.CustomTextbox();
            this.deleteAllClsBtn = new FontAwesome.Sharp.IconButton();
            this.deleteAllDepBtn = new FontAwesome.Sharp.IconButton();
            this.deleteAllUsersBtn = new FontAwesome.Sharp.IconButton();
            this.deleteAllProjectsBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.classesDatagridview)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDatagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classesDatagridview
            // 
            this.classesDatagridview.AllowUserToAddRows = false;
            this.classesDatagridview.AllowUserToDeleteRows = false;
            this.classesDatagridview.AllowUserToResizeColumns = false;
            this.classesDatagridview.AllowUserToResizeRows = false;
            this.classesDatagridview.BackgroundColor = System.Drawing.Color.White;
            this.classesDatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classesDatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.classesDatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classesDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.classesDatagridview.ColumnHeadersHeight = 32;
            this.classesDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Trieda});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classesDatagridview.DefaultCellStyle = dataGridViewCellStyle14;
            this.classesDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesDatagridview.EnableHeadersVisualStyles = false;
            this.classesDatagridview.GridColor = System.Drawing.Color.LightGray;
            this.classesDatagridview.Location = new System.Drawing.Point(4, 0);
            this.classesDatagridview.MultiSelect = false;
            this.classesDatagridview.Name = "classesDatagridview";
            this.classesDatagridview.ReadOnly = true;
            this.classesDatagridview.RowHeadersVisible = false;
            this.classesDatagridview.RowHeadersWidth = 25;
            this.classesDatagridview.RowTemplate.Height = 25;
            this.classesDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classesDatagridview.Size = new System.Drawing.Size(190, 379);
            this.classesDatagridview.TabIndex = 0;
            this.classesDatagridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classesDatagridview_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Trieda
            // 
            this.Trieda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trieda.FillWeight = 150F;
            this.Trieda.HeaderText = "Trieda";
            this.Trieda.Name = "Trieda";
            this.Trieda.ReadOnly = true;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.Indigo;
            this.panelDataGridView.Controls.Add(this.classesDatagridview);
            this.panelDataGridView.Location = new System.Drawing.Point(23, 187);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.panelDataGridView.Size = new System.Drawing.Size(198, 391);
            this.panelDataGridView.TabIndex = 3;
            // 
            // departmentsDatagridview
            // 
            this.departmentsDatagridview.AllowUserToAddRows = false;
            this.departmentsDatagridview.AllowUserToDeleteRows = false;
            this.departmentsDatagridview.AllowUserToResizeColumns = false;
            this.departmentsDatagridview.AllowUserToResizeRows = false;
            this.departmentsDatagridview.BackgroundColor = System.Drawing.Color.White;
            this.departmentsDatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmentsDatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.departmentsDatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentsDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.departmentsDatagridview.ColumnHeadersHeight = 32;
            this.departmentsDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.department});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.departmentsDatagridview.DefaultCellStyle = dataGridViewCellStyle16;
            this.departmentsDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentsDatagridview.EnableHeadersVisualStyles = false;
            this.departmentsDatagridview.GridColor = System.Drawing.Color.LightGray;
            this.departmentsDatagridview.Location = new System.Drawing.Point(4, 0);
            this.departmentsDatagridview.MultiSelect = false;
            this.departmentsDatagridview.Name = "departmentsDatagridview";
            this.departmentsDatagridview.ReadOnly = true;
            this.departmentsDatagridview.RowHeadersVisible = false;
            this.departmentsDatagridview.RowHeadersWidth = 25;
            this.departmentsDatagridview.RowTemplate.Height = 25;
            this.departmentsDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentsDatagridview.Size = new System.Drawing.Size(431, 379);
            this.departmentsDatagridview.TabIndex = 0;
            this.departmentsDatagridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsDatagridview_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Odbor";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.departmentsDatagridview);
            this.panel1.Location = new System.Drawing.Point(236, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.panel1.Size = new System.Drawing.Size(439, 391);
            this.panel1.TabIndex = 4;
            // 
            // AddClassBtn
            // 
            this.AddClassBtn.BackColor = System.Drawing.Color.Green;
            this.AddClassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddClassBtn.FlatAppearance.BorderSize = 0;
            this.AddClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClassBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddClassBtn.ForeColor = System.Drawing.Color.White;
            this.AddClassBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.AddClassBtn.IconColor = System.Drawing.Color.White;
            this.AddClassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddClassBtn.IconSize = 30;
            this.AddClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClassBtn.Location = new System.Drawing.Point(27, 67);
            this.AddClassBtn.Name = "AddClassBtn";
            this.AddClassBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddClassBtn.Size = new System.Drawing.Size(194, 38);
            this.AddClassBtn.TabIndex = 15;
            this.AddClassBtn.Text = "Pridať";
            this.AddClassBtn.UseVisualStyleBackColor = false;
            this.AddClassBtn.Click += new System.EventHandler(this.AddClassBtn_Click);
            // 
            // AddDepartmentBtn
            // 
            this.AddDepartmentBtn.BackColor = System.Drawing.Color.Green;
            this.AddDepartmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDepartmentBtn.FlatAppearance.BorderSize = 0;
            this.AddDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDepartmentBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddDepartmentBtn.ForeColor = System.Drawing.Color.White;
            this.AddDepartmentBtn.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.AddDepartmentBtn.IconColor = System.Drawing.Color.White;
            this.AddDepartmentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddDepartmentBtn.IconSize = 30;
            this.AddDepartmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDepartmentBtn.Location = new System.Drawing.Point(329, 67);
            this.AddDepartmentBtn.Name = "AddDepartmentBtn";
            this.AddDepartmentBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddDepartmentBtn.Size = new System.Drawing.Size(346, 38);
            this.AddDepartmentBtn.TabIndex = 17;
            this.AddDepartmentBtn.Text = "Pridať";
            this.AddDepartmentBtn.UseVisualStyleBackColor = false;
            this.AddDepartmentBtn.Click += new System.EventHandler(this.AddDepartmentBtn_Click);
            // 
            // deleteClassBtn
            // 
            this.deleteClassBtn.BackColor = System.Drawing.Color.Red;
            this.deleteClassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClassBtn.FlatAppearance.BorderSize = 0;
            this.deleteClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClassBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteClassBtn.ForeColor = System.Drawing.Color.White;
            this.deleteClassBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteClassBtn.IconColor = System.Drawing.Color.White;
            this.deleteClassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteClassBtn.IconSize = 30;
            this.deleteClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteClassBtn.Location = new System.Drawing.Point(27, 123);
            this.deleteClassBtn.Name = "deleteClassBtn";
            this.deleteClassBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteClassBtn.Size = new System.Drawing.Size(194, 38);
            this.deleteClassBtn.TabIndex = 18;
            this.deleteClassBtn.Text = "Zmazať";
            this.deleteClassBtn.UseVisualStyleBackColor = false;
            this.deleteClassBtn.Click += new System.EventHandler(this.deleteClassBtn_Click);
            // 
            // deleteDepBtn
            // 
            this.deleteDepBtn.BackColor = System.Drawing.Color.Red;
            this.deleteDepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDepBtn.FlatAppearance.BorderSize = 0;
            this.deleteDepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDepBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteDepBtn.ForeColor = System.Drawing.Color.White;
            this.deleteDepBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteDepBtn.IconColor = System.Drawing.Color.White;
            this.deleteDepBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteDepBtn.IconSize = 30;
            this.deleteDepBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDepBtn.Location = new System.Drawing.Point(329, 123);
            this.deleteDepBtn.Name = "deleteDepBtn";
            this.deleteDepBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteDepBtn.Size = new System.Drawing.Size(346, 38);
            this.deleteDepBtn.TabIndex = 19;
            this.deleteDepBtn.Text = "Zmazať";
            this.deleteDepBtn.UseVisualStyleBackColor = false;
            // 
            // AddDepartmentTextbox
            // 
            this.AddDepartmentTextbox.BackColor = System.Drawing.Color.White;
            this.AddDepartmentTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.AddDepartmentTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.AddDepartmentTextbox.BorderSize = 1;
            this.AddDepartmentTextbox.Font = new System.Drawing.Font("Cambria", 12F);
            this.AddDepartmentTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.AddDepartmentTextbox.Location = new System.Drawing.Point(329, 13);
            this.AddDepartmentTextbox.MinimumSize = new System.Drawing.Size(0, 20);
            this.AddDepartmentTextbox.Multiline = false;
            this.AddDepartmentTextbox.Name = "AddDepartmentTextbox";
            this.AddDepartmentTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.AddDepartmentTextbox.PasswordChar = false;
            this.AddDepartmentTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.AddDepartmentTextbox.PlaceholderText = "Nový odbor";
            this.AddDepartmentTextbox.Size = new System.Drawing.Size(346, 33);
            this.AddDepartmentTextbox.TabIndex = 16;
            this.AddDepartmentTextbox.Texts = "";
            this.AddDepartmentTextbox.UnderlinedStyle = true;
            // 
            // AddClassTextbox
            // 
            this.AddClassTextbox.BackColor = System.Drawing.Color.White;
            this.AddClassTextbox.BorderColor = System.Drawing.Color.DarkGray;
            this.AddClassTextbox.BorderFocusColor = System.Drawing.Color.Indigo;
            this.AddClassTextbox.BorderSize = 1;
            this.AddClassTextbox.Font = new System.Drawing.Font("Cambria", 12F);
            this.AddClassTextbox.ForeColor = System.Drawing.Color.Indigo;
            this.AddClassTextbox.Location = new System.Drawing.Point(27, 13);
            this.AddClassTextbox.MinimumSize = new System.Drawing.Size(0, 20);
            this.AddClassTextbox.Multiline = false;
            this.AddClassTextbox.Name = "AddClassTextbox";
            this.AddClassTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.AddClassTextbox.PasswordChar = false;
            this.AddClassTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.AddClassTextbox.PlaceholderText = "Nová trieda";
            this.AddClassTextbox.Size = new System.Drawing.Size(194, 33);
            this.AddClassTextbox.TabIndex = 5;
            this.AddClassTextbox.Texts = "";
            this.AddClassTextbox.UnderlinedStyle = true;
            // 
            // deleteAllClsBtn
            // 
            this.deleteAllClsBtn.BackColor = System.Drawing.Color.Maroon;
            this.deleteAllClsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllClsBtn.FlatAppearance.BorderSize = 0;
            this.deleteAllClsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllClsBtn.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.deleteAllClsBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllClsBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.deleteAllClsBtn.IconColor = System.Drawing.Color.White;
            this.deleteAllClsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteAllClsBtn.IconSize = 25;
            this.deleteAllClsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllClsBtn.Location = new System.Drawing.Point(678, 187);
            this.deleteAllClsBtn.Name = "deleteAllClsBtn";
            this.deleteAllClsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteAllClsBtn.Size = new System.Drawing.Size(270, 38);
            this.deleteAllClsBtn.TabIndex = 20;
            this.deleteAllClsBtn.Text = "Vymazať všetky triedy";
            this.deleteAllClsBtn.UseVisualStyleBackColor = false;
            this.deleteAllClsBtn.Click += new System.EventHandler(this.deleteAllClsBtn_Click);
            // 
            // deleteAllDepBtn
            // 
            this.deleteAllDepBtn.BackColor = System.Drawing.Color.Maroon;
            this.deleteAllDepBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllDepBtn.FlatAppearance.BorderSize = 0;
            this.deleteAllDepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllDepBtn.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.deleteAllDepBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllDepBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.deleteAllDepBtn.IconColor = System.Drawing.Color.White;
            this.deleteAllDepBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteAllDepBtn.IconSize = 25;
            this.deleteAllDepBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllDepBtn.Location = new System.Drawing.Point(678, 267);
            this.deleteAllDepBtn.Name = "deleteAllDepBtn";
            this.deleteAllDepBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteAllDepBtn.Size = new System.Drawing.Size(270, 38);
            this.deleteAllDepBtn.TabIndex = 21;
            this.deleteAllDepBtn.Text = "Vymazať všetky odbory";
            this.deleteAllDepBtn.UseVisualStyleBackColor = false;
            this.deleteAllDepBtn.Click += new System.EventHandler(this.deleteAllDepBtn_Click);
            // 
            // deleteAllUsersBtn
            // 
            this.deleteAllUsersBtn.BackColor = System.Drawing.Color.Maroon;
            this.deleteAllUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllUsersBtn.FlatAppearance.BorderSize = 0;
            this.deleteAllUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllUsersBtn.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.deleteAllUsersBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllUsersBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.deleteAllUsersBtn.IconColor = System.Drawing.Color.White;
            this.deleteAllUsersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteAllUsersBtn.IconSize = 25;
            this.deleteAllUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllUsersBtn.Location = new System.Drawing.Point(677, 350);
            this.deleteAllUsersBtn.Name = "deleteAllUsersBtn";
            this.deleteAllUsersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteAllUsersBtn.Size = new System.Drawing.Size(270, 55);
            this.deleteAllUsersBtn.TabIndex = 22;
            this.deleteAllUsersBtn.Text = "Vymazať všetkých užívateľov";
            this.deleteAllUsersBtn.UseVisualStyleBackColor = false;
            this.deleteAllUsersBtn.Click += new System.EventHandler(this.deleteAllUsersBtn_Click);
            // 
            // deleteAllProjectsBtn
            // 
            this.deleteAllProjectsBtn.BackColor = System.Drawing.Color.Maroon;
            this.deleteAllProjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllProjectsBtn.FlatAppearance.BorderSize = 0;
            this.deleteAllProjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllProjectsBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.deleteAllProjectsBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllProjectsBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.deleteAllProjectsBtn.IconColor = System.Drawing.Color.White;
            this.deleteAllProjectsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteAllProjectsBtn.IconSize = 25;
            this.deleteAllProjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteAllProjectsBtn.Location = new System.Drawing.Point(678, 446);
            this.deleteAllProjectsBtn.Name = "deleteAllProjectsBtn";
            this.deleteAllProjectsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteAllProjectsBtn.Size = new System.Drawing.Size(270, 38);
            this.deleteAllProjectsBtn.TabIndex = 23;
            this.deleteAllProjectsBtn.Text = "Vymazať všetky projekty";
            this.deleteAllProjectsBtn.UseVisualStyleBackColor = false;
            this.deleteAllProjectsBtn.Click += new System.EventHandler(this.deleteAllProjectsBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.deleteAllProjectsBtn);
            this.Controls.Add(this.deleteAllUsersBtn);
            this.Controls.Add(this.deleteAllDepBtn);
            this.Controls.Add(this.deleteAllClsBtn);
            this.Controls.Add(this.deleteDepBtn);
            this.Controls.Add(this.deleteClassBtn);
            this.Controls.Add(this.AddDepartmentBtn);
            this.Controls.Add(this.AddDepartmentTextbox);
            this.Controls.Add(this.AddClassBtn);
            this.Controls.Add(this.AddClassTextbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDataGridView);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.classesDatagridview)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDatagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView classesDatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trieda;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView departmentsDatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomTextbox AddClassTextbox;
        private FontAwesome.Sharp.IconButton AddClassBtn;
        private FontAwesome.Sharp.IconButton AddDepartmentBtn;
        private CustomComponents.CustomTextbox AddDepartmentTextbox;
        private FontAwesome.Sharp.IconButton deleteClassBtn;
        private FontAwesome.Sharp.IconButton deleteDepBtn;
        private FontAwesome.Sharp.IconButton deleteAllClsBtn;
        private FontAwesome.Sharp.IconButton deleteAllDepBtn;
        private FontAwesome.Sharp.IconButton deleteAllUsersBtn;
        private FontAwesome.Sharp.IconButton deleteAllProjectsBtn;
    }
}