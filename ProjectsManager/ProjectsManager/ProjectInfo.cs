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
    public partial class ProjectInfo : Form
    {
        private int Project_id { get; set; }
        public ProjectInfo(int project_id)
        {
            InitializeComponent();
            Project_id = project_id;
        }

        private void ProjectInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT p.project_id AS 'id', p.project_name AS 'name', p.project_description AS 'description', u.user_full_name AS 'teacher', us.user_full_name AS 'student', us.name_of_class AS 'student_class' ,dp.department_name AS 'department', p.project_status AS 'status', p.project_consultation_first AS 'consultation_first', p.project_consultation_second AS 'consultation_second', p.project_consultation_third AS 'consultation_third' " +
                "\r\nFROM projects AS p" +
                "\r\nINNER JOIN users AS u ON p.project_teacher = u.user_id" +
                "\r\nLEFT JOIN (" +
                "\r\n    SELECT usr.user_id, usr.user_full_name, cl.class_name AS name_of_class " +
                "\r\n    FROM users AS usr " +
                "\r\n    LEFT JOIN classes AS cl ON usr.user_class = cl.class_id) " +
                "\r\n    AS us ON p.project_student = us.user_id" +
                "\r\nLEFT JOIN departments AS dp ON p.project_department = dp.department_id " +
                $"WHERE p.project_id = {this.Project_id};";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Projekt sa nenašiel");
                reader.Close();
                this.Close();
            }
            while (reader.Read())
            {
                string project_name = reader.GetString("name");
                string project_description = reader.GetString("description");
                string project_teacher = reader.GetString("teacher");
                string project_student = !reader.IsDBNull(4) ? reader.GetString("student") : "-";
                string student_class = !reader.IsDBNull(5) ? reader.GetString("student_class") : "-";
                string project_department = !reader.IsDBNull(6) ? reader.GetString("department") : "-";
                string project_status = reader.GetString("status");
                string consultation_first = !reader.IsDBNull(8) ? reader.GetString("consultation_first") : "-";
                string consultation_second = !reader.IsDBNull(9) ? reader.GetString("consultation_second") : "-";
                string consultation_third = !reader.IsDBNull(10) ? reader.GetString("consultation_third") : "-";

                ProjectNameLabel.Text = project_name;
                descriptionRtb.Text = project_description;
                KonzultantLabel.Text += project_teacher;
                StudentLabel.Text += project_student + " - " + student_class;
                departmentLabel.Text += project_department;
                StatusLabel.Text = project_status;
                switch (StatusLabel.Text)
                {
                    case "Voľné":
                        StatusLabel.BackColor = Color.LimeGreen;
                        break;
                    case "Obsadené":
                        StatusLabel.BackColor = Color.Red; break;
                    case "Čaká na schválenie":
                        StatusLabel.BackColor = Color.Orange; break;
                    default:
                        break;
                }
            }
            reader.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
