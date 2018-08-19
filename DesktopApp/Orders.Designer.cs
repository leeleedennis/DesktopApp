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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.ItemCodeLbl = new System.Windows.Forms.Label();
            this.OrderLbl = new System.Windows.Forms.Label();
            this.ItemCodetextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.txtselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet2 = new DesktopApp.InventoryDataSet2();
            this.Removebutton = new System.Windows.Forms.Button();
            this.PlaceOrderbutton = new System.Windows.Forms.Button();
            this.orderTableAdapter = new DesktopApp.InventoryDataSet2TableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new DesktopApp.InventoryDataSet2TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemCodeLbl
            // 
            this.ItemCodeLbl.AutoSize = true;
            this.ItemCodeLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ItemCodeLbl.Location = new System.Drawing.Point(56, 139);
            this.ItemCodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCodeLbl.Name = "ItemCodeLbl";
            this.ItemCodeLbl.Size = new System.Drawing.Size(83, 20);
            this.ItemCodeLbl.TabIndex = 6;
            this.ItemCodeLbl.Text = "Customer:";
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
            this.ItemCodetextBox.TextChanged += new System.EventHandler(this.ItemCodetextBox_TextChanged);
            this.ItemCodetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCodetextBox_KeyPress);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(597, 133);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(96, 34);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "View";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToAddRows = false;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtselect,
            this.txtItem,
            this.txtdescription,
            this.txtQuantity,
            this.txtRate,
            this.txtCustomer,
            this.txtAmount});
            this.OrderGridView.Location = new System.Drawing.Point(46, 193);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridView.Size = new System.Drawing.Size(647, 190);
            this.OrderGridView.TabIndex = 17;
            this.OrderGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrderGridView_MouseClick);
            // 
            // txtselect
            // 
            this.txtselect.HeaderText = "Select";
            this.txtselect.Name = "txtselect";
            this.txtselect.Width = 50;
            // 
            // txtItem
            // 
            this.txtItem.HeaderText = "Item";
            this.txtItem.Name = "txtItem";
            // 
            // txtdescription
            // 
            this.txtdescription.HeaderText = "Description";
            this.txtdescription.Name = "txtdescription";
            // 
            // txtQuantity
            // 
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            // 
            // txtRate
            // 
            this.txtRate.HeaderText = "Rate";
            this.txtRate.Name = "txtRate";
            // 
            // txtCustomer
            // 
            this.txtCustomer.HeaderText = "Customer";
            this.txtCustomer.Name = "txtCustomer";
            // 
            // txtAmount
            // 
            this.txtAmount.HeaderText = "Amount";
            this.txtAmount.Name = "txtAmount";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.inventoryDataSet2;
            // 
            // inventoryDataSet2
            // 
            this.inventoryDataSet2.DataSetName = "InventoryDataSet2";
            this.inventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(506, 466);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(128, 34);
            this.Removebutton.TabIndex = 5;
            this.Removebutton.Text = "Delete Order";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // PlaceOrderbutton
            // 
            this.PlaceOrderbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlaceOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderbutton.Location = new System.Drawing.Point(320, 466);
            this.PlaceOrderbutton.Name = "PlaceOrderbutton";
            this.PlaceOrderbutton.Size = new System.Drawing.Size(128, 34);
            this.PlaceOrderbutton.TabIndex = 3;
            this.PlaceOrderbutton.Text = "Place Order";
            this.PlaceOrderbutton.UseVisualStyleBackColor = false;
            this.PlaceOrderbutton.Click += new System.EventHandler(this.PlaceOrderbutton_Click);
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Inventory_ListTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.UpdateOrder = DesktopApp.InventoryDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(738, 534);
            this.Controls.Add(this.PlaceOrderbutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.OrderGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemCodeLbl;
        private System.Windows.Forms.Label OrderLbl;
        private System.Windows.Forms.TextBox ItemCodetextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button PlaceOrderbutton;
        private InventoryDataSet2 inventoryDataSet2;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private InventoryDataSet2TableAdapters.OrderTableAdapter orderTableAdapter;
        private InventoryDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount;
    }
}