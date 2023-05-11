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
        #region Constructor
        public Prehlad()
        {
            InitializeComponent();
            DatagridviewHandler handler = new DatagridviewHandler();
            LoadDefaultDatagridview(handler.GetDataReaderOfProjects());
            GetDataForComboboxes();
            maindatagridview.Rows.Add(new object[] { 2, "Projekt", "Palica", "", "", "Informatika", "Voľné" });
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
        /// Loads default Datagridview without any filters
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
                string student = reader.GetString("student");
                string student_class = reader.GetString("student_class");
                string department = reader.GetString("department");
                string status = reader.GetString("status");
                maindatagridview.Rows.Add(new object[] { id, name, teacher, student, student_class, department, status }); // pridanie riadku do Datagridview
            }
            reader.Close(); // zatvorenie readeru -> IMPORTANT
            StyleDatagridview();
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
            string query = "SELECT p.project_id AS 'id', p.project_name AS 'name', u.user_full_name AS 'teacher', us.user_full_name AS 'student', us.name_of_class AS 'student_class', dp.department_name AS 'department', p.project_status AS 'status'" +
                "\r\nFROM projects AS p" +
                "\r\nINNER JOIN users AS u ON p.project_teacher = u.user_id" +
                "\r\nLEFT JOIN (" +
                "\r\n    SELECT usr.user_id, usr.user_full_name, cl.class_name AS name_of_class " +
                "\r\n    FROM users AS usr " +
                "\r\n    LEFT JOIN classes AS cl ON usr.user_class = cl.class_id) " +
                "\r\n    AS us ON p.project_student = us.user_id" +
                "\r\nLEFT JOIN departments AS dp ON p.project_department = dp.department_id " +
                "WHERE ";
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
    }
}
