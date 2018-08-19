namespace DesktopApp
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.inventoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loadbtn = new System.Windows.Forms.Button();
            this.inventoryDataSet = new DesktopApp.InventoryDataSet();
            this.inventoryListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_ListTableAdapter = new DesktopApp.InventoryDataSetTableAdapters.Inventory_ListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryListBindingSource
            // 
            this.inventoryListBindingSource.DataSource = typeof(DesktopApp.Inventory_List);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "stock";
            reportDataSource1.Value = this.inventoryListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DesktopApp.StockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(902, 410);
            this.reportViewer1.TabIndex = 7;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(783, 418);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(90, 24);
            this.loadbtn.TabIndex = 8;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryListBindingSource1
            // 
            this.inventoryListBindingSource1.DataMember = "Inventory List";
            this.inventoryListBindingSource1.DataSource = this.inventoryDataSet;
            // 
            // inventory_ListTableAdapter
            // 
            this.inventory_ListTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryListBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.BindingSource inventoryListBindingSource;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryListBindingSource1;
        private InventoryDataSetTableAdapters.Inventory_ListTableAdapter inventory_ListTableAdapter;
    }
}