﻿namespace DesktopApp
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purcheaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnOderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(752, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryListToolStripMenuItem,
            this.manageInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            // 
            // inventoryListToolStripMenuItem
            // 
            this.inventoryListToolStripMenuItem.Name = "inventoryListToolStripMenuItem";
            this.inventoryListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.inventoryListToolStripMenuItem.Text = "Inventory List";
            this.inventoryListToolStripMenuItem.Click += new System.EventHandler(this.inventoryListToolStripMenuItem_Click);
            // 
            // manageInventoryToolStripMenuItem
            // 
            this.manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            this.manageInventoryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            this.manageInventoryToolStripMenuItem.Click += new System.EventHandler(this.manageInventoryToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.resetPasswordToolStripMenuItem,
            this.manageUserToolStripMenuItem1});
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.manageUserToolStripMenuItem.Text = "&User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem1
            // 
            this.manageUserToolStripMenuItem1.Name = "manageUserToolStripMenuItem1";
            this.manageUserToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.manageUserToolStripMenuItem1.Text = "Manage User";
            this.manageUserToolStripMenuItem1.Click += new System.EventHandler(this.manageUserToolStripMenuItem1_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purcheaseOrderToolStripMenuItem,
            this.returnOderToolStripMenuItem,
            this.ordersToolStripMenuItem1,
            this.estimateToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.creditMemoToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ordersToolStripMenuItem.Text = "M&anage Order";
            // 
            // purcheaseOrderToolStripMenuItem
            // 
            this.purcheaseOrderToolStripMenuItem.Name = "purcheaseOrderToolStripMenuItem";
            this.purcheaseOrderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.purcheaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purcheaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purcheaseOrderToolStripMenuItem_Click);
            // 
            // returnOderToolStripMenuItem
            // 
            this.returnOderToolStripMenuItem.Name = "returnOderToolStripMenuItem";
            this.returnOderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.returnOderToolStripMenuItem.Text = "Return Oder";
            this.returnOderToolStripMenuItem.Click += new System.EventHandler(this.returnOderToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.ordersToolStripMenuItem1.Text = "Orders";
            this.ordersToolStripMenuItem1.Click += new System.EventHandler(this.ordersToolStripMenuItem1_Click);
            // 
            // estimateToolStripMenuItem
            // 
            this.estimateToolStripMenuItem.Name = "estimateToolStripMenuItem";
            this.estimateToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.estimateToolStripMenuItem.Text = "Estimate";
            this.estimateToolStripMenuItem.Click += new System.EventHandler(this.estimateToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // creditMemoToolStripMenuItem
            // 
            this.creditMemoToolStripMenuItem.Name = "creditMemoToolStripMenuItem";
            this.creditMemoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.creditMemoToolStripMenuItem.Text = "Credit Memo";
            this.creditMemoToolStripMenuItem.Click += new System.EventHandler(this.creditMemoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.inventoryToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(752, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Administrator";
            this.Text = "Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purcheaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnOderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}



