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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

      
        private void forgetPasswordLbl_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword();
            this.Hide();
            reset.Show();
        }

        
        private void loginbutton_Click(object sender, EventArgs e)
        {
            var username = "admin";
            var password = "password";

            if (username == usernametb.Text && password == passwordtb.Text)
            {
                Administrator administrator = new Administrator();
                administrator.Show();
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect");
                this.usernametb.Text = "";
                this.passwordtb.Text = "";
            }
        }

       
    }
}
