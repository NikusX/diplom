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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            staticVariables.closeAll();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            staticVariables.addToList(this);
        }
    }
}
