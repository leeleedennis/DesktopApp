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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

      
        private void Invoice_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();

            dTable.Columns.Add("ITEM CODE");
            dTable.Columns.Add("QUANTITY");
            dTable.Columns.Add("DESCRIPTION");
            dTable.Columns.Add("U/M");
            dTable.Columns.Add("PRICE EACH");
            dTable.Columns.Add("AMOUNT");
            dTable.Columns.Add("TAX");

            dTable.Rows.Add("", "", "", "", "", "", "");
            dTable.Rows.Add("", "", "", "", "", "", "");
            dTable.Rows.Add("", "", "", "", "", "", "");
            dTable.Rows.Add("", "", "", "", "", "", "");
            dTable.Rows.Add("", "", "", "", "", "", "");
            dTable.Rows.Add("", "", "", "", "", "", "");
            dTable.Rows.Add("", "", "", "", "", "", "");

            dataGridView1.DataSource = dTable;

        }

        private void Invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void generatebutn_Click(object sender, EventArgs e)
        {

        }

        private void Resetbutn_Click(object sender, EventArgs e)
        {
            this.invoicetextBox.Text = "";
            this.billtextBox.Text = "";
            this.REPtextBox2.Text = "";
            this.potextBox1.Text = "";
            this.shiptextBox.Text = "";
            this.dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            this.dateTimePicker2.Value = DateTimePicker.MinimumDateTime;
            this.dateTimePicker3.Value = DateTimePicker.MinimumDateTime;
            this.comboBox1.Items.Clear();
            this.comboBox1.ResetText();
            this.comboBox2.Items.Clear();
            this.comboBox2.ResetText();
            this.comboBox3.Items.Clear();
            this.comboBox3.ResetText();
            this.abtextBox.Text = "";
            this.custextBox.Text = "";
            this.totltextBox.Text = "";
            this.zeroltextBox3.Text = "";
            this.paytextBox.Text = "";
            this.baltextBox.Text = "";

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

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker3.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePicker3.Value = DateTime.Now;
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = " ";
            }
            else
            {
                dateTimePicker3.Format = DateTimePickerFormat.Short;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value == DateTimePicker.MinimumDateTime)
            {
                dateTimePicker2.Value = DateTime.Now;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = " ";
            }
            else
            {
                dateTimePicker2.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
