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
        string ConnectionString = @"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
        public Invoice()
        {
            InitializeComponent();
        }

        public List<CommonValue> Values { get; set; }
        public void AddtoGrid(List<CommonValue> val)
        {
            if (val != null)
            {
                foreach (CommonValue item in val)
                {
                    int n = InvoiceGridView.Rows.Add();
                    InvoiceGridView.Rows[n].Cells[1].Value = item.Item;
                    InvoiceGridView.Rows[n].Cells[2].Value = item.Description;
                    InvoiceGridView.Rows[n].Cells[3].Value = item.Quantity;
                    InvoiceGridView.Rows[n].Cells[4].Value = item.Rate;
                    InvoiceGridView.Rows[n].Cells[5].Value = item.Customer;
                    InvoiceGridView.Rows[n].Cells[6].Value = item.Amount;
                }
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet3.Order' table. You can move, or remove it, as needed.
            //this.orderTableAdapter1.Fill(this.inventoryDataSet3.Order);
            // TODO: This line of code loads data into the 'inventoryDataSet1.Order' table. You can move, or remove it, as needed.
            //this.orderTableAdapter.Fill(this.inventoryDataSet1.Order);
            //DataTable dTable = new DataTable();
            AddtoGrid(Values);
/*
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

            InvoiceGridView.DataSource = dTable;
            */
        }

        private void Invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void generatebutn_Click(object sender, EventArgs e)
        {
             decimal a1, b1, c;
             decimal.TryParse(totltextBox.Text, out a1);
             decimal.TryParse(paytextBox.Text, out b1);
             c = b1 - a1;
            
             baltextBox.Text = c.ToString();

            
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

        private void Cal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tot = 0;

                for (int i = 0; i < InvoiceGridView.Rows.Count; i++)
                {
                    tot += Convert.ToDecimal(InvoiceGridView.Rows[i].Cells[6].Value);


                }

                if (tot == 0)
                {

                }

                zeroltextBox3.Text = tot.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal d1, e1, l;
            decimal.TryParse(comboBox4.Text, out d1);
            decimal.TryParse(zeroltextBox3.Text, out e1);
            l = d1 * e1;

            if (l > 0)
                totltextBox.Text = l.ToString("c").Remove(0, 1);
        }

        Bitmap bmp;

        private void Prtbtn_Click(object sender, EventArgs e)
        {
            /* Graphics g = this.CreateGraphics();
             bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
             Graphics mg = Graphics.FromImage(bmp);
             mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);*/
             
            printPreviewDialog1.Document = printDocument1;
             printPreviewDialog1.ShowDialog();

           // printDocument1.Print();
        }

        int i = 0;
        int height = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
            Bitmap bm = Properties.Resources.atlantic;
            System.Drawing.Image ig = bm;
            e.Graphics.DrawImage(ig, 50, 30, ig.Width, ig.Height);

            e.Graphics.DrawString("INVOICE", new System.Drawing.Font("Times New Roman", 26), Brushes.Black, new Point(300, 140));

            e.Graphics.DrawString(dash.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 170));

            e.Graphics.DrawString("Date: " + DateTime.Now, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Customer: " + InvoiceGridView.Rows[i].Cells[5].FormattedValue.ToString(), InvoiceGridView.Font, Brushes.Black, new System.Drawing.Rectangle(25, 195, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));
            e.Graphics.DrawString("13 Lincoln Avenue, Kingston 5", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(70, 210));


            e.Graphics.DrawString(dash.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Item", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 280));
            e.Graphics.DrawString("Quantity", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(300, 280));
            e.Graphics.DrawString("Rate", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(500, 280));
            e.Graphics.DrawString("Cost", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(700, 280));
            e.Graphics.DrawString(dash.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 300));

            // InvoiceGridView.CurrentCell.RowIndex
            //e.Graphics.DrawString(InvoiceGridView.Columns[1].HeaderText.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 320));
            //e.Graphics.DrawString(InvoiceGridView.Columns[3].HeaderText.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(300, 320));
            //e.Graphics.DrawString(InvoiceGridView.Columns[4].HeaderText.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(500, 320));
            //e.Graphics.DrawString(InvoiceGridView.Columns[6].HeaderText.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(700, 320));
            height = 320;
            Pen p = new Pen(Brushes.Black);

            while (i < InvoiceGridView.Rows.Count )
            {

                height += InvoiceGridView.Rows[0].Height;
                //e.Graphics.DrawRectangle(p, new System.Drawing.Rectangle(25, height, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));
                e.Graphics.DrawString(InvoiceGridView.Rows[i].Cells[1].FormattedValue.ToString(), InvoiceGridView.Font, Brushes.Black, new System.Drawing.Rectangle(25, height, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));

               // e.Graphics.DrawRectangle(p, new System.Drawing.Rectangle(100 + InvoiceGridView.Columns[1].Width, height, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));
                e.Graphics.DrawString(InvoiceGridView.Rows[i].Cells[3].FormattedValue.ToString(), InvoiceGridView.Font, Brushes.Black, new System.Drawing.Rectangle(200 + InvoiceGridView.Columns[1].Width,height, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));
                
                e.Graphics.DrawString(InvoiceGridView.Rows[i].Cells[4].FormattedValue.ToString(), InvoiceGridView.Font, Brushes.Black, new System.Drawing.Rectangle(375 + InvoiceGridView.Columns[1].Width, height, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));
                e.Graphics.DrawString("$"+InvoiceGridView.Rows[i].Cells[6].FormattedValue.ToString(), InvoiceGridView.Font, Brushes.Black, new System.Drawing.Rectangle(570 + InvoiceGridView.Columns[1].Width, height, InvoiceGridView.Columns[1].Width, InvoiceGridView.Rows[0].Height));

                i++;

            }
            e.Graphics.DrawString(dash.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(25, 500));


            e.Graphics.DrawString("Total", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(600, 550));

            e.Graphics.DrawString("$" + totltextBox.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(700, 550));
            e.Graphics.DrawString("Cash", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(600, 600));
            e.Graphics.DrawString("$" + paytextBox.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(700, 600));
            e.Graphics.DrawString("Change", new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(600, 650));
            e.Graphics.DrawString("$" + baltextBox.Text, new System.Drawing.Font("Arial", 12), Brushes.Black, new Point(700, 650));






            //Bitmap bmp = new Bitmap(this.InvoiceGridView.Width, this.InvoiceGridView.Height);
            //InvoiceGridView.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, this.InvoiceGridView.Width, this.InvoiceGridView.Height));
            //e.Graphics.DrawImage(bmp, 10, 10);
        }
    }
}
