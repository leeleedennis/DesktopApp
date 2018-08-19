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
using System.Data.SqlClient;


namespace DesktopApp
{
    public partial class PurchaseOrder : Form
    {
        String ConnectionString = @"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
        SqlCommand command;
        Double USD;

        
        public PurchaseOrder()
        {
            InitializeComponent();
            /*
            PurchaseGridView.ColumnCount = 8;

            PurchaseGridView.Columns[0].Name = "OrderId";
            PurchaseGridView.Columns[1].Name = "Item";
            PurchaseGridView.Columns[2].Name = "Description";
            PurchaseGridView.Columns[3].Name = "Quantity";
            PurchaseGridView.Columns[4].Name = "U/M";
            PurchaseGridView.Columns[5].Name = "Rate";
            PurchaseGridView.Columns[6].Name = "Customer";
            PurchaseGridView.Columns[7].Name = "Amount";
            */
            
        }

        /*public AutoCompleteStringCollection ClientListDropDown()
        {
            SqlConnection con = new SqlConnection();
            AutoCompleteStringCollection acs = new AutoCompleteStringCollection();
            try
            {
                String Query;
                Query = "Select Item From Order";
                SqlDataReader dr;
                con.Open();
                command = new SqlCommand(Query, con);
                dr = command.ExecuteReader();
                if ((dr != null) && (dr.HasRows))
                    while (dr.Read())
                        acs.Add(dr.GetValue(0).ToString());

                dr.Close();
                command.Dispose();
                con.Close();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }*/

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            /*Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Purchase Order.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Atlantic Industrial Electric Co. Ltd");
            doc.Add(paragraph);
            doc.Close(); */

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                
                    orderBindingSource.AddNew();
                    orderTableAdapter.Update(this.inventoryDataSet1.Order);

                  

                MessageBox.Show("Purchase order was successfully generated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;



        }


        void PopulateComboBox()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Measurement", con);
                DataTable data = new DataTable();
                adapter.Fill(data);
                cbxMeasure.ValueMember = "UnitId";
                cbxMeasure.DisplayMember = "UnitMeasure";
                DataRow topitem = data.NewRow();
                topitem[0] = 0;
                topitem[1] = "-Select-";
                data.Rows.InsertAt(topitem, 0);

                cbxMeasure.DataSource = data;
            }

        }
     
              
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            /*
            this.potextBox.Text = "";
            this.venaddtextBox.Text = "";
            this.VENtextBox.Text = "";
            this.TTtextBox.Text = "";
            this.shiptextBox.Text = "";
            this.comboBox1.Items.Clear();
            this.comboBox1.ResetText();
            this.PurchaseGridView.DataSource = null; */

            



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
            // TODO: This line of code loads data into the 'inventoryDataSet1.Order' table. You can move, or remove it, as needed.
           // this.orderTableAdapter.Fill(this.inventoryDataSet1.Order);
            /* DataTable d = new DataTable();

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

             dataGridView1.DataSource = d; */

            PopulateComboBox();

        }

        private void PurchaseGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PurchaseGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           /* try
            {
                int qty = int.Parse(PurchaseGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                decimal rte = int.Parse(PurchaseGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

                PurchaseGridView.Rows[e.RowIndex].Cells[6].Value = qty * rte;

                string porder = PurchaseGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch(Exception)
            {

            }


            try
            {
                string porder = PurchaseGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand command = new SqlCommand("Select Quantity, Rate From Order", con);

                SqlDataReader dr = command.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        PurchaseGridView.Rows[e.RowIndex].Cells[1].Value = dr[0].ToString();
                        PurchaseGridView.Rows[e.RowIndex].Cells[2].Value = dr[1].ToString();

                        int i;
                        i = PurchaseGridView.SelectedCells[0].RowIndex;

                        TTtextBox.Text = "";
                        TTtextBox.Text = porder + " : " + dr[1].ToString();

                    }
                }

            }
            catch(Exception)
            {

            }*/
        }

        void total()
        {
            for(int i = 0; i < PurchaseGridView.Rows.Count; i++)
            {
                int q = Convert.ToInt32(PurchaseGridView.Rows[i].Cells[3].Value);
                int r = Convert.ToInt32(PurchaseGridView.Rows[i].Cells[5].Value);
                int s = q * r;

                PurchaseGridView.Rows[i].Cells[7].Value = s;
            }
        }

        private void PurchaseGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
           // total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                     for (int i = 0; i < PurchaseGridView.Rows.Count; i++)
                            {
                                 int q = Convert.ToInt32(PurchaseGridView.Rows[i].Cells[3].Value);
                                 int r = Convert.ToInt32(PurchaseGridView.Rows[i].Cells[5].Value);
                                  int s = q * r;

                             PurchaseGridView.Rows[i].Cells[7].Value = s;
                            
               
                     }
            try
            {
                decimal tot = 0;

                for (int i = 0; i < PurchaseGridView.Rows.Count; i++)
                {
                    tot += Convert.ToDecimal(PurchaseGridView.Rows[i].Cells[7].Value);

                        
                }

                if(tot==0)
                {

                }

                TTtextBox.Text = tot.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //tot = tot + Convert.ToInt32(PurchaseGridView.Rows[i].Cells[7].Value);




        }

        private void shiptextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
