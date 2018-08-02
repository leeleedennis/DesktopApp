using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace DesktopApp
{
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Purchase Order.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Atlantic Industrial Electric Co. Ltd");
            doc.Add(paragraph);
            doc.Close();
        }

        
       
     
              
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            this.potextBox.Text = "";
            this.venaddtextBox.Text = "";
            this.VENtextBox.Text = "";
            this.TTtextBox.Text = "";
            this.shiptextBox.Text = "";
            this.comboBox1.Items.Clear();
            this.comboBox1.ResetText();
            this.dataGridView1.DataSource = null;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " ";
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
            }
        }

        private void PurchaseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            DataTable d = new DataTable();

            d.Columns.Add("ITEM");
            d.Columns.Add("DESCRIPTION");
            d.Columns.Add("QUANTITY");
            d.Columns.Add("U/M");
            d.Columns.Add("RATE");
            d.Columns.Add("CUSTOMER");
            d.Columns.Add("AMOUNT");

            d.Rows.Add("", "", "", "", "", "", "");
            d.Rows.Add("", "", "", "", "", "", "");
            d.Rows.Add("", "", "", "", "", "", "");
            d.Rows.Add("", "", "", "", "", "", "");
            d.Rows.Add("", "", "", "", "", "", "");
            d.Rows.Add("", "", "", "", "", "", "");
            d.Rows.Add("", "", "", "", "", "", "");

            dataGridView1.DataSource = d;

        }
    }
}
