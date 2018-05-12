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
    public partial class buyerForm : Form
    {
        public buyerForm()
        {
            InitializeComponent();
        }

        private void buyerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            staticVariables.mainForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buyerForm_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(exitButton, "Выйти из системы");
        }

        private void userProfileButton_Click(object sender, EventArgs e)
        {
            userProfileForm userProfileForm1 = new userProfileForm();
            userProfileForm1.ShowDialog();
        }
    }
}
