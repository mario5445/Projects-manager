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
    public partial class PlaceholderFormForMainForm : Form
    {
        public PlaceholderFormForMainForm(string username)
        {
            InitializeComponent();
            if (username.Length > 17) // Nastavenie velkosti fontu na zaklade mena
            {
                TextLabel.Text = string.Empty;
                TextLabel.Font = new Font("Cambria", 35F, FontStyle.Bold);
                TextLabel.Text += "Vitajte v systéme ";
            }

            TextLabel.Text += username + "!"; // vypisanie mena do labelu
        }
    }
}
