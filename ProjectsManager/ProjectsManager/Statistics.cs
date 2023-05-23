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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            LoadDataForProjectStatus();
            LoadDataForUserRoles();
            LoadDataForDepartments();
            LoadDataForClasses();
        }

        private void LoadDataForProjectStatus()
        {
            string query = "SELECT COUNT(*) AS num, project_status FROM projects GROUP BY project_status;";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int counter = 0;
            while (reader.Read())
            {
                string status = reader.GetString("project_status");
                int num = reader.GetInt32("num");
                counter += num;
                status_chart.Series["Project_status"].Points.AddXY(status + "(" + num.ToString() + ")", num);
            }
            reader.Close();
            numOfProjectsLabel.Text += counter.ToString();
        }

        private void LoadDataForUserRoles()
        {
            string query = "SELECT COUNT(*) AS num, user_role FROM users GROUP BY user_role HAVING user_role != 'Admin';";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int counter = 0;
            while (reader.Read())
            {
                string role = reader.GetString("user_role");
                int num = reader.GetInt32("num");
                counter += num;
                usersChart.Series["User_roles"].Points.AddXY(role + "(" + num.ToString() + ")", num);
            }
            reader.Close();
            numOfUsersLabel.Text += counter.ToString();
        }

        private void LoadDataForDepartments()
        {
            string query = "SELECT COUNT(*) AS num, dp.department_name AS dp_name " +
                "\r\nFROM projects AS p" +
                "\r\nLEFT JOIN departments AS dp ON p.project_department = dp.department_id" +
                "\r\nGROUP BY dp.department_name HAVING dp.department_name IS NOT NULL;";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int counter = 0;
            while (reader.Read())
            {
                string department = reader.GetString("dp_name");
                int num = reader.GetInt32("num");
                counter++;
                departmentsChart.Series["Počet v odbore"].Points.AddXY(department, num);
            }
            reader.Close();
            numOfDepartmentsLabel.Text += counter.ToString();
        }

        private void LoadDataForClasses()
        {
            string query = "SELECT COUNT(*) AS num, cl.class_name AS class_name" +
                "\r\nFROM projects AS p" +
                "\r\nLEFT JOIN (" +
                "\r\n\tSELECT u.user_id, cls.class_name" +
                "\r\n    FROM users AS u" +
                "\r\n    LEFT JOIN classes AS cls ON u.user_class = cls.class_id" +
                "\r\n) AS cl ON p.project_student = cl.user_id" +
                "\r\nGROUP BY cl.class_name HAVING cl.class_name IS NOT NULL;";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int counter = 0;
            while (reader.Read())
            {
                string class_name = reader.GetString("class_name");
                int num = reader.GetInt32("num");
                counter++;
                classesChart.Series["PocetTried"].Points.AddXY(class_name, num);
            }
            reader.Close();
            numOfClassesLabel.Text += counter.ToString();
        }
    }
}
