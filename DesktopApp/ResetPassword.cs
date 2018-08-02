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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (this.newPassTb.Text == this.confirmPassTb.Text && newPassTb.TextLength >= 8)
            {
                MessageBox.Show("Password change successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match");

            }
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }
    }
}
