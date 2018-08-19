namespace DesktopApp
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            this.ReturnFormlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodslabel = new System.Windows.Forms.Label();
            this.customertextBox = new System.Windows.Forms.TextBox();
            this.companytextBox = new System.Windows.Forms.TextBox();
            this.customerinfolabel = new System.Windows.Forms.Label();
            this.conpanyinfoLbl = new System.Windows.Forms.Label();
            this.Genbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnFormlabel
            // 
            this.ReturnFormlabel.AutoSize = true;
            this.ReturnFormlabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnFormlabel.Location = new System.Drawing.Point(266, 28);
            this.ReturnFormlabel.Name = "ReturnFormlabel";
            this.ReturnFormlabel.Size = new System.Drawing.Size(159, 31);
            this.ReturnFormlabel.TabIndex = 2;
            this.ReturnFormlabel.Text = "Return Order";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 133);
            this.dataGridView1.TabIndex = 20;
            // 
            // goodslabel
            // 
            this.goodslabel.AutoSize = true;
            this.goodslabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.goodslabel.Location = new System.Drawing.Point(67, 330);
            this.goodslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodslabel.Name = "goodslabel";
            this.goodslabel.Size = new System.Drawing.Size(60, 20);
            this.goodslabel.TabIndex = 19;
            this.goodslabel.Text = "Goods:";
            // 
            // customertextBox
            // 
            this.customertextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customertextBox.Location = new System.Drawing.Point(384, 134);
            this.customertextBox.Multiline = true;
            this.customertextBox.Name = "customertextBox";
            this.customertextBox.Size = new System.Drawing.Size(304, 169);
            this.customertextBox.TabIndex = 18;
            // 
            // companytextBox
            // 
            this.companytextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companytextBox.Location = new System.Drawing.Point(69, 134);
            this.companytextBox.Multiline = true;
            this.companytextBox.Name = "companytextBox";
            this.companytextBox.Size = new System.Drawing.Size(304, 169);
            this.companytextBox.TabIndex = 17;
            // 
            // customerinfolabel
            // 
            this.customerinfolabel.AutoSize = true;
            this.customerinfolabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.customerinfolabel.Location = new System.Drawing.Point(380, 114);
            this.customerinfolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerinfolabel.Name = "customerinfolabel";
            this.customerinfolabel.Size = new System.Drawing.Size(118, 20);
            this.customerinfolabel.TabIndex = 16;
            this.customerinfolabel.Text = "Customer Info:";
            // 
            // conpanyinfoLbl
            // 
            this.conpanyinfoLbl.AutoSize = true;
            this.conpanyinfoLbl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.conpanyinfoLbl.Location = new System.Drawing.Point(65, 111);
            this.conpanyinfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conpanyinfoLbl.Name = "conpanyinfoLbl";
            this.conpanyinfoLbl.Size = new System.Drawing.Size(118, 20);
            this.conpanyinfoLbl.TabIndex = 15;
            this.conpanyinfoLbl.Text = "Company Info:";
            // 
            // Genbutton
            // 
            this.Genbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Genbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Genbutton.Location = new System.Drawing.Point(223, 558);
            this.Genbutton.Name = "Genbutton";
            this.Genbutton.Size = new System.Drawing.Size(96, 34);
            this.Genbutton.TabIndex = 21;
            this.Genbutton.Text = "Generate";
            this.Genbutton.UseVisualStyleBackColor = false;
            this.Genbutton.Click += new System.EventHandler(this.Genbutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Resetbutton.Location = new System.Drawing.Point(457, 558);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(96, 34);
            this.Resetbutton.TabIndex = 22;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(758, 634);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Genbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goodslabel);
            this.Controls.Add(this.customertextBox);
            this.Controls.Add(this.companytextBox);
            this.Controls.Add(this.customerinfolabel);
            this.Controls.Add(this.conpanyinfoLbl);
            this.Controls.Add(this.ReturnFormlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnForm";
            this.Text = "Return Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnForm_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnFormlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label goodslabel;
        private System.Windows.Forms.TextBox customertextBox;
        private System.Windows.Forms.TextBox companytextBox;
        private System.Windows.Forms.Label customerinfolabel;
        private System.Windows.Forms.Label conpanyinfoLbl;
        private System.Windows.Forms.Button Genbutton;
        private System.Windows.Forms.Button Resetbutton;
    }
}