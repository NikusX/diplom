﻿using System;
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
    public partial class salesManagerForm : Form
    {
        public salesManagerForm()
        {
            InitializeComponent();
        }

        private void salesManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            staticVariables.mainForm.Show();
        }

        private void salesManagerForm_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(exitButton, "Выйти из системы");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
