﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Manage_User : Form
    {
        public Manage_User()
        {
            InitializeComponent();
        }

        private void resetbutton1_Click(object sender, EventArgs e)
        {
            this.searchtextBox1.Text = "";
            this.dataGridView1.DataSource = null;
        }

        private void Manage_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }
    }
}
