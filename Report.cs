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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory_List' table. You can move, or remove it, as needed.
           // this.inventory_ListTableAdapter.Fill(this.inventoryDataSet.Inventory_List);
            this.reportViewer1.RefreshReport();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (InventoryEntities ctx = new InventoryEntities())
                {
                    inventoryListBindingSource.DataSource = ctx.Inventory_Lists.ToList();
                    this.reportViewer1.RefreshReport();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
