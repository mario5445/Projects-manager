using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class Prehlad : Form
    {
        private DatagridviewHandler gridviewHandler;
        #region Constructor
        public Prehlad()
        {
            InitializeComponent();
            gridviewHandler = new DatagridviewHandler();
            StyleDatagridview();
            LoadDefaultDatagridview(gridviewHandler.GetDataReaderOfProjects());
            GetDataForComboboxes();
        }

        #endregion

        #region Events
        private void Prehlad_Load(object sender, EventArgs e)
        {

        }

        private void maindatagridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //maindatagridview.Rows[e.RowIndex].Cells["status"].Style.BackColor = status.ToString() == "Voľné" ? Color.Green : Color.Red;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Styles ForeColor and BackColor of Datagridview based on conditions
        /// </summary>
        private void StyleDatagridview()
        {
            maindatagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 14F, FontStyle.Bold); // nastavenie fontu pre hlavicku
            maindatagridview.DefaultCellStyle.Font = new Font("Cambria", 13F); // nastavenie fontu pre bunky

            foreach (DataGridViewRow row in maindatagridview.Rows)
            {
                var cell_student = row.Cells[3]; // student
                var cell_class = row.Cells[4]; // trieda
                var cell_department = row.Cells[5]; // odbor
                if (string.IsNullOrEmpty(cell_student.Value.ToString()))
                {
                    row.Cells[3].Value = "-"; // nahradenie hodnoty null
                }
                if (string.IsNullOrEmpty(cell_class.Value.ToString()))
                {
                    row.Cells[4].Value = "-"; // nahradenie hodnoty null
                }
                if (string.IsNullOrEmpty(cell_department.Value.ToString()))
                {
                    row.Cells[5].Value = "-"; // nahradenie hodnoty null
                }
                var cell = row.Cells[6]; // status
                cell.Style.ForeColor = Color.White; // nastavenie farby pisma v bunkach stlpca status
                switch (cell.Value.ToString()) 
                {
                    // formatovanie farby bunky na zaklade hodnoty
                    case "Voľné": 
                        cell.Style.BackColor = Color.Green;
                        break;
                    case "Obsadené":
                        cell.Style.BackColor = Color.Red;
                        break;
                    default:
                        cell.Style.BackColor = Color.Orange;
                        break;
                }
            }
        }

        /// <summary>
        /// Loads Datagridview 
        /// </summary>
        /// <param name="reader">Reader to read from</param>
        private void LoadDefaultDatagridview(MySqlDataReader reader)
        {
            maindatagridview.Rows.Clear();
            //maindatagridview.Rows.Clear();
            while (reader.Read()) // citanie 
            {
                int id = reader.GetInt32("id"); // preberanie hodnoty z readeru
                string name = reader.GetString("name");
                string teacher = reader.GetString("teacher");
                string student = !reader.IsDBNull(3) ? reader.GetString("student") : "-";
                string student_class = !reader.IsDBNull(4) ? reader.GetString("student_class") : "-";
                string department = !reader.IsDBNull(5) ? reader.GetString("department") : "-";
                string status = reader.GetString("status");
                maindatagridview.Rows.Add(new object[] { id, name, teacher, student, student_class, department, status }); // pridanie riadku do Datagridview
            }
            reader.Close(); // zatvorenie readeru -> IMPORTANT

        }

        private void FillDatagridview(MySqlDataReader reader)
        {
            maindatagridview.Rows.Clear();
            while (reader.Read()) // citanie 
            {
                int id = reader.GetInt32("id"); // preberanie hodnoty z readeru
                string name = reader.GetString("name");
                string teacher = reader.GetString("teacher");
                string student = reader.GetString("student");
                string student_class = reader.GetString("student_class");
                string department = reader.GetString("department");
                string status = reader.GetString("status");
                maindatagridview.Rows.Add(new object[] { id, name, teacher, student, student_class, department, status }); // pridanie riadku do Datagridview
            }
            reader.Close();
        }

        private void GetTeacherComboboxData()
        {
            teacherCombobox.Items.Add(new ComboItem("Konzultant", 0));
            string teacher_query = "SELECT DISTINCT user_full_name, user_id FROM users WHERE user_role = 'Učiteľ';";
            MySqlCommand cmd = new MySqlCommand(teacher_query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                teacherCombobox.Items.Add(new ComboItem(reader.GetString("user_full_name"), reader.GetInt32("user_id")));
            }
            reader.Close();
            teacherCombobox.SelectedIndex = 0;
        }

        private void GetDepartmentsComboboxData()
        {
            departmentCombobox.Items.Add(new ComboItem("Odbor", 0));
            string departments_query = "SELECT department_id, department_name FROM departments;";
            MySqlCommand cmd = new MySqlCommand(departments_query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                departmentCombobox.Items.Add(new ComboItem(reader.GetString("department_name"), reader.GetInt32("department_id")));
            }
            reader.Close();
            departmentCombobox.SelectedIndex = 0;
        }

        private void GetClassesComboboxData()
        {
            classCombobox.Items.Add(new ComboItem("Trieda", 0));
            string classes_query = "SELECT class_id, class_name FROM classes;";
            MySqlCommand cmd = new MySqlCommand(classes_query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                return;
            }
            while (reader.Read())
            {
                classCombobox.Items.Add(new ComboItem(reader.GetString("class_name"), reader.GetInt32("class_id")));
            }
            reader.Close();
            classCombobox.SelectedIndex = 0;
        }

        private void GetDataForComboboxes()
        {
            GetTeacherComboboxData();
            GetDepartmentsComboboxData();
            GetClassesComboboxData();
            statusCombobox.SelectedIndex = 0;
        }
        #endregion

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int num = 0;
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (projectNameSearch.Texts.Trim() == string.Empty && 
                teacherCombobox.SelectedIndex == 0 && 
                departmentCombobox.SelectedIndex == 0 && 
                statusCombobox.SelectedIndex == 0 && 
                studentSearch.Texts.Trim() == string.Empty &&
                classCombobox.SelectedIndex == 0)
            {
                
                return;
            }
            string project_name = projectNameSearch.Texts.Trim();
            string project_teacher = teacherCombobox.SelectedIndex != 0 ? teacherCombobox.SelectedItem.ToString() : string.Empty;
            string project_department = departmentCombobox.SelectedIndex != 0 ? departmentCombobox.SelectedItem.ToString() : string.Empty;
            string project_status = statusCombobox.SelectedIndex != 0 ? statusCombobox.SelectedItem.ToString() : string.Empty;
            string project_student = studentSearch.Texts.Trim();
            string student_class = classCombobox.SelectedIndex != 0 ? classCombobox.SelectedItem.ToString() : string.Empty;
            string query = gridviewHandler.defaultQuery;
            query += " WHERE ";
            if (!string.IsNullOrEmpty(project_name))
            {
                query += "p.project_name LIKE @Name ";
                parameters.Add(new MySqlParameter("@Name", "%" + project_name + "%"));
                num++;
            }
            if (!string.IsNullOrEmpty(project_teacher))
            {
                if (num > 0)
                {
                    query += "AND ";
                }
                query += "u.user_full_name = @Teacher ";
                parameters.Add(new MySqlParameter("@Teacher", project_teacher));
                num++;
            }
            if (!string.IsNullOrEmpty(project_department))
            {
                if (num > 0)
                {
                    query += "AND ";
                }
                query += "dp.department_name = @Department ";
                parameters.Add(new MySqlParameter("@Department", project_department));
                num++;
            }
            if (!string.IsNullOrEmpty(project_status))
            {
                if (num > 0)
                {
                    query += "AND ";
                }
                query += "p.project_status = @Status ";
                parameters.Add(new MySqlParameter("@Status", project_status));
                num++;
            }
            if (!string.IsNullOrEmpty(project_student))
            {
                if (num > 0)
                {
                    query += "AND ";
                }
                query += "us.user_full_name LIKE @Student ";
                parameters.Add(new MySqlParameter("@Student", "%" + project_student + "%"));
                num++;
            }
            if (!string.IsNullOrEmpty(student_class))
            {
                if (num > 0)
                {
                    query += "AND ";
                }
                query += "us.name_of_class = @Class ";
                parameters.Add(new MySqlParameter("@Class", student_class));
            }
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            foreach (MySqlParameter mySqlParameter in parameters)
            {
                cmd.Parameters.Add(mySqlParameter);
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                maindatagridview.Rows.Clear();
                reader.Close();
                return;
            }
            LoadDefaultDatagridview(reader);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            projectNameSearch.Texts = string.Empty;
            teacherCombobox.SelectedIndex = 0;
            departmentCombobox.SelectedIndex = 0;
            statusCombobox.SelectedIndex = 0;
            classCombobox.SelectedIndex = 0;
            studentSearch.Texts = string.Empty;
            LoadDefaultDatagridview(gridviewHandler.GetDataReaderOfProjects());
        }
    }
}
