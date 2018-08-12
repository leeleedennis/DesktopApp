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
        InventoryEntities ctx = new InventoryEntities();
        

        public AddUser()
        {
            InitializeComponent();
        }
       
        private void createbtn_Click(object sender, EventArgs e)
        {
            var fname_box = FnameTb.Text;
            var lname_box = LnameTb.Text;
            var username_box = UsernameTb.Text;
            var password_box = PasswordTb.Text;
            var type = comboBox1.Text;
            var datecreated = DateTime.Now;
            var createdby = "Admin";
            var confirmpass = ConfirmtextBox.Text;

            if (String.IsNullOrEmpty(username_box) || String.IsNullOrEmpty(password_box))
            {
                MessageBox.Show("Please Enter Valid Information");
            }
            else
            {
                try
                {

                    var user = new User

                    {
                     
                        F_Name = fname_box,
                        L_Name = lname_box,
                        Username = username_box,
                        Password = EasyEncryption.SHA.ComputeSHA256Hash(password_box),
                        Type = type,
                        Date_Created = datecreated,
                        Created_By = createdby,
                    };

                    ctx.Users.Add(user);
                    ctx.SaveChanges();

                    if (password_box == confirmpass)
                    {
                        MessageBox.Show("Passwords Matched");

                    }
                    else
                    {
                        MessageBox.Show("Password Error");
                    }

                    MessageBox.Show("New user account was created");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                    throw;
                }
            }







        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }
    }
}
