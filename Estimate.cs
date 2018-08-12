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
    public partial class Estimate : Form
    {
        public Estimate()
        {
            InitializeComponent();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            this.NameAddtextBox.Text = "";
            this.subtextBox.Text = "";
            this.marktextBox.Text = "";
            this.textBox3.Text = "";
            this.tttextBox.Text = "";
            this.custextBox.Text = "";
            this.abtextBox.Text = "";
            this.EstimatetextBox.Text = "";
            this.comboBox1.Items.Clear();
            this.comboBox1.ResetText();
            this.comboBox2.Items.Clear();
            this.comboBox2.ResetText();
            this.dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            this.dataGridView1.DataSource = null;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

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

        private void Estimate_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ITEM");
            dt.Columns.Add("DESCRIPTION");
            dt.Columns.Add("QTY");
            dt.Columns.Add("U/M");
            dt.Columns.Add("COST");
            dt.Columns.Add("TOTAL");
            dt.Columns.Add("TAX");

            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");
            dt.Rows.Add("", "", "", "", "", "", "");



            dataGridView1.DataSource = dt;

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Estimate.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Atlantic Industrial Electric Co. Ltd");
            doc.Add(paragraph);
            doc.Close();
        }

        private void Estimate_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }
    }
}
