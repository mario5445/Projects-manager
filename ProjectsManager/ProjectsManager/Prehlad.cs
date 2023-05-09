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
            maindatagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15F, FontStyle.Bold); // nastavenie fontu pre hlavicku
            maindatagridview.DefaultCellStyle.Font = new Font("Cambria", 11F); // nastavenie fontu pre bunky
            maindatagridview.Rows.Add(new object[] { 2, "Projekt", "Palica", "", "", "Informatika", "Voľné"});
        }

        #endregion

        #region Events
        private void Prehlad_Load(object sender, EventArgs e)
        {
            DatagridviewHandler handler = new DatagridviewHandler();
            LoadDefaultDatagridview(handler.GetDataReaderOfProjects());
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
        #endregion
    }
}
