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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(722, 603);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(41, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "EXCHANGE RATE";
            // 
            // shiptextBox
            // 
            this.shiptextBox.Location = new System.Drawing.Point(768, 116);
            this.shiptextBox.Multiline = true;
            this.shiptextBox.Name = "shiptextBox";
            this.shiptextBox.Size = new System.Drawing.Size(179, 124);
            this.shiptextBox.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 150);
            this.dataGridView1.TabIndex = 52;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1012, 749);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}