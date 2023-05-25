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
    public partial class UsersDashboard : Form
    {
        #region Fields
        private DatagridviewHandler handler;
        #endregion

        #region Constructor
        public UsersDashboard()
        {
            InitializeComponent();
            handler = new DatagridviewHandler();
        }
        #endregion

        private void UsersDashboard_Load(object sender, EventArgs e)
        {
            LoadData(handler.GetDataReaderOfUsers());
            StyleDatagridview();
            GetClassesComboboxData();
            statusCombobox.Items.Clear();
            statusCombobox.Items.Add("Status");
            statusCombobox.Items.Add("Študent");
            statusCombobox.Items.Add("Učiteľ");
            statusCombobox.SelectedIndex = 0;
        }

        #region Methods
        private void LoadData(MySqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                return;
            }
            maindatagridview.Rows.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                string class_name = reader.IsDBNull(2) ? "-" : reader.GetString("class_name");
                string user_role = reader.GetString("role");
                maindatagridview.Rows.Add(new object[] { id, name, class_name, user_role });
            }
            reader.Close();
        }

        private void StyleDatagridview()
        {
            maindatagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 14F, FontStyle.Bold); // nastavenie fontu pre hlavicku
            maindatagridview.DefaultCellStyle.Font = new Font("Cambria", 13F); // nastavenie fontu pre bunky
        }

        private void GetClassesComboboxData()
        {
            classCombobox.Items.Add(new ComboItem("Trieda", 0));
            string classes_query = "SELECT class_id, class_name FROM classes ORDER BY class_id ASC;";
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
        #endregion

        #region Events
        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (classCombobox.SelectedIndex == 0 && userSearch.Texts.Trim() == string.Empty && statusCombobox.SelectedIndex == 0)
            {
                return;
            }
            string user_status = statusCombobox.SelectedIndex != 0 ? statusCombobox.SelectedItem.ToString() : string.Empty;
            string user_name = userSearch.Texts.Trim();
            string student_class = classCombobox.SelectedIndex != 0 ? classCombobox.SelectedItem.ToString() : string.Empty;
            string query = DatagridviewHandler.defaultUserQuery;
            if (!string.IsNullOrEmpty(user_status))
            {
                query += " AND ";   
                query += $"u.user_role = '{user_status}'";
            }
            if (!string.IsNullOrEmpty(user_name))
            {
                query += " AND ";
                query += "u.user_full_name LIKE @Student ";
                parameters.Add(new MySqlParameter("@Student", "%" + user_name + "%"));
            }
            if (!string.IsNullOrEmpty(student_class))
            {
                query += " AND ";
                query += $"cls.class_name = '{student_class}' ";
            }
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            if (parameters.Count > 0)
            {
                foreach (MySqlParameter mySqlParameter in parameters)
                {
                    cmd.Parameters.Add(mySqlParameter);
                }
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                maindatagridview.Rows.Clear();
                reader.Close();
                return;
            }
            LoadData(reader);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            userSearch.Texts = string.Empty;
            classCombobox.SelectedIndex = 0;
            statusCombobox.SelectedIndex = 0;
            LoadData(handler.GetDataReaderOfUsers());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (maindatagridview.Rows.Count < 1)
            {
                return;
            }
            ExportDialog dialog = new ExportDialog(maindatagridview);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }

        private void deleteClassBtn_Click(object sender, EventArgs e)
        {
            int index = maindatagridview.CurrentCell.RowIndex;
            if (MessageBox.Show($"Chcete skutočne vymazať užívateľa {maindatagridview.Rows[index].Cells[1].Value}? AK JE UŽÍVATEĽ UČITEĽ, VYMAŽÚ SA AJ VŠETKY JEHO PROJEKTY!", "Vymazanie užívateľa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string query = $"DELETE FROM classes WHERE class_id = {maindatagridview.Rows[index].Cells[0].Value}";
            MySqlCommand cmd = new MySqlCommand(query, DB.connection);
            cmd.ExecuteNonQuery();
            LoadData(handler.GetDataReaderOfUsers());
        }
        #endregion

        private void maindatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maindatagridview.CurrentRow.Selected = true;
            int id = 0;
            string role = "";
            try
            {
                id = (int)maindatagridview.Rows[e.RowIndex].Cells[0].Value;
                role = maindatagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
            UserEditForm form = new UserEditForm(id, role);
            form.FormClosed += (d, o) => LoadData(handler.GetDataReaderOfUsers());
            form.ShowDialog();
        }
    }
}
