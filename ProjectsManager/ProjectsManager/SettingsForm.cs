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
using Microsoft.VisualBasic;

namespace ProjectsManager
{
    public partial class SettingsForm : Form
    {

        private DatagridviewHandler gridviewhandler;
        public SettingsForm()
        {
            InitializeComponent();
            gridviewhandler = new DatagridviewHandler();
            LoadDefaultClassesDatagridview(gridviewhandler.GetDataReaderForClasses());
            LoadDefaultDepartmentsDatagridview(gridviewhandler.GetDataReaderForDepartments());
            StyleDatagridview();
        }

        private void LoadDefaultClassesDatagridview(MySqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                return;
            }
            classesDatagridview.Rows.Clear();
            while (reader.Read())
            {
                int class_id = reader.GetInt32("class_id");
                string class_name = reader.GetString("class_name");
                classesDatagridview.Rows.Add(new object[] { class_id, class_name });
            }
            reader.Close();
        }

        private void LoadDefaultDepartmentsDatagridview(MySqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                return;
            }
            departmentsDatagridview.Rows.Clear();
            while (reader.Read())
            {
                int department_id = reader.GetInt32("department_id");
                string department_name = reader.GetString("department_name");
                departmentsDatagridview.Rows.Add(new object[] { department_id, department_name });
            }
            reader.Close();
        }

        private void StyleDatagridview()
        {
            classesDatagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 14F, FontStyle.Bold); // nastavenie fontu pre hlavicku
            classesDatagridview.DefaultCellStyle.Font = new Font("Cambria", 13F); // nastavenie fontu pre bunky
            departmentsDatagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 14F, FontStyle.Bold); // nastavenie fontu pre hlavicku
            departmentsDatagridview.DefaultCellStyle.Font = new Font("Cambria", 13F); // nastavenie fontu pre bunky
        }

        private bool ClassExists(string class_name)
        {
            string query = "SELECT class_name FROM classes WHERE class_name = @Class";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Class", class_name);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        private bool DepartmentExists(string department_name)
        {
            string query = "SELECT department_name FROM departments WHERE department_name = @Dep";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Dep", department_name);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            string class_name = AddClassTextbox.Texts.Trim();
            if (class_name.Length >= 8)
            {
                MessageBox.Show("Názov triedy je príliš dlhý");
                return;
            }
            if (class_name == string.Empty)
            {
                return;
            }
            if (ClassExists(class_name))
            {
                MessageBox.Show("Táto trieda už existuje");
                AddClassTextbox.Texts = string.Empty;
                return;
            }
            string query = "INSERT INTO classes(class_name) VALUES (@Name)";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", class_name);
            cmd.ExecuteNonQuery();
            LoadDefaultClassesDatagridview(gridviewhandler.GetDataReaderForClasses());
        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            string dep_name = AddClassTextbox.Texts.Trim();
            if (dep_name.Length >= 64)
            {
                MessageBox.Show("Názov odboru je príliš dlhý");
                return;
            }
            if (dep_name == string.Empty)
            {
                return;
            }
            if (DepartmentExists(dep_name))
            {
                MessageBox.Show("Tento odbor už existuje");
                AddDepartmentTextbox.Texts = string.Empty;
                return;
            }
            string query = "INSERT INTO departments(department_name) VALUES (@Dep)";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Dep", dep_name);
            cmd.ExecuteNonQuery();
            LoadDefaultDepartmentsDatagridview(gridviewhandler.GetDataReaderForDepartments());
        }

        private void deleteClassBtn_Click(object sender, EventArgs e)
        {
            int index = classesDatagridview.CurrentCell.RowIndex;
            if(MessageBox.Show($"Chcete skutočne vymazať triedu {classesDatagridview.Rows[index].Cells[1].Value}", "Vymazanie triedy", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = $"DELETE FROM classes WHERE class_id = {classesDatagridview.Rows[index].Cells[0].Value}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            LoadDefaultClassesDatagridview(gridviewhandler.GetDataReaderForClasses());
        }

        private void classesDatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            classesDatagridview.CurrentRow.Selected = true;
            DataGridViewRow row = classesDatagridview.Rows[e.RowIndex];
            int id = 0;
            try
            {
                id = (int)classesDatagridview.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {
                return;
            }
            string class_name = Interaction.InputBox("Zadajte nový názov triedy", "Zmena názvu", row.Cells[1].Value.ToString(), -1, -1).Trim();
            if (class_name.Length < 1)
            {
                return;
            }
            else if (class_name.Length >= 8)
            {
                MessageBox.Show("Názov triedy je príliš dlhý");
                return;
            }
            string query = $"UPDATE classes SET class_name = @Name WHERE class_id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", class_name);
            cmd.ExecuteNonQuery();
            LoadDefaultClassesDatagridview(gridviewhandler.GetDataReaderForClasses());
        }

        private void departmentsDatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            departmentsDatagridview.CurrentRow.Selected = true;
            DataGridViewRow row = departmentsDatagridview.Rows[e.RowIndex];
            int id = 0;
            try
            {
                id = (int)departmentsDatagridview.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {
                return;
            }
            string dep_name = Interaction.InputBox("Zadajte nový názov odboru", "Zmena názvu", row.Cells[1].Value.ToString(), -1, -1).Trim();
            if (dep_name.Length < 1)
            {
                return;
            }
            else if (dep_name.Length >= 64)
            {
                MessageBox.Show("Názov odboru je príliš dlhý");
                return;
            }
            string query = $"UPDATE departments SET department_name = @Name WHERE department_id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", dep_name);
            cmd.ExecuteNonQuery();
            LoadDefaultDepartmentsDatagridview(gridviewhandler.GetDataReaderForDepartments());
        }

        private void deleteAllClsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete skutočne vymazať všetky triedy? TENTO KROK NIE JE MOŽNÉ VRÁTIŤ!", "Vymazanie tried", MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                return;
            }
            string query = "START TRANSACTION; " +
                "\r\nALTER TABLE classes AUTO_INCREMENT = 1; " +
                "\r\nTRUNCATE TABLE classes; " +
                "\r\nCOMMIT;";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            LoadDefaultClassesDatagridview(gridviewhandler.GetDataReaderForClasses());
        }

        private void deleteAllDepBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete skutočne vymazať všetky triedy? TENTO KROK NIE JE MOŽNÉ VRÁTIŤ!", "Vymazanie odborov", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = "START TRANSACTION; " +
                "\r\nALTER TABLE departments AUTO_INCREMENT = 1; " +
                "\r\nTRUNCATE TABLE departments; " +
                "\r\nCOMMIT;";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            LoadDefaultDepartmentsDatagridview(gridviewhandler.GetDataReaderForDepartments());
        }

        private void deleteAllUsersBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete skutočne vymazať všetkých užívateľov? TENTO KROK NIE JE MOŽNÉ VRÁTIŤ! PO TOMTO KROKU BUDÚ VYMAZANÉ AJ VŠETKY PROJEKTY!!", "Vymazanie užívateľov", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = "START TRANSACTION; " +
                "\r\nALTER TABLE users AUTO_INCREMENT = 1; " +
                "\r\nDELETE FROM users WHERE user_role != 'Admin'; ";
            if (MessageBox.Show("Posledné varovanie pred vykonaním tohto kroku. Chcete ho skutočne vykonať? Aplikácia sa zavrie po vykonaní tohto kroku", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                query += "\r\nROLLBACK;";
                MySqlCommand cmd = new MySqlCommand(query, DB.connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                query += "\r\nCOMMIT;";
                MySqlCommand cmd = new MySqlCommand(query, DB.connection);
                cmd.ExecuteNonQuery();
                Application.Exit();
            }
        }

        private void deleteAllProjectsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete skutočne vymazať všetky projekty? TENTO KROK NIE JE MOŽNÉ VRÁTIŤ!", "Vymazanie projektov", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = "START TRANSACTION; " +
                "\r\nALTER TABLE projects AUTO_INCREMENT = 1; " +
                "\r\nTRUNCATE TABLE projects; ";
            if (MessageBox.Show("Posledné varovanie pred vykonaním tohto kroku. Chcete ho skutočne vykonať? Aplikácia sa zavrie po vykonaní tohto kroku", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                query += "\r\nROLLBACK;"; 
                MySqlCommand cmd = new MySqlCommand(query, DB.connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                query += "\r\nCOMMIT;";
                MySqlCommand cmd = new MySqlCommand(query, DB.connection);
                cmd.ExecuteNonQuery();
                Application.Exit();
            }
        }
    }
}
