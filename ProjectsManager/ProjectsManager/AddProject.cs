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
    public partial class AddProject : Form
    {
        private int userID { get; set; }
        public AddProject(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void customTextbox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void getDataForComboBox()
        {
            departmentCombobox.Items.Clear();
            departmentCombobox.Items.Add(new ComboItem("Odbor", 0));
            string departments_query = "SELECT department_id, department_name FROM departments ORDER BY department_id ASC;";
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (NameTextBox.Texts.Trim() == string.Empty || DescriptionRTB.Text.Trim() == string.Empty || departmentCombobox.SelectedIndex == 0)
            {
                MessageBox.Show("Všetky polia musia byť vyplnené");
                return;
            }
            string name = NameTextBox.Texts.Trim();
            string description = DescriptionRTB.Text.Trim();
            int department = ((ComboItem)departmentCombobox.SelectedItem).Value;
            string query = $"INSERT INTO projects (project_name, project_description, project_teacher, project_department) VALUES (@Name, @Description, {this.userID}, {department})";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Projekt bol úspešne pridaný");
            NameTextBox.Texts = string.Empty;
            DescriptionRTB.Text = string.Empty;
            departmentCombobox.SelectedIndex = 0;
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            getDataForComboBox();
        }
    }
}
