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
    public partial class ExportDialog : Form
    {
        private DataGridView data = null;
        private Exporting exporting;
        public ExportDialog(DataGridView data)
        {
            InitializeComponent();
            if (data.Rows.Count < 1)
            {
                MessageBox.Show("Žiadne dáta pre export");
                return;
            }
            exporting = new Exporting(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            switch (name)
            {
                case "pdfExport":
                    exporting.ExportToPdf();
                    this.Close();
                    break;
                case "excelExport":
                    exporting.ExportToExcel();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
