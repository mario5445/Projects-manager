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
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.maindatagridview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maindatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 100);
            this.panel1.TabIndex = 1;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.panelDataGridView.Controls.Add(this.maindatagridview);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(10, 110);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.panelDataGridView.Size = new System.Drawing.Size(899, 439);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.maindatagridview.ColumnHeadersHeight = 30;
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
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
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
            this.maindatagridview.Size = new System.Drawing.Size(891, 427);
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
            this.student_class.FillWeight = 50F;
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
            // Prehlad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 559);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prehlad";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Prehlad";
            this.Load += new System.EventHandler(this.Prehlad_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maindatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView maindatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}