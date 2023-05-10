namespace ProjectsManager
{
    partial class Prehlad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusCombobox = new System.Windows.Forms.ComboBox();
            this.classCombobox = new System.Windows.Forms.ComboBox();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.teacherCombobox = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.maindatagridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSearch = new ProjectsManager.CustomComponents.CustomTextbox();
            this.projectNameSearch = new ProjectsManager.CustomComponents.CustomTextbox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maindatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.studentSearch);
            this.panel1.Controls.Add(this.statusCombobox);
            this.panel1.Controls.Add(this.classCombobox);
            this.panel1.Controls.Add(this.departmentCombobox);
            this.panel1.Controls.Add(this.teacherCombobox);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.projectNameSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 134);
            this.panel1.TabIndex = 1;
            // 
            // statusCombobox
            // 
            this.statusCombobox.AllowDrop = true;
            this.statusCombobox.BackColor = System.Drawing.Color.White;
            this.statusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.statusCombobox.FormattingEnabled = true;
            this.statusCombobox.Items.AddRange(new object[] {
            "Status",
            "Voľné",
            "Obsadené",
            "Čaká na schválenie"});
            this.statusCombobox.Location = new System.Drawing.Point(753, 9);
            this.statusCombobox.Name = "statusCombobox";
            this.statusCombobox.Size = new System.Drawing.Size(174, 27);
            this.statusCombobox.TabIndex = 5;
            // 
            // classCombobox
            // 
            this.classCombobox.AllowDrop = true;
            this.classCombobox.BackColor = System.Drawing.Color.White;
            this.classCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.classCombobox.FormattingEnabled = true;
            this.classCombobox.Location = new System.Drawing.Point(260, 59);
            this.classCombobox.Name = "classCombobox";
            this.classCombobox.Size = new System.Drawing.Size(121, 27);
            this.classCombobox.TabIndex = 4;
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.AllowDrop = true;
            this.departmentCombobox.BackColor = System.Drawing.Color.White;
            this.departmentCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.departmentCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Location = new System.Drawing.Point(473, 9);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(251, 27);
            this.departmentCombobox.TabIndex = 3;
            // 
            // teacherCombobox
            // 
            this.teacherCombobox.AllowDrop = true;
            this.teacherCombobox.BackColor = System.Drawing.Color.White;
            this.teacherCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.teacherCombobox.FormattingEnabled = true;
            this.teacherCombobox.Location = new System.Drawing.Point(260, 9);
            this.teacherCombobox.Name = "teacherCombobox";
            this.teacherCombobox.Size = new System.Drawing.Size(184, 27);
            this.teacherCombobox.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.Yellow;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(427, 89);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(164, 39);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrovať";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.panelDataGridView.Controls.Add(this.maindatagridview);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(10, 144);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.panelDataGridView.Size = new System.Drawing.Size(931, 440);
            this.panelDataGridView.TabIndex = 2;
            // 
            // maindatagridview
            // 
            this.maindatagridview.AllowUserToAddRows = false;
            this.maindatagridview.AllowUserToDeleteRows = false;
            this.maindatagridview.AllowUserToResizeColumns = false;
            this.maindatagridview.AllowUserToResizeRows = false;
            this.maindatagridview.BackgroundColor = System.Drawing.Color.White;
            this.maindatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maindatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.maindatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.maindatagridview.ColumnHeadersHeight = 32;
            this.maindatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.teacher,
            this.student,
            this.student_class,
            this.department,
            this.status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maindatagridview.DefaultCellStyle = dataGridViewCellStyle4;
            this.maindatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maindatagridview.EnableHeadersVisualStyles = false;
            this.maindatagridview.GridColor = System.Drawing.Color.LightGray;
            this.maindatagridview.Location = new System.Drawing.Point(4, 0);
            this.maindatagridview.MultiSelect = false;
            this.maindatagridview.Name = "maindatagridview";
            this.maindatagridview.ReadOnly = true;
            this.maindatagridview.RowHeadersVisible = false;
            this.maindatagridview.RowHeadersWidth = 25;
            this.maindatagridview.RowTemplate.Height = 25;
            this.maindatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maindatagridview.Size = new System.Drawing.Size(923, 428);
            this.maindatagridview.TabIndex = 0;
            this.maindatagridview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.maindatagridview_CellFormatting);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 150F;
            this.name.HeaderText = "Názov";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher.HeaderText = "Konzultant";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // student
            // 
            this.student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student.HeaderText = "Pridelený žiak";
            this.student.Name = "student";
            this.student.ReadOnly = true;
            // 
            // student_class
            // 
            this.student_class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_class.FillWeight = 58F;
            this.student_class.HeaderText = "Trieda";
            this.student_class.Name = "student_class";
            this.student_class.ReadOnly = true;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Odbor";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.FillWeight = 80F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // studentSearch
            // 
            this.studentSearch.BackColor = System.Drawing.Color.White;
            this.studentSearch.BorderColor = System.Drawing.Color.LightGray;
            this.studentSearch.BorderFocusColor = System.Drawing.Color.Indigo;
            this.studentSearch.BorderSize = 1;
            this.studentSearch.Font = new System.Drawing.Font("Cambria", 12F);
            this.studentSearch.ForeColor = System.Drawing.Color.Indigo;
            this.studentSearch.Location = new System.Drawing.Point(4, 53);
            this.studentSearch.MinimumSize = new System.Drawing.Size(0, 20);
            this.studentSearch.Multiline = false;
            this.studentSearch.Name = "studentSearch";
            this.studentSearch.Padding = new System.Windows.Forms.Padding(7);
            this.studentSearch.PasswordChar = false;
            this.studentSearch.PlaceholderColor = System.Drawing.Color.Gray;
            this.studentSearch.PlaceholderText = "Meno študenta";
            this.studentSearch.Size = new System.Drawing.Size(250, 33);
            this.studentSearch.TabIndex = 6;
            this.studentSearch.Texts = "";
            this.studentSearch.UnderlinedStyle = true;
            // 
            // projectNameSearch
            // 
            this.projectNameSearch.BackColor = System.Drawing.Color.White;
            this.projectNameSearch.BorderColor = System.Drawing.Color.LightGray;
            this.projectNameSearch.BorderFocusColor = System.Drawing.Color.Indigo;
            this.projectNameSearch.BorderSize = 1;
            this.projectNameSearch.Font = new System.Drawing.Font("Cambria", 12F);
            this.projectNameSearch.ForeColor = System.Drawing.Color.Indigo;
            this.projectNameSearch.Location = new System.Drawing.Point(4, 3);
            this.projectNameSearch.MinimumSize = new System.Drawing.Size(0, 20);
            this.projectNameSearch.Multiline = false;
            this.projectNameSearch.Name = "projectNameSearch";
            this.projectNameSearch.Padding = new System.Windows.Forms.Padding(7);
            this.projectNameSearch.PasswordChar = false;
            this.projectNameSearch.PlaceholderColor = System.Drawing.Color.Gray;
            this.projectNameSearch.PlaceholderText = "Názov projektu";
            this.projectNameSearch.Size = new System.Drawing.Size(250, 33);
            this.projectNameSearch.TabIndex = 0;
            this.projectNameSearch.Texts = "";
            this.projectNameSearch.UnderlinedStyle = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(597, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 39);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Obnoviť";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Lime;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(767, 89);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(164, 39);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Exportovať";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // Prehlad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 594);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prehlad";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Prehlad";
            this.Load += new System.EventHandler(this.Prehlad_Load);
            this.panel1.ResumeLayout(false);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maindatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView maindatagridview;
        private CustomComponents.CustomTextbox projectNameSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox teacherCombobox;
        private CustomComponents.CustomTextbox studentSearch;
        private System.Windows.Forms.ComboBox statusCombobox;
        private System.Windows.Forms.ComboBox classCombobox;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
    }
}