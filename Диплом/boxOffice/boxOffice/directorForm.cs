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
    public partial class directorForm : Template
    {
        public directorForm()
        {
            InitializeComponent();
        }

        private void directorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            staticVariables.mainForm.Show();
        }
    }
}
