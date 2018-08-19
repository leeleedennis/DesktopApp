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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.ManageGridView = new System.Windows.Forms.DataGridView();
            this.txtItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txthand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtavailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderPointMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderPointMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityonHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityonOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityonAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markupLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new DesktopApp.InventoryDataSet();
            this.ItemCodeLbl = new System.Windows.Forms.Label();
            this.ItemCodetextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.inventory_ListTableAdapter = new DesktopApp.InventoryDataSetTableAdapters.Inventory_ListTableAdapter();
            this.DataSet1 = new DesktopApp.DataSet1();
            this.Inventory_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ManageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_ListBindingSource)).BeginInit();
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
            // ManageGridView
            // 
            this.ManageGridView.AutoGenerateColumns = false;
            this.ManageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtItemId,
            this.txtcode,
            this.txttype,
            this.txtdescrip,
            this.txtvendor,
            this.txtmin,
            this.txtmax,
            this.txthand,
            this.txtorder,
            this.txtavailable,
            this.txtmark,
            this.txtcost,
            this.itemidDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.inventTypeDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.prefVendorDataGridViewTextBoxColumn,
            this.reorderPointMinDataGridViewTextBoxColumn,
            this.reorderPointMaxDataGridViewTextBoxColumn,
            this.quantityonHandDataGridViewTextBoxColumn,
            this.quantityonOrderDataGridViewTextBoxColumn,
            this.quantityonAvailableDataGridViewTextBoxColumn,
            this.markupLevelDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.ManageGridView.DataSource = this.inventoryListBindingSource;
            this.ManageGridView.Location = new System.Drawing.Point(12, 199);
            this.ManageGridView.Name = "ManageGridView";
            this.ManageGridView.Size = new System.Drawing.Size(801, 254);
            this.ManageGridView.TabIndex = 2;
            this.ManageGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageGridView_CellValueChanged);
            this.ManageGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageGridView_KeyDown);
            // 
            // txtItemId
            // 
            this.txtItemId.DataPropertyName = "Item_id";
            this.txtItemId.HeaderText = "ItemID";
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Visible = false;
            // 
            // txtcode
            // 
            this.txtcode.DataPropertyName = "Item_Code";
            this.txtcode.HeaderText = "Item Code";
            this.txtcode.Name = "txtcode";
            this.txtcode.Visible = false;
            // 
            // txttype
            // 
            this.txttype.DataPropertyName = "Invent_Type";
            this.txttype.HeaderText = "Inventory Type";
            this.txttype.Name = "txttype";
            this.txttype.Visible = false;
            // 
            // txtdescrip
            // 
            this.txtdescrip.DataPropertyName = "Item_Description";
            this.txtdescrip.HeaderText = "Item Description";
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Visible = false;
            // 
            // txtvendor
            // 
            this.txtvendor.DataPropertyName = "Pref_Vendor";
            this.txtvendor.HeaderText = "Preffered Vendor";
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Visible = false;
            // 
            // txtmin
            // 
            this.txtmin.DataPropertyName = "Reorder_Point_Min";
            this.txtmin.HeaderText = "Reorder Point Min";
            this.txtmin.Name = "txtmin";
            this.txtmin.Visible = false;
            // 
            // txtmax
            // 
            this.txtmax.DataPropertyName = "Reorder_Point_Max";
            this.txtmax.HeaderText = "Reorder Point Max";
            this.txtmax.Name = "txtmax";
            this.txtmax.Visible = false;
            // 
            // txthand
            // 
            this.txthand.DataPropertyName = "Quantity_on_Hand";
            this.txthand.HeaderText = "Quantity on Hand";
            this.txthand.Name = "txthand";
            this.txthand.Visible = false;
            // 
            // txtorder
            // 
            this.txtorder.DataPropertyName = "Quantity_on_Order";
            this.txtorder.HeaderText = "Quantity on Order";
            this.txtorder.Name = "txtorder";
            this.txtorder.Visible = false;
            // 
            // txtavailable
            // 
            this.txtavailable.DataPropertyName = "Quantity_on_Available";
            this.txtavailable.HeaderText = "Quantity Available";
            this.txtavailable.Name = "txtavailable";
            this.txtavailable.Visible = false;
            // 
            // txtmark
            // 
            this.txtmark.DataPropertyName = "Mark_up_Level";
            this.txtmark.HeaderText = "Mark up Level";
            this.txtmark.Name = "txtmark";
            this.txtmark.Visible = false;
            // 
            // txtcost
            // 
            this.txtcost.DataPropertyName = "Cost";
            this.txtcost.HeaderText = "Cost";
            this.txtcost.Name = "txtcost";
            this.txtcost.Visible = false;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "Item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "Item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemidDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "Item_Code";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "Item_Code";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            // 
            // inventTypeDataGridViewTextBoxColumn
            // 
            this.inventTypeDataGridViewTextBoxColumn.DataPropertyName = "Invent_Type";
            this.inventTypeDataGridViewTextBoxColumn.HeaderText = "Invent_Type";
            this.inventTypeDataGridViewTextBoxColumn.Name = "inventTypeDataGridViewTextBoxColumn";
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item_Description";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item_Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            // 
            // prefVendorDataGridViewTextBoxColumn
            // 
            this.prefVendorDataGridViewTextBoxColumn.DataPropertyName = "Pref_Vendor";
            this.prefVendorDataGridViewTextBoxColumn.HeaderText = "Pref_Vendor";
            this.prefVendorDataGridViewTextBoxColumn.Name = "prefVendorDataGridViewTextBoxColumn";
            // 
            // reorderPointMinDataGridViewTextBoxColumn
            // 
            this.reorderPointMinDataGridViewTextBoxColumn.DataPropertyName = "Reorder_Point_Min";
            this.reorderPointMinDataGridViewTextBoxColumn.HeaderText = "Reorder_Point_Min";
            this.reorderPointMinDataGridViewTextBoxColumn.Name = "reorderPointMinDataGridViewTextBoxColumn";
            // 
            // reorderPointMaxDataGridViewTextBoxColumn
            // 
            this.reorderPointMaxDataGridViewTextBoxColumn.DataPropertyName = "Reorder_Point_Max";
            this.reorderPointMaxDataGridViewTextBoxColumn.HeaderText = "Reorder_Point_Max";
            this.reorderPointMaxDataGridViewTextBoxColumn.Name = "reorderPointMaxDataGridViewTextBoxColumn";
            // 
            // quantityonHandDataGridViewTextBoxColumn
            // 
            this.quantityonHandDataGridViewTextBoxColumn.DataPropertyName = "Quantity_on_Hand";
            this.quantityonHandDataGridViewTextBoxColumn.HeaderText = "Quantity_on_Hand";
            this.quantityonHandDataGridViewTextBoxColumn.Name = "quantityonHandDataGridViewTextBoxColumn";
            // 
            // quantityonOrderDataGridViewTextBoxColumn
            // 
            this.quantityonOrderDataGridViewTextBoxColumn.DataPropertyName = "Quantity_on_Order";
            this.quantityonOrderDataGridViewTextBoxColumn.HeaderText = "Quantity_on_Order";
            this.quantityonOrderDataGridViewTextBoxColumn.Name = "quantityonOrderDataGridViewTextBoxColumn";
            // 
            // quantityonAvailableDataGridViewTextBoxColumn
            // 
            this.quantityonAvailableDataGridViewTextBoxColumn.DataPropertyName = "Quantity_on_Available";
            this.quantityonAvailableDataGridViewTextBoxColumn.HeaderText = "Quantity_on_Available";
            this.quantityonAvailableDataGridViewTextBoxColumn.Name = "quantityonAvailableDataGridViewTextBoxColumn";
            // 
            // markupLevelDataGridViewTextBoxColumn
            // 
            this.markupLevelDataGridViewTextBoxColumn.DataPropertyName = "Mark_up_Level";
            this.markupLevelDataGridViewTextBoxColumn.HeaderText = "Mark_up_Level";
            this.markupLevelDataGridViewTextBoxColumn.Name = "markupLevelDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // inventoryListBindingSource
            // 
            this.inventoryListBindingSource.DataMember = "Inventory List";
            this.inventoryListBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.ItemCodetextBox.TextChanged += new System.EventHandler(this.ItemCodetextBox_TextChanged);
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
            this.Removebutton.Location = new System.Drawing.Point(533, 482);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(128, 34);
            this.Removebutton.TabIndex = 4;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Updatebutton.Location = new System.Drawing.Point(300, 482);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(128, 34);
            this.Updatebutton.TabIndex = 3;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // inventory_ListTableAdapter
            // 
            this.inventory_ListTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Inventory_ListBindingSource
            // 
            this.Inventory_ListBindingSource.DataMember = "Inventory List";
            this.Inventory_ListBindingSource.DataSource = this.DataSet1;
            // 
            // ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(850, 534);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.ItemCodetextBox);
            this.Controls.Add(this.ItemCodeLbl);
            this.Controls.Add(this.ManageGridView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "ManageInventory";
            this.Text = "Manage Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageInventory_FormClosing);
            this.Load += new System.EventHandler(this.ManageInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_ListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ManageGridView;
        private System.Windows.Forms.Label ItemCodeLbl;
        private System.Windows.Forms.TextBox ItemCodetextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button Updatebutton;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryListBindingSource;
        private InventoryDataSetTableAdapters.Inventory_ListTableAdapter inventory_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn txthand;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtavailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderPointMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderPointMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityonHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityonOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityonAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markupLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource Inventory_ListBindingSource;
        private DataSet1 DataSet1;
    }
}