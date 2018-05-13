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
    public partial class repertoireForm : Form
    {
        public repertoireForm()
        {
            InitializeComponent();
        }

        private void repertoireForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "boxOfficeDBDataSet.Репертуар". При необходимости она может быть перемещена или удалена.
            this.репертуарTableAdapter.Fill(this.boxOfficeDBDataSet.Репертуар);

        }
    }
}
