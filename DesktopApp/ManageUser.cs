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
    public partial class ManageUser : Form
    {
        InventoryEntities ctx = new InventoryEntities();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True");
        User model = new User();

        public ManageUser()
        {
            InitializeComponent();
        }

        DataTable data = new DataTable();

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    usersBindingSource1.RemoveCurrent();
                usersTableAdapter1.Update(this.inventoryDataSet5.Users);


                MessageBox.Show("This record was deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
               usersBindingSource1.EndEdit();
                usersTableAdapter1.Update(this.inventoryDataSet5.Users);
                MessageBox.Show("This record was updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;



        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            /* // OrderGridView.DataSource = ctx.Orders.ToList();
             SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RLN6KED0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True");
             SqlDataAdapter sda = new SqlDataAdapter("select F_Name, L_Name,Username,Type from users", con);
             // DataTable data = new DataTable();
             sda.Fill(data);

             foreach (DataRow item in data.Rows)
             {
                 int n = SearchdataGridView.Rows.Add();
                 SearchdataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                 SearchdataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                 SearchdataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                 SearchdataGridView.Rows[n].Cells[3].Value = item[3].ToString();*/
            ManageUserGridView();


            // OrderGridView.Rows[n].Cells[8].Value = item[8].ToString();

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            SearchdataGridView.DataSource = ctx.Users.Where(q => q.F_Name.Contains(searchtextBox.Text)).ToList();
        }
    

    void ManageUserGridView()
    {
        SearchdataGridView.DataSource = ctx.Users.ToList<User>();
    }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet5.Users' table. You can move, or remove it, as needed.
           this.usersTableAdapter1.Fill(this.inventoryDataSet5.Users);
            // TODO: This line of code loads data into the 'inventoryDataSet4.Users' table. You can move, or remove it, as needed.
            // this.usersTableAdapter.Fill(this.inventoryDataSet4.Users);

        }

        private void SearchdataGridView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    usersBindingSource1.RemoveCurrent();
            }

        }
    }
}
