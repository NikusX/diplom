using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxOffice
{
    public partial class technicianForm : Form
    {
        public technicianForm()
        {
            InitializeComponent();
        }

        private void technician_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(exitButton, "Выйти из системы");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void technician_FormClosed(object sender, FormClosedEventArgs e)
        {
            staticVariables.mainForm.Show();
        }
    }
}
