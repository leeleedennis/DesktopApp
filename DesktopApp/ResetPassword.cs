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
        InventoryEntities ctx = new InventoryEntities();
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void updatebtn_Click(object sender, EventArgs e)
        {
            var username_value = usernametB.Text;
            var oldpass_value = OldPassTb.Text;
            var newpass_value = newPassTb.Text;
            var confirm_value = confirmPassTb.Text;

            oldpass_value = EasyEncryption.SHA.ComputeSHA256Hash(oldpass_value);
            newpass_value = EasyEncryption.SHA.ComputeSHA256Hash(newpass_value);
            confirm_value = EasyEncryption.SHA.ComputeSHA256Hash(confirm_value);

            if (username_value == null)
            {
                MessageBox.Show("Username field is empty");
            }
            else
            {
                var u = ctx.Users.FirstOrDefault(q => q.Password == oldpass_value && q.Username == username_value);
                if(u != null)
                {
                    try
                    {
                        u.Password = newpass_value;
                        ctx.SaveChanges();
                        MessageBox.Show("Password changed");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Username not found");
                }
                

            }
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void confirmPassTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
