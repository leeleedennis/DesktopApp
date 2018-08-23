using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopApp
{
    public partial class Orders : Form
    {
        InventoryEntities ctx = new InventoryEntities();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True");
        
        public Orders()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet2.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.inventoryDataSet2.Order);
            
        }


        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            // OrderGridView.DataSource = ctx.Orders.ToList();
             SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True");
             SqlDataAdapter sda = new SqlDataAdapter("Select Item, Description, Quantity, Rate, Customer, Amount From [Order]", con);
            // DataTable data = new DataTable();
             sda.Fill(data);

            foreach(DataRow item in data.Rows)
             {
                int n = OrderGridView.Rows.Add();
                 OrderGridView.Rows[n].Cells[0].Value = false;
                 OrderGridView.Rows[n].Cells[1].Value = item[0].ToString();
                 OrderGridView.Rows[n].Cells[2].Value = item[1].ToString();
                 OrderGridView.Rows[n].Cells[3].Value = item[2].ToString();
                 OrderGridView.Rows[n].Cells[4].Value = item[3].ToString();
                 OrderGridView.Rows[n].Cells[5].Value = item[4].ToString();
                 OrderGridView.Rows[n].Cells[6].Value = item[5].ToString();
                // OrderGridView.Rows[n].Cells[8].Value = item[8].ToString();

             }

            /* using (InventoryEntities ctx = new InventoryEntities())
             {
                 orderBindingSource.DataSource = ctx.Orders.ToList();
             }
            void OrdersGridView()
            {
                OrderGridView.DataSource = ctx.Orders.ToList<Order>();
            }*/

        }

        private void ItemCodetextBox_TextChanged(object sender, EventArgs e)
        {
            OrderGridView.DataSource = ctx.Orders.Where(q => q.Customer.Contains(ItemCodetextBox.Text)).ToList();

            //DataView dv = new DataView
        }

        private void PlaceOrderbutton_Click(object sender, EventArgs e)
        {
            List<CommonValue> cv = new List<CommonValue>();
            foreach(DataGridViewRow item in OrderGridView.Rows )
            {
                if(Convert.ToBoolean(item.Cells[0].Value))
                {
                    cv.Add(new CommonValue
                    {
                        Item = item.Cells[1].Value.ToString(),
                        Description = item.Cells[2].Value.ToString(),
                        Quantity = item.Cells[3].Value.ToString(),
                        Rate = item.Cells[4].Value.ToString(),
                        Customer = item.Cells[5].Value.ToString(),
                        Amount = item.Cells[6].Value.ToString(),
                        
                    });

                }
            }

            Invoice inv = new Invoice();
            inv.Values = cv;
            inv.Show();

            
        }

        private void OrderGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if((bool)OrderGridView.SelectedRows[0].Cells[0].Value == false)
            {
                OrderGridView.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                OrderGridView.SelectedRows[0].Cells[0].Value = false;
            }

            

        }

        private void ItemCodetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)13)
            {
                DataView dv = data.DefaultView;
                dv.RowFilter = string.Format("txtCustomer like '%(0)%'", ItemCodetextBox.Text);
                OrderGridView.DataSource = dv.ToTable();
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
              int rowIndex = OrderGridView.CurrentCell.RowIndex;
               OrderGridView.Rows.RemoveAt(rowIndex);

            
        }
    }
}
