namespace ProjectsManager
{
    partial class UsersDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.maindatagridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusCombobox = new System.Windows.Forms.ComboBox();
            this.deleteClassBtn = new FontAwesome.Sharp.IconButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.userSearch = new ProjectsManager.CustomComponents.CustomTextbox();
            this.classCombobox = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maindatagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.Indigo;
            this.panelDataGridView.Controls.Add(this.maindatagridview);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(10, 144);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.panelDataGridView.Size = new System.Drawing.Size(941, 445);
            this.panelDataGridView.TabIndex = 4;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.maindatagridview.ColumnHeadersHeight = 32;
            this.maindatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.student_class,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maindatagridview.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.maindatagridview.Size = new System.Drawing.Size(933, 433);
            this.maindatagridview.TabIndex = 0;
            this.maindatagridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maindatagridview_CellDoubleClick);
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
            this.name.HeaderText = "Meno";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // student_class
            // 
            this.student_class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_class.FillWeight = 70F;
            this.student_class.HeaderText = "Trieda";
            this.student_class.Name = "student_class";
            this.student_class.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.FillWeight = 90F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusCombobox);
            this.panel1.Controls.Add(this.deleteClassBtn);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.userSearch);
            this.panel1.Controls.Add(this.classCombobox);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 134);
            this.panel1.TabIndex = 3;
            // 
            // statusCombobox
            // 
            this.statusCombobox.AllowDrop = true;
            this.statusCombobox.BackColor = System.Drawing.Color.White;
            this.statusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.statusCombobox.FormattingEnabled = true;
            this.statusCombobox.Location = new System.Drawing.Point(404, 20);
            this.statusCombobox.Name = "statusCombobox";
            this.statusCombobox.Size = new System.Drawing.Size(159, 27);
            this.statusCombobox.TabIndex = 20;
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
            this.deleteClassBtn.Location = new System.Drawing.Point(4, 89);
            this.deleteClassBtn.Name = "deleteClassBtn";
            this.deleteClassBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteClassBtn.Size = new System.Drawing.Size(194, 39);
            this.deleteClassBtn.TabIndex = 19;
            this.deleteClassBtn.Text = "Zmazať";
            this.deleteClassBtn.UseVisualStyleBackColor = false;
            this.deleteClassBtn.Click += new System.EventHandler(this.deleteClassBtn_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Green;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(773, 89);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(164, 39);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Exportovať";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(603, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 39);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Obnoviť";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.Color.White;
            this.userSearch.BorderColor = System.Drawing.Color.LightGray;
            this.userSearch.BorderFocusColor = System.Drawing.Color.Indigo;
            this.userSearch.BorderSize = 1;
            this.userSearch.Font = new System.Drawing.Font("Cambria", 12F);
            this.userSearch.ForeColor = System.Drawing.Color.Indigo;
            this.userSearch.Location = new System.Drawing.Point(4, 14);
            this.userSearch.MinimumSize = new System.Drawing.Size(0, 20);
            this.userSearch.Multiline = false;
            this.userSearch.Name = "userSearch";
            this.userSearch.Padding = new System.Windows.Forms.Padding(7);
            this.userSearch.PasswordChar = false;
            this.userSearch.PlaceholderColor = System.Drawing.Color.Gray;
            this.userSearch.PlaceholderText = "Meno užívateľa";
            this.userSearch.Size = new System.Drawing.Size(250, 33);
            this.userSearch.TabIndex = 6;
            this.userSearch.Texts = "";
            this.userSearch.UnderlinedStyle = true;
            // 
            // classCombobox
            // 
            this.classCombobox.AllowDrop = true;
            this.classCombobox.BackColor = System.Drawing.Color.White;
            this.classCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCombobox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classCombobox.ForeColor = System.Drawing.Color.Indigo;
            this.classCombobox.FormattingEnabled = true;
            this.classCombobox.Location = new System.Drawing.Point(277, 20);
            this.classCombobox.Name = "classCombobox";
            this.classCombobox.Size = new System.Drawing.Size(121, 27);
            this.classCombobox.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(433, 89);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(164, 39);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrovať";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // UsersDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersDashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "UsersDashboard";
            this.Load += new System.EventHandler(this.UsersDashboard_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maindatagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView maindatagridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private CustomComponents.CustomTextbox userSearch;
        private System.Windows.Forms.ComboBox classCombobox;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private FontAwesome.Sharp.IconButton deleteClassBtn;
        private System.Windows.Forms.ComboBox statusCombobox;
    }
}