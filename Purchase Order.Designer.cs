namespace DesktopApp
{
    partial class PurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.purchaseOrderlabel = new System.Windows.Forms.Label();
            this.generatebutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.venaddtextBox = new System.Windows.Forms.TextBox();
            this.potextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.shiplabel = new System.Windows.Forms.Label();
            this.polabel = new System.Windows.Forms.Label();
            this.vendorlabel = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.TTtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VENtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.abtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shiptextBox = new System.Windows.Forms.TextBox();
            this.PurchaseGridView = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMeasure1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtRate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMeasure = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet1 = new DesktopApp.InventoryDataSet1();
            this.orderTableAdapter = new DesktopApp.InventoryDataSet1TableAdapters.OrderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderlabel
            // 
            this.purchaseOrderlabel.AutoSize = true;
            this.purchaseOrderlabel.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.purchaseOrderlabel.Location = new System.Drawing.Point(37, 27);
            this.purchaseOrderlabel.Name = "purchaseOrderlabel";
            this.purchaseOrderlabel.Size = new System.Drawing.Size(200, 34);
            this.purchaseOrderlabel.TabIndex = 1;
            this.purchaseOrderlabel.Text = "Purchase Order";
            // 
            // generatebutton
            // 
            this.generatebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generatebutton.Location = new System.Drawing.Point(733, 675);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(96, 34);
            this.generatebutton.TabIndex = 13;
            this.generatebutton.Text = "Generate";
            this.generatebutton.UseVisualStyleBackColor = false;
            this.generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Resetbutton.Location = new System.Drawing.Point(862, 675);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(96, 34);
            this.Resetbutton.TabIndex = 15;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(835, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // venaddtextBox
            // 
            this.venaddtextBox.Location = new System.Drawing.Point(580, 116);
            this.venaddtextBox.Multiline = true;
            this.venaddtextBox.Name = "venaddtextBox";
            this.venaddtextBox.Size = new System.Drawing.Size(182, 124);
            this.venaddtextBox.TabIndex = 42;
            // 
            // potextBox
            // 
            this.potextBox.Location = new System.Drawing.Point(440, 169);
            this.potextBox.Name = "potextBox";
            this.potextBox.Size = new System.Drawing.Size(104, 20);
            this.potextBox.TabIndex = 41;
            this.potextBox.Text = "6639";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 40;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // shiplabel
            // 
            this.shiplabel.AutoSize = true;
            this.shiplabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.shiplabel.Location = new System.Drawing.Point(765, 94);
            this.shiplabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shiplabel.Name = "shiplabel";
            this.shiplabel.Size = new System.Drawing.Size(63, 16);
            this.shiplabel.TabIndex = 39;
            this.shiplabel.Text = "SHIP TO:";
            // 
            // polabel
            // 
            this.polabel.AutoSize = true;
            this.polabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.polabel.Location = new System.Drawing.Point(437, 150);
            this.polabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.polabel.Name = "polabel";
            this.polabel.Size = new System.Drawing.Size(56, 16);
            this.polabel.TabIndex = 38;
            this.polabel.Text = "P.O NO.";
            // 
            // vendorlabel
            // 
            this.vendorlabel.AutoSize = true;
            this.vendorlabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.vendorlabel.Location = new System.Drawing.Point(577, 94);
            this.vendorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendorlabel.Name = "vendorlabel";
            this.vendorlabel.Size = new System.Drawing.Size(67, 16);
            this.vendorlabel.TabIndex = 37;
            this.vendorlabel.Text = "VENDOR:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DateLbl.Location = new System.Drawing.Point(437, 94);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(45, 16);
            this.DateLbl.TabIndex = 36;
            this.DateLbl.Text = "DATE:";
            // 
            // TTtextBox
            // 
            this.TTtextBox.Location = new System.Drawing.Point(854, 603);
            this.TTtextBox.Name = "TTtextBox";
            this.TTtextBox.Size = new System.Drawing.Size(104, 20);
            this.TTtextBox.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(722, 607);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "TOTAL       JMD";
            // 
            // VENtextBox
            // 
            this.VENtextBox.Location = new System.Drawing.Point(43, 529);
            this.VENtextBox.Multiline = true;
            this.VENtextBox.Name = "VENtextBox";
            this.VENtextBox.Size = new System.Drawing.Size(281, 94);
            this.VENtextBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(41, 509);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "VENDOR MESSAGE";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(275, 449);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(42, 20);
            this.textBox6.TabIndex = 48;
            this.textBox6.Text = "JMD";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // abtextBox
            // 
            this.abtextBox.Location = new System.Drawing.Point(174, 449);
            this.abtextBox.Name = "abtextBox";
            this.abtextBox.Size = new System.Drawing.Size(104, 20);
            this.abtextBox.TabIndex = 47;
            this.abtextBox.Text = "$135";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Exchange Rate 1USD";
            // 
            // shiptextBox
            // 
            this.shiptextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiptextBox.Location = new System.Drawing.Point(768, 116);
            this.shiptextBox.Multiline = true;
            this.shiptextBox.Name = "shiptextBox";
            this.shiptextBox.Size = new System.Drawing.Size(179, 124);
            this.shiptextBox.TabIndex = 51;
            this.shiptextBox.Text = "Atlantic Industrial Electric      138D Maxfield Avenue          Kingston 10      " +
    "                          Jamaica";
            this.shiptextBox.TextChanged += new System.EventHandler(this.shiptextBox_TextChanged);
            // 
            // PurchaseGridView
            // 
            this.PurchaseGridView.AutoGenerateColumns = false;
            this.PurchaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtOrderID,
            this.txtItem,
            this.txtDescription,
            this.txtQuantity1,
            this.cbxMeasure1,
            this.txtRate1,
            this.txtCustomer,
            this.txtAmount1,
            this.orderIdDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.txtQuantity,
            this.cbxMeasure,
            this.txtRate,
            this.customerDataGridViewTextBoxColumn,
            this.txtAmount});
            this.PurchaseGridView.DataSource = this.orderBindingSource;
            this.PurchaseGridView.Location = new System.Drawing.Point(43, 269);
            this.PurchaseGridView.Name = "PurchaseGridView";
            this.PurchaseGridView.Size = new System.Drawing.Size(904, 165);
            this.PurchaseGridView.TabIndex = 52;
            this.PurchaseGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseGridView_CellEndEdit);
            this.PurchaseGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.PurchaseGridView_CellStateChanged);
            this.PurchaseGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PurchaseGridView_CellValidating);
            // 
            // txtOrderID
            // 
            this.txtOrderID.DataPropertyName = "OrderId";
            this.txtOrderID.HeaderText = "OrderID";
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Visible = false;
            // 
            // txtItem
            // 
            this.txtItem.DataPropertyName = "Item";
            this.txtItem.HeaderText = "Item";
            this.txtItem.Name = "txtItem";
            this.txtItem.Visible = false;
            this.txtItem.Width = 150;
            // 
            // txtDescription
            // 
            this.txtDescription.DataPropertyName = "Description";
            this.txtDescription.HeaderText = "Description";
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Visible = false;
            this.txtDescription.Width = 190;
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.DataPropertyName = "Quantity";
            this.txtQuantity1.HeaderText = "Quantity";
            this.txtQuantity1.Name = "txtQuantity1";
            this.txtQuantity1.Visible = false;
            this.txtQuantity1.Width = 80;
            // 
            // cbxMeasure1
            // 
            this.cbxMeasure1.DataPropertyName = "UnitId";
            this.cbxMeasure1.HeaderText = "U/M";
            this.cbxMeasure1.Name = "cbxMeasure1";
            this.cbxMeasure1.Visible = false;
            // 
            // txtRate1
            // 
            this.txtRate1.DataPropertyName = "Rate";
            this.txtRate1.HeaderText = "Rate";
            this.txtRate1.Name = "txtRate1";
            this.txtRate1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtRate1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtRate1.Visible = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DataPropertyName = "Customer";
            this.txtCustomer.HeaderText = "Customer";
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Visible = false;
            this.txtCustomer.Width = 140;
            // 
            // txtAmount1
            // 
            this.txtAmount1.DataPropertyName = "Amount";
            this.txtAmount1.HeaderText = "Amount";
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.Visible = false;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 190;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataPropertyName = "Quantity";
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Width = 80;
            // 
            // cbxMeasure
            // 
            this.cbxMeasure.DataPropertyName = "UnitId";
            this.cbxMeasure.HeaderText = "U/M";
            this.cbxMeasure.Name = "cbxMeasure";
            this.cbxMeasure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbxMeasure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtRate
            // 
            this.txtRate.DataPropertyName = "Rate";
            this.txtRate.HeaderText = "Rate";
            this.txtRate.Name = "txtRate";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 140;
            // 
            // txtAmount
            // 
            this.txtAmount.DataPropertyName = "Amount";
            this.txtAmount.HeaderText = "Amount";
            this.txtAmount.Name = "txtAmount";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.inventoryDataSet1;
            // 
            // inventoryDataSet1
            // 
            this.inventoryDataSet1.DataSetName = "InventoryDataSet1";
            this.inventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(612, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(837, 603);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "$";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1012, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PurchaseGridView);
            this.Controls.Add(this.shiptextBox);
            this.Controls.Add(this.VENtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.abtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TTtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.venaddtextBox);
            this.Controls.Add(this.potextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.shiplabel);
            this.Controls.Add(this.polabel);
            this.Controls.Add(this.vendorlabel);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.purchaseOrderlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "PurchaseOrder";
            this.Text = "Purchase Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchaseOrder_FormClosing);
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purchaseOrderlabel;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox venaddtextBox;
        private System.Windows.Forms.TextBox potextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label shiplabel;
        private System.Windows.Forms.Label polabel;
        private System.Windows.Forms.Label vendorlabel;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.TextBox TTtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VENtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox abtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shiptextBox;
        private System.Windows.Forms.DataGridView PurchaseGridView;
        private InventoryDataSet1 inventoryDataSet1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private InventoryDataSet1TableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxMeasure1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}