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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Bitmap theatreLogo = new Bitmap(@"../../resources/logo.png");
            theatreLogoPB.Image = theatreLogo;
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void repertoireButton_Click(object sender, EventArgs e)
        {
            repertoireForm repertoireForm1 = new repertoireForm();
            repertoireForm1.ShowDialog();
        }
    }
}
