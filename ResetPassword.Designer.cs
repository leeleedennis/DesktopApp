namespace DesktopApp
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.oldPasswordLbl = new System.Windows.Forms.Label();
            this.NewPasswordLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldPassTb = new System.Windows.Forms.TextBox();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.confirmPassTb = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oldPasswordLbl
            // 
            this.oldPasswordLbl.AutoSize = true;
            this.oldPasswordLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.oldPasswordLbl.Location = new System.Drawing.Point(44, 176);
            this.oldPasswordLbl.Name = "oldPasswordLbl";
            this.oldPasswordLbl.Size = new System.Drawing.Size(114, 20);
            this.oldPasswordLbl.TabIndex = 0;
            this.oldPasswordLbl.Text = "Old Password:";
            // 
            // NewPasswordLbl
            // 
            this.NewPasswordLbl.AutoSize = true;
            this.NewPasswordLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.NewPasswordLbl.Location = new System.Drawing.Point(44, 215);
            this.NewPasswordLbl.Name = "NewPasswordLbl";
            this.NewPasswordLbl.Size = new System.Drawing.Size(122, 20);
            this.NewPasswordLbl.TabIndex = 1;
            this.NewPasswordLbl.Text = "New Password:";
            this.NewPasswordLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label2.Location = new System.Drawing.Point(44, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password:";
            // 
            // OldPassTb
            // 
            this.OldPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OldPassTb.Location = new System.Drawing.Point(202, 176);
            this.OldPassTb.Multiline = true;
            this.OldPassTb.Name = "OldPassTb";
            this.OldPassTb.PasswordChar = '*';
            this.OldPassTb.Size = new System.Drawing.Size(168, 24);
            this.OldPassTb.TabIndex = 3;
            // 
            // newPassTb
            // 
            this.newPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newPassTb.Location = new System.Drawing.Point(202, 215);
            this.newPassTb.Multiline = true;
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.PasswordChar = '*';
            this.newPassTb.Size = new System.Drawing.Size(168, 24);
            this.newPassTb.TabIndex = 4;
            // 
            // confirmPassTb
            // 
            this.confirmPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTb.Location = new System.Drawing.Point(202, 254);
            this.confirmPassTb.Multiline = true;
            this.confirmPassTb.Name = "confirmPassTb";
            this.confirmPassTb.PasswordChar = '*';
            this.confirmPassTb.Size = new System.Drawing.Size(168, 24);
            this.confirmPassTb.TabIndex = 5;
            this.confirmPassTb.TextChanged += new System.EventHandler(this.confirmPassTb_TextChanged);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updatebtn.Location = new System.Drawing.Point(167, 299);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(80, 29);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesktopApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.label1.Location = new System.Drawing.Point(44, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // usernametB
            // 
            this.usernametB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernametB.Location = new System.Drawing.Point(202, 132);
            this.usernametB.Multiline = true;
            this.usernametB.Name = "usernametB";
            this.usernametB.PasswordChar = '*';
            this.usernametB.Size = new System.Drawing.Size(168, 24);
            this.usernametB.TabIndex = 12;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(413, 340);
            this.Controls.Add(this.usernametB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.confirmPassTb);
            this.Controls.Add(this.newPassTb);
            this.Controls.Add(this.OldPassTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPasswordLbl);
            this.Controls.Add(this.oldPasswordLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPassword_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPasswordLbl;
        private System.Windows.Forms.Label NewPasswordLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OldPassTb;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.TextBox confirmPassTb;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametB;
    }
}