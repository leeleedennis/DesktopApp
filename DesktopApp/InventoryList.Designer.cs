namespace DesktopApp
{
    partial class InventoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryList));
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryType = new System.Windows.Forms.Label();
            this.QuantityHandLbl = new System.Windows.Forms.Label();
            this.QuantityOrderLbl = new System.Windows.Forms.Label();
            this.ItemCodeLbl = new System.Windows.Forms.Label();
            this.QuantityAvailLbl = new System.Windows.Forms.Label();
            this.ItemDesLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.maxReorderLbl = new System.Windows.Forms.Label();
            this.minReorderlbl = new System.Windows.Forms.Label();
            this.PrefVendorLbl = new System.Windows.Forms.Label();
            this.MarkUpLvlLbl = new System.Windows.Forms.Label();
            this.ItemtextBox = new System.Windows.Forms.TextBox();
            this.InvenTypetextBox = new System.Windows.Forms.TextBox();
            this.ItemDesciptextBox = new System.Windows.Forms.TextBox();
            this.MinReordertextBox = new System.Windows.Forms.TextBox();
            this.QOAtextBox = new System.Windows.Forms.TextBox();
            this.MaxReordertextBox = new System.Windows.Forms.TextBox();
            this.MarkupLvltextBox = new System.Windows.Forms.TextBox();
            this.PrefVendortextBox = new System.Windows.Forms.TextBox();
            this.QOOtextBox = new System.Windows.Forms.TextBox();
            this.QOHtextBox = new System.Windows.Forms.TextBox();
            this.CosttextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory List";
            // 
            // InventoryType
            // 
            this.InventoryType.AutoSize = true;
            this.InventoryType.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.InventoryType.Location = new System.Drawing.Point(73, 143);
            this.InventoryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InventoryType.Name = "InventoryType";
            this.InventoryType.Size = new System.Drawing.Size(125, 20);
            this.InventoryType.TabIndex = 1;
            this.InventoryType.Text = "Inventory Type:";
            // 
            // QuantityHandLbl
            // 
            this.QuantityHandLbl.AutoSize = true;
            this.QuantityHandLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.QuantityHandLbl.Location = new System.Drawing.Point(68, 413);
            this.QuantityHandLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityHandLbl.Name = "QuantityHandLbl";
            this.QuantityHandLbl.Size = new System.Drawing.Size(146, 20);
            this.QuantityHandLbl.TabIndex = 2;
            this.QuantityHandLbl.Text = "Quantity On Hand:";
            // 
            // QuantityOrderLbl
            // 
            this.QuantityOrderLbl.AutoSize = true;
            this.QuantityOrderLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.QuantityOrderLbl.Location = new System.Drawing.Point(68, 467);
            this.QuantityOrderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityOrderLbl.Name = "QuantityOrderLbl";
            this.QuantityOrderLbl.Size = new System.Drawing.Size(149, 20);
            this.QuantityOrderLbl.TabIndex = 3;
            this.QuantityOrderLbl.Text = "Quantity On Order:";
            // 
            // ItemCodeLbl
            // 
            this.ItemCodeLbl.AutoSize = true;
            this.ItemCodeLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ItemCodeLbl.Location = new System.Drawing.Point(73, 90);
            this.ItemCodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCodeLbl.Name = "ItemCodeLbl";
            this.ItemCodeLbl.Size = new System.Drawing.Size(89, 20);
            this.ItemCodeLbl.TabIndex = 4;
            this.ItemCodeLbl.Text = "Item Code:";
            // 
            // QuantityAvailLbl
            // 
            this.QuantityAvailLbl.AutoSize = true;
            this.QuantityAvailLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.QuantityAvailLbl.Location = new System.Drawing.Point(73, 524);
            this.QuantityAvailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityAvailLbl.Name = "QuantityAvailLbl";
            this.QuantityAvailLbl.Size = new System.Drawing.Size(144, 20);
            this.QuantityAvailLbl.TabIndex = 5;
            this.QuantityAvailLbl.Text = "Quantity Available:";
            // 
            // ItemDesLbl
            // 
            this.ItemDesLbl.AutoSize = true;
            this.ItemDesLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ItemDesLbl.Location = new System.Drawing.Point(73, 196);
            this.ItemDesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemDesLbl.Name = "ItemDesLbl";
            this.ItemDesLbl.Size = new System.Drawing.Size(133, 20);
            this.ItemDesLbl.TabIndex = 6;
            this.ItemDesLbl.Text = "Item Description:";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.CostLbl.Location = new System.Drawing.Point(73, 629);
            this.CostLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(46, 20);
            this.CostLbl.TabIndex = 7;
            this.CostLbl.Text = "Cost:";
            // 
            // maxReorderLbl
            // 
            this.maxReorderLbl.AutoSize = true;
            this.maxReorderLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.maxReorderLbl.Location = new System.Drawing.Point(65, 363);
            this.maxReorderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxReorderLbl.Name = "maxReorderLbl";
            this.maxReorderLbl.Size = new System.Drawing.Size(157, 20);
            this.maxReorderLbl.TabIndex = 8;
            this.maxReorderLbl.Text = "Re-order Point Max:";
            // 
            // minReorderlbl
            // 
            this.minReorderlbl.AutoSize = true;
            this.minReorderlbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.minReorderlbl.Location = new System.Drawing.Point(68, 307);
            this.minReorderlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minReorderlbl.Name = "minReorderlbl";
            this.minReorderlbl.Size = new System.Drawing.Size(154, 20);
            this.minReorderlbl.TabIndex = 9;
            this.minReorderlbl.Text = "Re-order Point Min:";
            // 
            // PrefVendorLbl
            // 
            this.PrefVendorLbl.AutoSize = true;
            this.PrefVendorLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.PrefVendorLbl.Location = new System.Drawing.Point(73, 253);
            this.PrefVendorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrefVendorLbl.Name = "PrefVendorLbl";
            this.PrefVendorLbl.Size = new System.Drawing.Size(137, 20);
            this.PrefVendorLbl.TabIndex = 10;
            this.PrefVendorLbl.Text = "Preferred Vendor:";
            // 
            // MarkUpLvlLbl
            // 
            this.MarkUpLvlLbl.AutoSize = true;
            this.MarkUpLvlLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.MarkUpLvlLbl.Location = new System.Drawing.Point(73, 580);
            this.MarkUpLvlLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarkUpLvlLbl.Name = "MarkUpLvlLbl";
            this.MarkUpLvlLbl.Size = new System.Drawing.Size(125, 20);
            this.MarkUpLvlLbl.TabIndex = 11;
            this.MarkUpLvlLbl.Text = "Mark-Up Level:";
            // 
            // ItemtextBox
            // 
            this.ItemtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemtextBox.Location = new System.Drawing.Point(239, 89);
            this.ItemtextBox.Multiline = true;
            this.ItemtextBox.Name = "ItemtextBox";
            this.ItemtextBox.Size = new System.Drawing.Size(300, 28);
            this.ItemtextBox.TabIndex = 1;
            // 
            // InvenTypetextBox
            // 
            this.InvenTypetextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvenTypetextBox.Location = new System.Drawing.Point(239, 142);
            this.InvenTypetextBox.Multiline = true;
            this.InvenTypetextBox.Name = "InvenTypetextBox";
            this.InvenTypetextBox.Size = new System.Drawing.Size(300, 28);
            this.InvenTypetextBox.TabIndex = 2;
            // 
            // ItemDesciptextBox
            // 
            this.ItemDesciptextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDesciptextBox.Location = new System.Drawing.Point(239, 195);
            this.ItemDesciptextBox.Multiline = true;
            this.ItemDesciptextBox.Name = "ItemDesciptextBox";
            this.ItemDesciptextBox.Size = new System.Drawing.Size(300, 28);
            this.ItemDesciptextBox.TabIndex = 3;
            // 
            // MinReordertextBox
            // 
            this.MinReordertextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinReordertextBox.Location = new System.Drawing.Point(239, 306);
            this.MinReordertextBox.Multiline = true;
            this.MinReordertextBox.Name = "MinReordertextBox";
            this.MinReordertextBox.Size = new System.Drawing.Size(300, 28);
            this.MinReordertextBox.TabIndex = 5;
            // 
            // QOAtextBox
            // 
            this.QOAtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QOAtextBox.Location = new System.Drawing.Point(239, 524);
            this.QOAtextBox.Multiline = true;
            this.QOAtextBox.Name = "QOAtextBox";
            this.QOAtextBox.Size = new System.Drawing.Size(300, 28);
            this.QOAtextBox.TabIndex = 9;
            // 
            // MaxReordertextBox
            // 
            this.MaxReordertextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxReordertextBox.Location = new System.Drawing.Point(239, 362);
            this.MaxReordertextBox.Multiline = true;
            this.MaxReordertextBox.Name = "MaxReordertextBox";
            this.MaxReordertextBox.Size = new System.Drawing.Size(300, 28);
            this.MaxReordertextBox.TabIndex = 6;
            // 
            // MarkupLvltextBox
            // 
            this.MarkupLvltextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkupLvltextBox.Location = new System.Drawing.Point(239, 580);
            this.MarkupLvltextBox.Multiline = true;
            this.MarkupLvltextBox.Name = "MarkupLvltextBox";
            this.MarkupLvltextBox.Size = new System.Drawing.Size(300, 28);
            this.MarkupLvltextBox.TabIndex = 10;
            // 
            // PrefVendortextBox
            // 
            this.PrefVendortextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefVendortextBox.Location = new System.Drawing.Point(239, 252);
            this.PrefVendortextBox.Multiline = true;
            this.PrefVendortextBox.Name = "PrefVendortextBox";
            this.PrefVendortextBox.Size = new System.Drawing.Size(300, 28);
            this.PrefVendortextBox.TabIndex = 4;
            // 
            // QOOtextBox
            // 
            this.QOOtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QOOtextBox.Location = new System.Drawing.Point(239, 466);
            this.QOOtextBox.Multiline = true;
            this.QOOtextBox.Name = "QOOtextBox";
            this.QOOtextBox.Size = new System.Drawing.Size(300, 28);
            this.QOOtextBox.TabIndex = 8;
            // 
            // QOHtextBox
            // 
            this.QOHtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QOHtextBox.Location = new System.Drawing.Point(239, 412);
            this.QOHtextBox.Multiline = true;
            this.QOHtextBox.Name = "QOHtextBox";
            this.QOHtextBox.Size = new System.Drawing.Size(300, 28);
            this.QOHtextBox.TabIndex = 7;
            // 
            // CosttextBox
            // 
            this.CosttextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosttextBox.Location = new System.Drawing.Point(239, 629);
            this.CosttextBox.Multiline = true;
            this.CosttextBox.Name = "CosttextBox";
            this.CosttextBox.Size = new System.Drawing.Size(300, 28);
            this.CosttextBox.TabIndex = 11;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Addbutton.Location = new System.Drawing.Point(202, 703);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(96, 34);
            this.Addbutton.TabIndex = 12;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Resetbutton.Location = new System.Drawing.Point(345, 703);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(96, 34);
            this.Resetbutton.TabIndex = 13;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // InventoryList
            // 
            this.AcceptButton = this.Addbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(625, 749);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.CosttextBox);
            this.Controls.Add(this.QOHtextBox);
            this.Controls.Add(this.QOOtextBox);
            this.Controls.Add(this.PrefVendortextBox);
            this.Controls.Add(this.MarkupLvltextBox);
            this.Controls.Add(this.MaxReordertextBox);
            this.Controls.Add(this.QOAtextBox);
            this.Controls.Add(this.MinReordertextBox);
            this.Controls.Add(this.ItemDesciptextBox);
            this.Controls.Add(this.InvenTypetextBox);
            this.Controls.Add(this.ItemtextBox);
            this.Controls.Add(this.MarkUpLvlLbl);
            this.Controls.Add(this.PrefVendorLbl);
            this.Controls.Add(this.minReorderlbl);
            this.Controls.Add(this.maxReorderLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.ItemDesLbl);
            this.Controls.Add(this.QuantityAvailLbl);
            this.Controls.Add(this.ItemCodeLbl);
            this.Controls.Add(this.QuantityOrderLbl);
            this.Controls.Add(this.QuantityHandLbl);
            this.Controls.Add(this.InventoryType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "InventoryList";
            this.Text = "Inventory List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InventoryType;
        private System.Windows.Forms.Label QuantityHandLbl;
        private System.Windows.Forms.Label QuantityOrderLbl;
        private System.Windows.Forms.Label ItemCodeLbl;
        private System.Windows.Forms.Label QuantityAvailLbl;
        private System.Windows.Forms.Label ItemDesLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label maxReorderLbl;
        private System.Windows.Forms.Label minReorderlbl;
        private System.Windows.Forms.Label PrefVendorLbl;
        private System.Windows.Forms.Label MarkUpLvlLbl;
        private System.Windows.Forms.TextBox ItemtextBox;
        private System.Windows.Forms.TextBox InvenTypetextBox;
        private System.Windows.Forms.TextBox ItemDesciptextBox;
        private System.Windows.Forms.TextBox MinReordertextBox;
        private System.Windows.Forms.TextBox QOAtextBox;
        private System.Windows.Forms.TextBox MaxReordertextBox;
        private System.Windows.Forms.TextBox MarkupLvltextBox;
        private System.Windows.Forms.TextBox PrefVendortextBox;
        private System.Windows.Forms.TextBox QOOtextBox;
        private System.Windows.Forms.TextBox QOHtextBox;
        private System.Windows.Forms.TextBox CosttextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Resetbutton;
    }
}