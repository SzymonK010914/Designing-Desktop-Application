using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designing_Desktop.Forms
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Panel";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Panel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            podarunkiUC1.BringToFront();
            labelTitle.Text = "Dodaj albo edytuj Podarunki";
        }
    }
}
