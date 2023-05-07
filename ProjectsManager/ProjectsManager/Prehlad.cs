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
        public Prehlad()
        {
            InitializeComponent();
            maindatagridview.Rows.Add(1, "Revitalizácia 3D tlačiarne", "Peter Remiš", "Mário Lastovica", "IV.AI", "Informatika", "Obsadené");
            maindatagridview.Rows.Add(1, "Hra v Unreal Engine", "Michal Palica", "-", "IV.BI", "Informatika", "Voľné");
        }

        private void maindatagridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //maindatagridview.Rows[e.RowIndex].Cells["status"].Style.BackColor = status.ToString() == "Voľné" ? Color.Green : Color.Red;
        }

        private void Prehlad_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in maindatagridview.Rows)
            {
                var cell = row.Cells[6];
                if (cell.Value.ToString() == "Voľné")
                {
                    cell.Style.BackColor = Color.Green;
                    cell.Style.ForeColor = Color.White;
                }
                else if (cell.Value.ToString() == "Obsadené")
                {
                    cell.Style.BackColor = Color.Red;
                    cell.Style.ForeColor = Color.White;
                }
                else
                {
                    cell.Style.BackColor = Color.Orange;
                    cell.Style.ForeColor = Color.White;
                }
            }
        }
    }
}
