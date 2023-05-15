using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class ProjectInfo : Form
    {
        public int Project_id { get; set; }
        private int User_id { get; set; }
        private string User_role { get; set; }
        private int project_department_id { get; set; }
        private string Project_description { get; set; }
        private string Project_name { get; set; }

        public ProjectInfo(int project_id, int user_id, string user_role)
        {
            InitializeComponent();
            Project_id = project_id;
            User_id = user_id;
            User_role = user_role;
        }

        private void CheckUser()
        {
            if (this.User_role == "Študent")
            {
                EditButton.Cursor = Cursors.Arrow;
                EditButton.Visible = false;
                EditButton.Enabled = false;
                DeleteButton.Cursor = Cursors.Arrow;
                DeleteButton.Visible = false;
                DeleteButton.Enabled = false;
                approveButton.Enabled = false;
                approveButton.Visible = false;
                string query = "SELECT project_id AS 'p_id', u.user_id AS 'u_id'" +
                    "\r\nFROM projects AS p" +
                    "\r\nLEFT JOIN users AS u ON p.project_student = u.user_id" +
                    $"\r\nWHERE u.user_id = {this.User_id};";
                MySqlCommand cmd = new MySqlCommand(query, DB.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    ZapisatButton.Cursor = Cursors.Arrow;
                    ZapisatButton.Visible = false;
                    ZapisatButton.Enabled = false;
                }
                dataReader.Close();
                return;
            }
            if (this.User_role == "Učiteľ")
            {
                ZapisatButton.Cursor = Cursors.Arrow;
                ZapisatButton.Visible = false;
                ZapisatButton.Enabled = false;
            }
        }

        private void ProjectInfo_Load(object sender, EventArgs e)
        {
            CheckUser();
            LoadData();
            GetDepartmentComboboxData();
        }

        private void LoadData()
        {
            string query = "SELECT p.project_id AS 'id', p.project_name AS 'name', p.project_description AS 'description', u.user_full_name AS 'teacher', us.user_full_name AS 'student', us.name_of_class AS 'student_class' ,dp.department_name AS 'department', p.project_status AS 'status', p.project_consultation_first AS 'consultation_first', p.project_consultation_second AS 'consultation_second', p.project_consultation_third AS 'consultation_third', u.user_id AS 'teacher_id', us.user_id AS 'student_id', dp.department_id AS 'department_id' " +
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
                int student_id = !reader.IsDBNull(12) ? reader.GetInt32("student_id") : 0;
                int teacher_id = reader.GetInt32("teacher_id");
                string project_name = reader.GetString("name");
                string project_description = reader.GetString("description");
                string project_teacher = reader.GetString("teacher");
                string project_student = !reader.IsDBNull(4) ? reader.GetString("student") : "-";
                string student_class = !reader.IsDBNull(5) ? reader.GetString("student_class") : "-";
                string project_department = !reader.IsDBNull(6) ? reader.GetString("department") : "-";
                this.project_department_id = !reader.IsDBNull(13) ? reader.GetInt32("department_id") : 0;
                string project_status = reader.GetString("status");
                string consultation_first = !reader.IsDBNull(8) ? reader.GetString("consultation_first") : string.Empty;
                string consultation_second = !reader.IsDBNull(9) ? reader.GetString("consultation_second") : string.Empty;
                string consultation_third = !reader.IsDBNull(10) ? reader.GetString("consultation_third") : string.Empty;

                this.Text = project_name;

                if (this.User_id != teacher_id)
                {
                    EditButton.Cursor = Cursors.Arrow;
                    EditButton.Visible = false;
                    EditButton.Enabled = false;
                    DeleteButton.Cursor = Cursors.Arrow;
                    DeleteButton.Visible = false;
                    DeleteButton.Enabled = false;
                    departmentCombobox.Visible = false;
                    departmentCombobox.Cursor = Cursors.Arrow;
                    departmentCombobox.Enabled = false;
                    consultations.Enabled = false;
                    consultations.Visible = false;
                    approveButton.Visible = false;
                    approveButton.Enabled = false;
                    denyButton.Visible = false;
                    denyButton.Enabled = false;
                    this.Height = 40;
                }
                else
                {
                    projectNameTxtbox.ReadOnly = false;
                    projectNameTxtbox.ForeColor = Color.Indigo;
                    projectNameTxtbox.BackColor = Color.White;
                    panelName.BackColor = Color.White;
                    descriptionRtb.BackColor = Color.White;
                    descriptionRtb.ForeColor = Color.Indigo;
                    descriptionRtb.ReadOnly = false;
                    descriptionPanel.BackColor = Color.White;
                    firstConsultationRtb.ReadOnly = false;
                    addFirstConsultationBtn.Visible = true;
                    addFirstConsultationBtn.Enabled = true;
                    addFirstConsultationBtn.Text = consultation_first == string.Empty ? "Pridať hodnotenie" : "Upraviť hodnotenie";
                    addFirstConsultationBtn.IconChar = consultation_first == string.Empty ? FontAwesome.Sharp.IconChar.PlusCircle : FontAwesome.Sharp.IconChar.PenToSquare;
                    secondConsultationRtb.ReadOnly = consultation_first == string.Empty ? true : false;
                    addSecondConsultationBtn.Visible = consultation_first == string.Empty ? false : true;
                    addSecondConsultationBtn.Enabled = consultation_first == string.Empty ? false : true;
                    addSecondConsultationBtn.Text = consultation_second == string.Empty ? "Pridať hodnotenie" : "Upraviť hodnotenie";
                    addSecondConsultationBtn.IconChar = consultation_second == string.Empty ? FontAwesome.Sharp.IconChar.PlusCircle : FontAwesome.Sharp.IconChar.PenToSquare;
                    thirdConsultationRtb.ReadOnly = consultation_second == string.Empty ? true : false;
                    addThirdConsultationBtn.Enabled = consultation_second == string.Empty ? false : true;
                    addThirdConsultationBtn.Visible = consultation_second == string.Empty ? false : true;
                    addThirdConsultationBtn.Text = consultation_third == string.Empty ? "Pridať hodnotenie" : "Upraviť hodnotenie";
                    addThirdConsultationBtn.IconChar = consultation_third == string.Empty ? FontAwesome.Sharp.IconChar.PlusCircle : FontAwesome.Sharp.IconChar.PenToSquare;
                }
                if (this.User_id == student_id)
                {
                    consultations.Enabled = true;
                    consultations.Visible = true;
                    this.Height = 589;
                    

                }
                else if (this.User_id != student_id && this.User_id != teacher_id)
                {
                    this.Height = 420;
                }
                projectNameTxtbox.Text = project_name;
                descriptionRtb.Text = project_description;
                KonzultantLabel.Text = string.Empty;
                KonzultantLabel.Text += "Konzultant: " + project_teacher;
                StudentLabel.Text = string.Empty;
                StudentLabel.Text += "Pridelený žiak: " + project_student + " - " + student_class;
                departmentLabel.Text = string.Empty;
                departmentLabel.Text += "Odbor: " + project_department;
                StatusLabel.Text = project_status;
                firstConsultationRtb.Text = consultation_first == string.Empty ? string.Empty : consultation_first;
                secondConsultationRtb.Text = consultation_second == string.Empty ? string.Empty : consultation_second;
                thirdConsultationRtb.Text = consultation_third == string.Empty ? string.Empty : consultation_third;
                switch (StatusLabel.Text)
                {
                    case "Voľné":
                        StatusLabel.BackColor = Color.LimeGreen;
                        approveButton.Enabled = false;
                        approveButton.Visible = false;
                        denyButton.Visible = false;
                        denyButton.Enabled = false;
                        consultations.Enabled = false;
                        consultations.Visible = false;
                        break;
                    case "Obsadené":
                        StatusLabel.BackColor = Color.Red;
                        ZapisatButton.Enabled = false;
                        ZapisatButton.Visible = false;
                        approveButton.Enabled = false;
                        approveButton.Visible = false;
                        denyButton.Visible = false;
                        denyButton.Enabled = false;
                        if (this.User_id == teacher_id || this.User_id == student_id)
                        {
                            consultations.Enabled = true;
                            consultations.Visible = true;
                        }
                        break;
                    case "Čaká na schválenie":
                        StatusLabel.BackColor = Color.Orange; 
                        ZapisatButton.Enabled = false;
                        ZapisatButton.Visible = false;
                        if (this.User_role == "Študent")
                        {
                            consultations.Visible = false;
                            consultations.Enabled = false;
                            this.Height = 420;
                        }
                        if (this.User_id == teacher_id)
                        {
                            approveButton.Enabled = true;
                            approveButton.Visible = true;
                            denyButton.Visible = true;
                            denyButton.Enabled = true;
                            consultations.Enabled = false;
                            consultations.Visible = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            reader.Close();
        }

        private void GetDepartmentComboboxData()
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
            departmentCombobox.SelectedIndex = this.project_department_id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZapisatButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Chcete sa záväzne zapísať na tento projekt?", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = $"UPDATE projects SET project_student = {this.User_id}, project_status = 'Čaká na schválenie' WHERE project_id = {this.Project_id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Boli ste úspešne zapísaný na projekt {this.Text}");
            LoadData();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (projectNameTxtbox.Text.Trim() == string.Empty || descriptionRtb.Text.Trim() == string.Empty || departmentCombobox.SelectedIndex == 0)
            {
                MessageBox.Show("Všetky polia musia byť vyplnené!");
                return;
            }
            if (MessageBox.Show("Chcete skutočne upraviť tento projekt?", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            int department = ((ComboItem)departmentCombobox.SelectedItem).Value;
            string query = $"UPDATE projects SET project_name = @ProjectName, project_description = @ProjectDescription, project_department = {department} WHERE project_id = {this.Project_id};";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@ProjectName", projectNameTxtbox.Text.Trim());
            cmd.Parameters.AddWithValue("@ProjectDescription", descriptionRtb.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Projekt úspešne upravený");
            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chcete naozaj vymazať tento projekt? \r\n VAROVANIE: Tento krok nie je možné vrátiť", "Potvrdenie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = $"DELETE FROM projects WHERE project_id = {this.Project_id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Projekt bol úspešne vymazaný");
            this.Close();
        }

        private void addFirstConsultationBtn_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE projects SET project_consultation_first = @Consultation WHERE project_id = {this.Project_id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Consultation", firstConsultationRtb.Text.Trim());
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void addSecondConsultationBtn_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE projects SET project_consultation_second = @Consultation WHERE project_id = {this.Project_id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Consultation", secondConsultationRtb.Text.Trim());
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void addThirdConsultationBtn_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE projects SET project_consultation_third = @Consultation WHERE project_id = {this.Project_id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.Parameters.AddWithValue("@Consultation", thirdConsultationRtb.Text.Trim());
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE projects SET project_status = 'Obsadené' WHERE project_id = {this.Project_id}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE projects SET project_student = NULL, project_status = 'Voľné' WHERE project_id = {this.Project_id}";
            DB.ExecuteQuery(query);
            LoadData();
        }
    }
}
