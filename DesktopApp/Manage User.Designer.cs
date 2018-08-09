namespace DesktopApp
{
    partial class Manage_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_User));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchtextBox1 = new System.Windows.Forms.TextBox();
            this.searchbutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resetbutton1 = new System.Windows.Forms.Button();
            this.deletebutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // searchtextBox1
            // 
            this.searchtextBox1.Location = new System.Drawing.Point(107, 95);
            this.searchtextBox1.Multiline = true;
            this.searchtextBox1.Name = "searchtextBox1";
            this.searchtextBox1.Size = new System.Drawing.Size(324, 27);
            this.searchtextBox1.TabIndex = 2;
            // 
            // searchbutton1
            // 
            this.searchbutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchbutton1.Location = new System.Drawing.Point(450, 88);
            this.searchbutton1.Name = "searchbutton1";
            this.searchbutton1.Size = new System.Drawing.Size(96, 34);
            this.searchbutton1.TabIndex = 3;
            this.searchbutton1.Text = "Search";
            this.searchbutton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 170);
            this.dataGridView1.TabIndex = 4;
            // 
            // resetbutton1
            // 
            this.resetbutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resetbutton1.Location = new System.Drawing.Point(404, 380);
            this.resetbutton1.Name = "resetbutton1";
            this.resetbutton1.Size = new System.Drawing.Size(96, 34);
            this.resetbutton1.TabIndex = 5;
            this.resetbutton1.Text = "Reset";
            this.resetbutton1.UseVisualStyleBackColor = false;
            this.resetbutton1.Click += new System.EventHandler(this.resetbutton1_Click);
            // 
            // deletebutton2
            // 
            this.deletebutton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deletebutton2.Location = new System.Drawing.Point(529, 380);
            this.deletebutton2.Name = "deletebutton2";
            this.deletebutton2.Size = new System.Drawing.Size(96, 34);
            this.deletebutton2.TabIndex = 6;
            this.deletebutton2.Text = "Delete";
            this.deletebutton2.UseVisualStyleBackColor = false;
            // 
            // Manage_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(692, 431);
            this.Controls.Add(this.deletebutton2);
            this.Controls.Add(this.resetbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbutton1);
            this.Controls.Add(this.searchtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manage_User";
            this.Text = "Manage User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_User_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtextBox1;
        private System.Windows.Forms.Button searchbutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resetbutton1;
        private System.Windows.Forms.Button deletebutton2;
    }
}