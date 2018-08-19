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
    public partial class ManageInventory : Form
    {
        InventoryEntities ctx = new InventoryEntities();
        Inventory_List model = new Inventory_List();

        //SqlConnection con;
       // String ConnectionString = @"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
      //  DataSet ds;
        //SqlCommandBuilder scb;
     

        public ManageInventory()
        {
            InitializeComponent();
        }

        private void ManageInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;

        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory_List' table. You can move, or remove it, as needed.
                 this.inventory_ListTableAdapter.Fill(this.inventoryDataSet.Inventory_List);
            //PopulateDataGridView();


            // SqlConnection con = new SqlConnection(@"Data Source = LAPTOP - RLN6KED0\SQLEXPRESS; Initial Catalog = Inventory; Integrated Security = True");
            //con.ConnectionString = @"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
            /* sda = new SqlDataAdapter(@"SELECT Item_id, Item_Code as 'Item Code',Invent_Type as 'Inventory Type', Item_Description as 'Item Description'," +
                "Pref_Vendor as 'Preferred Vendor', Reorder_Point_Min as 'Reorder Point Min',Reorder_Point_Max as 'Reorder Point Max'," +
                "Quantity_on_Hand as 'Quantity on Hand', Quantity_on_Order as 'Quantity on Order', Quantity_on_Available as 'Quantity on Available'," +
                "Mark_up_Level as 'Mark up Level',Cost FROM Inventory_List", con); 
        dt = new DataTable();
        sda.Fill(dt);
        ManageGridView.DataSource = dt; 

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = @"SELECT   Item_Code as 'Item Code', Invent_Type as 'Inventory Type', Item_Description as 'Item Description', Pref_Vendor as 'Preffered Vendor', Reorder_Point_Min as 'Reorder Point Min', 
            Reorder_Point_Max as 'Reorder Point Max', Quantity_on_Hand as 'Quantity on Hand', Quantity_on_Order as 'Quantity on Order', Quantity_on_Available as 'Quantity Available', Mark_up_Level as 'Mark up Level', Cost
              FROM[Inventory List]";
                

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            ManageGridView.DataSource = data; */

            //PopulateDataGridView();

           
        }

        void PopulateDataGridView()
        {
            /*
             ManageGridView.AutoGenerateColumns = false;

             using (InventoryEntities ctx = new InventoryEntities())
             {
                 ManageGridView.DataSource = ctx.Inventory_Lists.ToList<Inventory_List>();
             } */
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = @"SELECT   Item_Code as 'Item Code', Invent_Type as 'Inventory Type', Item_Description as 'Item Description', Pref_Vendor as 'Preffered Vendor', Reorder_Point_Min as 'Reorder Point Min', 
            Reorder_Point_Max as 'Reorder Point Max', Quantity_on_Hand as 'Quantity on Hand', Quantity_on_Order as 'Quantity on Order', Quantity_on_Available as 'Quantity Available', Mark_up_Level as 'Mark up Level', Cost
              FROM[Inventory List]";


            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            ManageGridView.DataSource = data;

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                inventoryListBindingSource.EndEdit();
                inventory_ListTableAdapter.Update(this.inventoryDataSet.Inventory_List);
                MessageBox.Show("This record was updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            
         }

        private void ManageGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          /* if(ManageGridView.CurrentRow != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    DataGridViewRow gridrow = ManageGridView.CurrentRow;
                    SqlCommand command = new SqlCommand("Updateinventory", con);
                    command.CommandType = CommandType.StoredProcedure;
                    if(gridrow.Cells["txtItemId"].Value == DBNull.Value)
                    command.Parameters.AddWithValue("@Itemid", 0);
                    else
                        command.Parameters.AddWithValue("@Itemid", Convert.ToInt32(gridrow.Cells["txtItemId"].Value));
                    command.Parameters.AddWithValue("@ItemCode", gridrow.Cells["txtcode"].Value == DBNull.Value ? "": gridrow.Cells["txtcode"].Value.ToString());
                    command.Parameters.AddWithValue("@InventType", gridrow.Cells["txttype"].Value == DBNull.Value ? "" : gridrow.Cells["txttype"].Value.ToString());
                    command.Parameters.AddWithValue("@ItemDescription", gridrow.Cells["txtdescrip"].Value == DBNull.Value ? "" : gridrow.Cells["txtdescrip"].Value.ToString());
                    command.Parameters.AddWithValue("@PrefVendor", gridrow.Cells["txtvendor"].Value == DBNull.Value ? "" : gridrow.Cells["txtvendor"].Value.ToString());
                    command.Parameters.AddWithValue("@ReorderPointMin", gridrow.Cells["txtmin"].Value == DBNull.Value ? "" : gridrow.Cells["txtmin"].Value.ToString());
                    command.Parameters.AddWithValue("@ReorderPointMax", gridrow.Cells["txtmax"].Value == DBNull.Value ? "" : gridrow.Cells["txtmax"].Value.ToString());
                    command.Parameters.AddWithValue("@QuantityonHand", gridrow.Cells["txthand"].Value == DBNull.Value ? "" : gridrow.Cells["txthand"].Value.ToString());
                    command.Parameters.AddWithValue("@QuantityonOrder", gridrow.Cells["txtorder"].Value == DBNull.Value ? "" : gridrow.Cells["txtorder"].Value.ToString());
                    command.Parameters.AddWithValue("@QuantityonAvailable", gridrow.Cells["txtavailable"].Value == DBNull.Value ? "" : gridrow.Cells["txtavailable"].Value.ToString());
                    command.Parameters.AddWithValue("@MarkupLevel", gridrow.Cells["txtmark"].Value == DBNull.Value ? "" : gridrow.Cells["txtmark"].Value.ToString());
                    command.Parameters.AddWithValue("@Cost", gridrow.Cells["txtcost"].Value == DBNull.Value ? "" : gridrow.Cells["txtcost"].Value.ToString());

                    command.ExecuteNonQuery();
                    PopulateDataGridView(); 

                }
            }*/
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 

                inventoryListBindingSource.RemoveCurrent();
                inventory_ListTableAdapter.Update (this.inventoryDataSet.Inventory_List);

     
                MessageBox.Show("This record was deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;

        }

        private void ManageGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    inventoryListBindingSource.RemoveCurrent();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
        }

        private void ItemCodetextBox_TextChanged(object sender, EventArgs e)
        {
           

            ManageGridView.DataSource = ctx.Inventory_Lists.Where(q => q.Item_Code.Contains(ItemCodetextBox.Text)).ToList();
        }
    }
}
