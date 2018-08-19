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
        InventoryEntities ctx = new InventoryEntities();

        public String access;
        
        public Login()
        {
            InitializeComponent();
        }

        private int status;
        public void setStatus(int num)
        {
            status = num;
        }
        public int getStatus()
        {
            return status;
        }


        private void forgetPasswordLbl_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword();
            this.Hide();
            reset.Show();
        }

        
        private void loginbutton_Click(object sender, EventArgs e)
        {
            //var username = "admin";
            //var password = "password";

           

            var username_text = usernametb.Text;
            var password_text = passwordtb.Text;


            /*if (username == usernametb.Text && password == passwordtb.Text)
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
             */
            password_text = EasyEncryption.SHA.ComputeSHA256Hash(password_text);

            var IsAnyUser = ctx.Users.Any(q => q.Username == username_text && q.Password == password_text);


            if (IsAnyUser)
            {

                // var parent = (Administrator)MdiParent;
                 //parent.isAuth = true;

                Administrator administrator = new Administrator();
                administrator.Show();

                this.Close();

                

                
                

            }
            else
            {
                MessageBox.Show("Credentials provided are not valid");
            }
            
        }


    }
}
