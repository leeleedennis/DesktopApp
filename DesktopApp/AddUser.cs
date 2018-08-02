using System;
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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
       
        private void createbtn_Click(object sender, EventArgs e)
        {

        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }
    }
}
