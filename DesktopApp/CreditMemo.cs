using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class CreditMemo : Form
    {
        public CreditMemo()
        {
            InitializeComponent();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            this.credittextBox.Text = "";
            this.custextBox.Text = "";
            this.CustomertextBox.Text = "";
            this.dataGridView1.DataSource = null;
            this.comboBox2.Items.Clear();
            this.comboBox2.ResetText();
            this.ZertextBox3.Text = "";
            this.abtextBox.Text = "";
            this.POtextBox1.Text = "";
            this.tottextBox.Text = "";
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

        private void CreditMemo_Load(object sender, EventArgs e)
        {
            DataTable tab = new DataTable();

            tab.Columns.Add("ITEM");
            tab.Columns.Add("DESCRIPTION");
            tab.Columns.Add("QTY");
            tab.Columns.Add("U/M");
            tab.Columns.Add("RATE");
            tab.Columns.Add("AMOUNT");
            tab.Columns.Add("TAX");

            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");
            tab.Rows.Add("", "", "", "", "", "", "");


            dataGridView1.DataSource = tab;
        }

        private void CreditMemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
