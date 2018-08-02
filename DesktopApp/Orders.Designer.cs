namespace DesktopApp
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.ItemCodeLbl = new System.Windows.Forms.Label();
            this.OrderLbl = new System.Windows.Forms.Label();
            this.ItemCodetextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Removebutton = new System.Windows.Forms.Button();
            this.PlaceOrderbutton = new System.Windows.Forms.Button();
            this.CancOrderbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemCodeLbl
            // 
            this.ItemCodeLbl.AutoSize = true;
            this.ItemCodeLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ItemCodeLbl.Location = new System.Drawing.Point(56, 139);
            this.ItemCodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCodeLbl.Name = "ItemCodeLbl";
            this.ItemCodeLbl.Size = new System.Drawing.Size(89, 20);
            this.ItemCodeLbl.TabIndex = 6;
            this.ItemCodeLbl.Text = "Item Code:";
            // 
            // OrderLbl
            // 
            this.OrderLbl.AutoSize = true;
            this.OrderLbl.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.OrderLbl.Location = new System.Drawing.Point(314, 23);
            this.OrderLbl.Name = "OrderLbl";
            this.OrderLbl.Size = new System.Drawing.Size(96, 34);
            this.OrderLbl.TabIndex = 7;
            this.OrderLbl.Text = "Orders";
            // 
            // ItemCodetextBox
            // 
            this.ItemCodetextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodetextBox.Location = new System.Drawing.Point(152, 136);
            this.ItemCodetextBox.Multiline = true;
            this.ItemCodetextBox.Name = "ItemCodetextBox";
            this.ItemCodetextBox.Size = new System.Drawing.Size(374, 31);
            this.ItemCodetextBox.TabIndex = 1;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(568, 133);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(96, 34);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 183);
            this.dataGridView1.TabIndex = 17;
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(506, 466);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(128, 34);
            this.Removebutton.TabIndex = 5;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            // 
            // PlaceOrderbutton
            // 
            this.PlaceOrderbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlaceOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderbutton.Location = new System.Drawing.Point(93, 466);
            this.PlaceOrderbutton.Name = "PlaceOrderbutton";
            this.PlaceOrderbutton.Size = new System.Drawing.Size(128, 34);
            this.PlaceOrderbutton.TabIndex = 3;
            this.PlaceOrderbutton.Text = "Place Order";
            this.PlaceOrderbutton.UseVisualStyleBackColor = false;
            // 
            // CancOrderbutton
            // 
            this.CancOrderbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancOrderbutton.Location = new System.Drawing.Point(293, 466);
            this.CancOrderbutton.Name = "CancOrderbutton";
            this.CancOrderbutton.Size = new System.Drawing.Size(128, 34);
            this.CancOrderbutton.TabIndex = 4;
            this.CancOrderbutton.Text = "Cancel Order";
            this.CancOrderbutton.UseVisualStyleBackColor = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(731, 534);
            this.Controls.Add(this.CancOrderbutton);
            this.Controls.Add(this.PlaceOrderbutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.ItemCodetextBox);
            this.Controls.Add(this.OrderLbl);
            this.Controls.Add(this.ItemCodeLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Orders";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemCodeLbl;
        private System.Windows.Forms.Label OrderLbl;
        private System.Windows.Forms.TextBox ItemCodetextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button PlaceOrderbutton;
        private System.Windows.Forms.Button CancOrderbutton;
    }
}