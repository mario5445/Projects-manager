namespace ProjectsManager
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numOfClassesLabel = new System.Windows.Forms.Label();
            this.numOfDepartmentsLabel = new System.Windows.Forms.Label();
            this.classesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.departmentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numOfUsersLabel = new System.Windows.Forms.Label();
            this.numOfProjectsLabel = new System.Windows.Forms.Label();
            this.usersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.status_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsChart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 579);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numOfClassesLabel);
            this.panel3.Controls.Add(this.numOfDepartmentsLabel);
            this.panel3.Controls.Add(this.classesChart);
            this.panel3.Controls.Add(this.departmentsChart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(363, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 579);
            this.panel3.TabIndex = 3;
            // 
            // numOfClassesLabel
            // 
            this.numOfClassesLabel.AutoSize = true;
            this.numOfClassesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numOfClassesLabel.Location = new System.Drawing.Point(0, 326);
            this.numOfClassesLabel.Name = "numOfClassesLabel";
            this.numOfClassesLabel.Size = new System.Drawing.Size(72, 15);
            this.numOfClassesLabel.TabIndex = 5;
            this.numOfClassesLabel.Text = "Počet tried: ";
            // 
            // numOfDepartmentsLabel
            // 
            this.numOfDepartmentsLabel.AutoSize = true;
            this.numOfDepartmentsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.numOfDepartmentsLabel.Location = new System.Drawing.Point(0, 302);
            this.numOfDepartmentsLabel.Name = "numOfDepartmentsLabel";
            this.numOfDepartmentsLabel.Size = new System.Drawing.Size(93, 15);
            this.numOfDepartmentsLabel.TabIndex = 4;
            this.numOfDepartmentsLabel.Text = "Počet odborov: ";
            // 
            // classesChart
            // 
            chartArea5.Name = "ChartArea1";
            this.classesChart.ChartAreas.Add(chartArea5);
            this.classesChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend5.Name = "Legend1";
            this.classesChart.Legends.Add(legend5);
            this.classesChart.Location = new System.Drawing.Point(0, 341);
            this.classesChart.Name = "classesChart";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "PocetTried";
            this.classesChart.Series.Add(series5);
            this.classesChart.Size = new System.Drawing.Size(578, 238);
            this.classesChart.TabIndex = 1;
            this.classesChart.Text = "chart1";
            title5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title5.ForeColor = System.Drawing.Color.Indigo;
            title5.Name = "Title1";
            title5.Text = "Počet projektov v jednotlivých triedach";
            this.classesChart.Titles.Add(title5);
            // 
            // departmentsChart
            // 
            chartArea6.Name = "ChartArea1";
            this.departmentsChart.ChartAreas.Add(chartArea6);
            this.departmentsChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend6.Name = "Legend1";
            this.departmentsChart.Legends.Add(legend6);
            this.departmentsChart.Location = new System.Drawing.Point(0, 0);
            this.departmentsChart.Name = "departmentsChart";
            this.departmentsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Počet v odbore";
            this.departmentsChart.Series.Add(series6);
            this.departmentsChart.Size = new System.Drawing.Size(578, 302);
            this.departmentsChart.TabIndex = 0;
            this.departmentsChart.Text = "chart1";
            title6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title6.ForeColor = System.Drawing.Color.Indigo;
            title6.Name = "Title1";
            title6.Text = "Počet projektov v jednotlivých odboroch";
            this.departmentsChart.Titles.Add(title6);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numOfUsersLabel);
            this.panel2.Controls.Add(this.numOfProjectsLabel);
            this.panel2.Controls.Add(this.usersChart);
            this.panel2.Controls.Add(this.status_chart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 579);
            this.panel2.TabIndex = 2;
            // 
            // numOfUsersLabel
            // 
            this.numOfUsersLabel.AutoSize = true;
            this.numOfUsersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numOfUsersLabel.Location = new System.Drawing.Point(0, 326);
            this.numOfUsersLabel.Name = "numOfUsersLabel";
            this.numOfUsersLabel.Size = new System.Drawing.Size(103, 15);
            this.numOfUsersLabel.TabIndex = 3;
            this.numOfUsersLabel.Text = "Počet užívateľov: ";
            // 
            // numOfProjectsLabel
            // 
            this.numOfProjectsLabel.AutoSize = true;
            this.numOfProjectsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.numOfProjectsLabel.Location = new System.Drawing.Point(0, 302);
            this.numOfProjectsLabel.Name = "numOfProjectsLabel";
            this.numOfProjectsLabel.Size = new System.Drawing.Size(99, 15);
            this.numOfProjectsLabel.TabIndex = 2;
            this.numOfProjectsLabel.Text = "Počet projektov: ";
            // 
            // usersChart
            // 
            chartArea7.Name = "ChartArea1";
            this.usersChart.ChartAreas.Add(chartArea7);
            this.usersChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend7.Name = "Legend1";
            this.usersChart.Legends.Add(legend7);
            this.usersChart.Location = new System.Drawing.Point(0, 341);
            this.usersChart.Name = "usersChart";
            this.usersChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "User_roles";
            this.usersChart.Series.Add(series7);
            this.usersChart.Size = new System.Drawing.Size(357, 238);
            this.usersChart.TabIndex = 1;
            this.usersChart.Text = "chart1";
            title7.Font = new System.Drawing.Font("Candara", 12F);
            title7.ForeColor = System.Drawing.Color.Indigo;
            title7.Name = "Title1";
            title7.Text = "Užívatelia";
            this.usersChart.Titles.Add(title7);
            // 
            // status_chart
            // 
            chartArea8.Name = "ChartArea1";
            this.status_chart.ChartAreas.Add(chartArea8);
            this.status_chart.Dock = System.Windows.Forms.DockStyle.Top;
            legend8.Name = "Legend1";
            this.status_chart.Legends.Add(legend8);
            this.status_chart.Location = new System.Drawing.Point(0, 0);
            this.status_chart.Name = "status_chart";
            this.status_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Project_status";
            this.status_chart.Series.Add(series8);
            this.status_chart.Size = new System.Drawing.Size(357, 302);
            this.status_chart.TabIndex = 0;
            this.status_chart.Text = "chart1";
            title8.Font = new System.Drawing.Font("Candara", 12F);
            title8.ForeColor = System.Drawing.Color.Indigo;
            title8.Name = "Title1";
            title8.Text = "Obsadenosť projektov";
            this.status_chart.Titles.Add(title8);
            // 
            // Statistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 599);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart status_chart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart usersChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart departmentsChart;
        private System.Windows.Forms.Label numOfUsersLabel;
        private System.Windows.Forms.Label numOfProjectsLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart classesChart;
        private System.Windows.Forms.Label numOfClassesLabel;
        private System.Windows.Forms.Label numOfDepartmentsLabel;
    }
}