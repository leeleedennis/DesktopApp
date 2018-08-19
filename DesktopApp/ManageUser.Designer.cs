namespace DesktopApp
{
    partial class ManageUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUser));
            this.ManageUserlabel = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SearchdataGridView = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet5 = new DesktopApp.InventoryDataSet5();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.inventoryDataSet4 = new DesktopApp.InventoryDataSet4();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DesktopApp.InventoryDataSet4TableAdapters.UsersTableAdapter();
            this.usersTableAdapter1 = new DesktopApp.InventoryDataSet5TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageUserlabel
            // 
            this.ManageUserlabel.AutoSize = true;
            this.ManageUserlabel.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.ManageUserlabel.Location = new System.Drawing.Point(37, 27);
            this.ManageUserlabel.Name = "ManageUserlabel";
            this.ManageUserlabel.Size = new System.Drawing.Size(174, 34);
            this.ManageUserlabel.TabIndex = 2;
            this.ManageUserlabel.Text = "Manage User";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.NameLbl.Location = new System.Drawing.Point(27, 135);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(56, 20);
            this.NameLbl.TabIndex = 9;
            this.NameLbl.Text = "Name:";
            // 
            // SearchdataGridView
            // 
            this.SearchdataGridView.AutoGenerateColumns = false;
            this.SearchdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn});
            this.SearchdataGridView.DataSource = this.usersBindingSource1;
            this.SearchdataGridView.Location = new System.Drawing.Point(31, 187);
            this.SearchdataGridView.Name = "SearchdataGridView";
            this.SearchdataGridView.Size = new System.Drawing.Size(633, 150);
            this.SearchdataGridView.TabIndex = 10;
            this.SearchdataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchdataGridView_KeyDown);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "F_Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "L_Name";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Date_Created";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date_Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "Created_By";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "Created_By";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.inventoryDataSet5;
            // 
            // inventoryDataSet5
            // 
            this.inventoryDataSet5.DataSetName = "InventoryDataSet5";
            this.inventoryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(236, 378);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(96, 34);
            this.Deletebutton.TabIndex = 8;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(402, 378);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(96, 34);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(90, 135);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(459, 31);
            this.searchtextBox.TabIndex = 11;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // inventoryDataSet4
            // 
            this.inventoryDataSet4.DataSetName = "InventoryDataSet4";
            this.inventoryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.inventoryDataSet4;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(722, 459);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.SearchdataGridView);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ManageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageUserlabel;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.DataGridView SearchdataGridView;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private InventoryDataSet4 inventoryDataSet4;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private InventoryDataSet4TableAdapters.UsersTableAdapter usersTableAdapter;
        private InventoryDataSet5 inventoryDataSet5;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private InventoryDataSet5TableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
    }
}