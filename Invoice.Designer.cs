namespace DesktopApp
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.PoSlabel = new System.Windows.Forms.Label();
            this.shiptextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.billtextBox = new System.Windows.Forms.TextBox();
            this.invoicetextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.shiplabel = new System.Windows.Forms.Label();
            this.invoicelabel = new System.Windows.Forms.Label();
            this.vendorlabel = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.potextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vialabel = new System.Windows.Forms.Label();
            this.REPtextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.zeroltextBox3 = new System.Windows.Forms.TextBox();
            this.totltextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.baltextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paytextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Resetbutn = new System.Windows.Forms.Button();
            this.generatebutn = new System.Windows.Forms.Button();
            this.custextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.abtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.InvoiceGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTableAdapter1 = new DesktopApp.InventoryDataSet3TableAdapters.OrderTableAdapter();
            this.Cal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Prtbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dash = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PoSlabel
            // 
            this.PoSlabel.AutoSize = true;
            this.PoSlabel.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.PoSlabel.Location = new System.Drawing.Point(37, 27);
            this.PoSlabel.Name = "PoSlabel";
            this.PoSlabel.Size = new System.Drawing.Size(101, 34);
            this.PoSlabel.TabIndex = 2;
            this.PoSlabel.Text = "Invoice";
            // 
            // shiptextBox
            // 
            this.shiptextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiptextBox.Location = new System.Drawing.Point(768, 117);
            this.shiptextBox.Multiline = true;
            this.shiptextBox.Name = "shiptextBox";
            this.shiptextBox.Size = new System.Drawing.Size(179, 124);
            this.shiptextBox.TabIndex = 60;
            this.shiptextBox.Text = "Atlantic Industrial Electric      138D Maxfield Avenue          Kingston 10      " +
    "                          Jamaica";
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
            this.comboBox1.Location = new System.Drawing.Point(835, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // billtextBox
            // 
            this.billtextBox.Location = new System.Drawing.Point(580, 117);
            this.billtextBox.Multiline = true;
            this.billtextBox.Name = "billtextBox";
            this.billtextBox.Size = new System.Drawing.Size(182, 124);
            this.billtextBox.TabIndex = 58;
            // 
            // invoicetextBox
            // 
            this.invoicetextBox.Location = new System.Drawing.Point(440, 170);
            this.invoicetextBox.Name = "invoicetextBox";
            this.invoicetextBox.Size = new System.Drawing.Size(104, 20);
            this.invoicetextBox.TabIndex = 57;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // shiplabel
            // 
            this.shiplabel.AutoSize = true;
            this.shiplabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.shiplabel.Location = new System.Drawing.Point(765, 95);
            this.shiplabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shiplabel.Name = "shiplabel";
            this.shiplabel.Size = new System.Drawing.Size(63, 16);
            this.shiplabel.TabIndex = 55;
            this.shiplabel.Text = "SHIP TO:";
            // 
            // invoicelabel
            // 
            this.invoicelabel.AutoSize = true;
            this.invoicelabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.invoicelabel.Location = new System.Drawing.Point(437, 151);
            this.invoicelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoicelabel.Name = "invoicelabel";
            this.invoicelabel.Size = new System.Drawing.Size(78, 16);
            this.invoicelabel.TabIndex = 54;
            this.invoicelabel.Text = "INVOICE #:";
            // 
            // vendorlabel
            // 
            this.vendorlabel.AutoSize = true;
            this.vendorlabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.vendorlabel.Location = new System.Drawing.Point(577, 95);
            this.vendorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendorlabel.Name = "vendorlabel";
            this.vendorlabel.Size = new System.Drawing.Size(62, 16);
            this.vendorlabel.TabIndex = 53;
            this.vendorlabel.Text = "BILL TO:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DateLbl.Location = new System.Drawing.Point(437, 95);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(45, 16);
            this.DateLbl.TabIndex = 52;
            this.DateLbl.Text = "DATE:";
            // 
            // potextBox1
            // 
            this.potextBox1.Location = new System.Drawing.Point(293, 275);
            this.potextBox1.Name = "potextBox1";
            this.potextBox1.Size = new System.Drawing.Size(104, 20);
            this.potextBox1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(290, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "P.O NO.";
            // 
            // vialabel
            // 
            this.vialabel.AutoSize = true;
            this.vialabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.vialabel.Location = new System.Drawing.Point(840, 256);
            this.vialabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vialabel.Name = "vialabel";
            this.vialabel.Size = new System.Drawing.Size(31, 16);
            this.vialabel.TabIndex = 63;
            this.vialabel.Text = "VIA";
            // 
            // REPtextBox2
            // 
            this.REPtextBox2.Location = new System.Drawing.Point(623, 275);
            this.REPtextBox2.Name = "REPtextBox2";
            this.REPtextBox2.Size = new System.Drawing.Size(104, 20);
            this.REPtextBox2.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(620, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "REP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(400, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "TERMS";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(733, 275);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 70;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(730, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "SHIP";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(513, 275);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker3.TabIndex = 72;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label5.Location = new System.Drawing.Point(510, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "DUE DATE";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "DHL",
            "FEDEX",
            "POST JA"});
            this.comboBox2.Location = new System.Drawing.Point(843, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 73;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "",
            "Contract",
            "ETC"});
            this.comboBox3.Location = new System.Drawing.Point(403, 275);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(104, 21);
            this.comboBox3.TabIndex = 74;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "",
            "16.5",
            "18.5",
            "20.0"});
            this.comboBox4.Location = new System.Drawing.Point(606, 535);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(112, 21);
            this.comboBox4.TabIndex = 80;
            // 
            // zeroltextBox3
            // 
            this.zeroltextBox3.Location = new System.Drawing.Point(853, 533);
            this.zeroltextBox3.Name = "zeroltextBox3";
            this.zeroltextBox3.Size = new System.Drawing.Size(104, 20);
            this.zeroltextBox3.TabIndex = 79;
            this.zeroltextBox3.Tag = "";
            // 
            // totltextBox
            // 
            this.totltextBox.Location = new System.Drawing.Point(853, 559);
            this.totltextBox.Name = "totltextBox";
            this.totltextBox.Size = new System.Drawing.Size(104, 20);
            this.totltextBox.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label6.Location = new System.Drawing.Point(730, 563);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "TOTAL       JMD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label7.Location = new System.Drawing.Point(564, 540);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "TAX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label8.Location = new System.Drawing.Point(725, 537);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "(0.0%)         JMD";
            // 
            // baltextBox
            // 
            this.baltextBox.Location = new System.Drawing.Point(853, 611);
            this.baltextBox.Name = "baltextBox";
            this.baltextBox.Size = new System.Drawing.Size(104, 20);
            this.baltextBox.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label9.Location = new System.Drawing.Point(681, 615);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "BALANCE DUE       JMD";
            // 
            // paytextBox
            // 
            this.paytextBox.Location = new System.Drawing.Point(853, 585);
            this.paytextBox.Name = "paytextBox";
            this.paytextBox.Size = new System.Drawing.Size(104, 20);
            this.paytextBox.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label10.Location = new System.Drawing.Point(655, 589);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 16);
            this.label10.TabIndex = 83;
            this.label10.Text = "PAYMENT APPLIED      JMD";
            // 
            // Resetbutn
            // 
            this.Resetbutn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resetbutn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Resetbutn.Location = new System.Drawing.Point(853, 657);
            this.Resetbutn.Name = "Resetbutn";
            this.Resetbutn.Size = new System.Drawing.Size(96, 34);
            this.Resetbutn.TabIndex = 86;
            this.Resetbutn.Text = "Reset";
            this.Resetbutn.UseVisualStyleBackColor = false;
            this.Resetbutn.Click += new System.EventHandler(this.Resetbutn_Click);
            // 
            // generatebutn
            // 
            this.generatebutn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generatebutn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.generatebutn.Location = new System.Drawing.Point(733, 657);
            this.generatebutn.Name = "generatebutn";
            this.generatebutn.Size = new System.Drawing.Size(96, 34);
            this.generatebutn.TabIndex = 85;
            this.generatebutn.Text = "Generate";
            this.generatebutn.UseVisualStyleBackColor = false;
            this.generatebutn.Click += new System.EventHandler(this.generatebutn_Click);
            // 
            // custextBox
            // 
            this.custextBox.Location = new System.Drawing.Point(43, 571);
            this.custextBox.Multiline = true;
            this.custextBox.Name = "custextBox";
            this.custextBox.Size = new System.Drawing.Size(281, 91);
            this.custextBox.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(41, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 90;
            this.label11.Text = "CUSTOMER MESSAGE";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(275, 491);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(42, 20);
            this.textBox6.TabIndex = 89;
            this.textBox6.Text = "JMD";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // abtextBox
            // 
            this.abtextBox.Location = new System.Drawing.Point(174, 491);
            this.abtextBox.Name = "abtextBox";
            this.abtextBox.Size = new System.Drawing.Size(104, 20);
            this.abtextBox.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(41, 491);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "\"ASK GIBBS\"";
            // 
            // InvoiceGridView
            // 
            this.InvoiceGridView.AllowUserToAddRows = false;
            this.InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.InvoiceGridView.Location = new System.Drawing.Point(43, 322);
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.Size = new System.Drawing.Size(839, 150);
            this.InvoiceGridView.TabIndex = 92;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selected";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rate";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Customer";
            this.Column6.Name = "Column6";
            this.Column6.Width = 170;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // Cal
            // 
            this.Cal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cal.Location = new System.Drawing.Point(494, 657);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(96, 34);
            this.Cal.TabIndex = 93;
            this.Cal.Text = "Sum";
            this.Cal.UseVisualStyleBackColor = false;
            this.Cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(613, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 94;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(836, 534);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 95;
            this.label13.Text = "$";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(836, 560);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 99;
            this.label17.Text = "$";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(836, 585);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 100;
            this.label14.Text = "$";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(836, 612);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 101;
            this.label15.Text = "$";
            // 
            // Prtbtn
            // 
            this.Prtbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Prtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Prtbtn.Location = new System.Drawing.Point(893, 27);
            this.Prtbtn.Name = "Prtbtn";
            this.Prtbtn.Size = new System.Drawing.Size(54, 27);
            this.Prtbtn.TabIndex = 102;
            this.Prtbtn.Text = "Print";
            this.Prtbtn.UseVisualStyleBackColor = false;
            this.Prtbtn.Click += new System.EventHandler(this.Prtbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dash
            // 
            this.dash.AutoSize = true;
            this.dash.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dash.Location = new System.Drawing.Point(13, 735);
            this.dash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(883, 16);
            this.dash.TabIndex = 103;
            this.dash.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "--------------";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1012, 748);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.Prtbtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.InvoiceGridView);
            this.Controls.Add(this.custextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.abtextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Resetbutn);
            this.Controls.Add(this.generatebutn);
            this.Controls.Add(this.paytextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.baltextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.zeroltextBox3);
            this.Controls.Add(this.totltextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.REPtextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vialabel);
            this.Controls.Add(this.potextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shiptextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.billtextBox);
            this.Controls.Add(this.invoicetextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.shiplabel);
            this.Controls.Add(this.invoicelabel);
            this.Controls.Add(this.vendorlabel);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.PoSlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invoice_FormClosing);
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PoSlabel;
        private System.Windows.Forms.TextBox shiptextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox billtextBox;
        private System.Windows.Forms.TextBox invoicetextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label shiplabel;
        private System.Windows.Forms.Label invoicelabel;
        private System.Windows.Forms.Label vendorlabel;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.TextBox potextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vialabel;
        private System.Windows.Forms.TextBox REPtextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox zeroltextBox3;
        private System.Windows.Forms.TextBox totltextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox baltextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paytextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Resetbutn;
        private System.Windows.Forms.Button generatebutn;
        private System.Windows.Forms.TextBox custextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox abtextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView InvoiceGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private InventoryDataSet3TableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.Button Cal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Prtbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label dash;
    }
}