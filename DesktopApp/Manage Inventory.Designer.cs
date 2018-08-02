namespace DesktopApp
{
    partial class ManageInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCodeLbl = new System.Windows.Forms.Label();
            this.ItemCodetextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.label1.Location = new System.Drawing.Point(240, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Inventory ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 187);
            this.dataGridView1.TabIndex = 2;
            // 
            // ItemCodeLbl
            // 
            this.ItemCodeLbl.AutoSize = true;
            this.ItemCodeLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ItemCodeLbl.Location = new System.Drawing.Point(79, 152);
            this.ItemCodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCodeLbl.Name = "ItemCodeLbl";
            this.ItemCodeLbl.Size = new System.Drawing.Size(89, 20);
            this.ItemCodeLbl.TabIndex = 5;
            this.ItemCodeLbl.Text = "Item Code:";
            // 
            // ItemCodetextBox
            // 
            this.ItemCodetextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodetextBox.Location = new System.Drawing.Point(175, 149);
            this.ItemCodetextBox.Multiline = true;
            this.ItemCodetextBox.Name = "ItemCodetextBox";
            this.ItemCodetextBox.Size = new System.Drawing.Size(374, 31);
            this.ItemCodetextBox.TabIndex = 1;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Searchbutton.Location = new System.Drawing.Point(565, 146);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(96, 34);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Removebutton.Location = new System.Drawing.Point(342, 471);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(128, 34);
            this.Removebutton.TabIndex = 4;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Updatebutton.Location = new System.Drawing.Point(181, 471);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(128, 34);
            this.Updatebutton.TabIndex = 3;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            // 
            // ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(769, 538);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.ItemCodetextBox);
            this.Controls.Add(this.ItemCodeLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "ManageInventory";
            this.Text = "Manage Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageInventory_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ItemCodeLbl;
        private System.Windows.Forms.TextBox ItemCodetextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Updatebutton;
    }
}