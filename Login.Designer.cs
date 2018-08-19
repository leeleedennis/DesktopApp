namespace DesktopApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.forgetPasswordLbl = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.usernameLbl.Location = new System.Drawing.Point(62, 128);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(73, 19);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // usernametb
            // 
            this.usernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernametb.Location = new System.Drawing.Point(141, 121);
            this.usernametb.Multiline = true;
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(152, 26);
            this.usernametb.TabIndex = 1;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.passwordLbl.Location = new System.Drawing.Point(62, 167);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(72, 19);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password:";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(141, 160);
            this.passwordtb.Multiline = true;
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(152, 26);
            this.passwordtb.TabIndex = 2;
            // 
            // forgetPasswordLbl
            // 
            this.forgetPasswordLbl.AutoSize = true;
            this.forgetPasswordLbl.Location = new System.Drawing.Point(138, 189);
            this.forgetPasswordLbl.Name = "forgetPasswordLbl";
            this.forgetPasswordLbl.Size = new System.Drawing.Size(92, 13);
            this.forgetPasswordLbl.TabIndex = 9;
            this.forgetPasswordLbl.Text = "Forget Password?";
            this.forgetPasswordLbl.Click += new System.EventHandler(this.forgetPasswordLbl_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginbutton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.loginbutton.Location = new System.Drawing.Point(139, 232);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(96, 34);
            this.loginbutton.TabIndex = 10;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesktopApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(383, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.forgetPasswordLbl);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.usernameLbl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
           // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label forgetPasswordLbl;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}