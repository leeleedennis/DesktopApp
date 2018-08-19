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
    public partial class InventoryList : Form
    {

        Inventory_List model1 = new Inventory_List();

        public InventoryList()
        {
            InitializeComponent();
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            this.ItemtextBox.Text = "";
            this.InvenTypetextBox.Text = "";
            this.ItemDesciptextBox.Text = "";
            this.PrefVendortextBox.Text = "";
            this.MinReordertextBox.Text = "";
            this.MaxReordertextBox.Text = "";
            this.QOHtextBox.Text = "";
            this.QOOtextBox.Text = "";
            this.QOAtextBox.Text = "";
            this.MarkupLvltextBox.Text = "";
            this.CosttextBox.Text = "";
        }

        void clear()
        {
            ItemtextBox.Text = InvenTypetextBox.Text = ItemDesciptextBox.Text = PrefVendortextBox.Text =
            MinReordertextBox.Text = MaxReordertextBox.Text = QOHtextBox.Text = QOOtextBox.Text =
            QOAtextBox.Text = MarkupLvltextBox.Text = CosttextBox.Text = "";

        }

        private void InventoryList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            model1.Item_Code = ItemtextBox.Text.Trim();
            model1.Invent_Type = InvenTypetextBox.Text.Trim();
            model1.Item_Description = ItemDesciptextBox.Text.Trim();
            model1.Pref_Vendor = PrefVendortextBox.Text.Trim();
            model1.Reorder_Point_Min = MinReordertextBox.Text.Trim();
            model1.Reorder_Point_Max = MaxReordertextBox.Text.Trim();
            model1.Quantity_on_Hand = QOHtextBox.Text.Trim();
            model1.Quantity_on_Order = QOOtextBox.Text.Trim();
            model1.Quantity_on_Available = QOAtextBox.Text.Trim();
            model1.Mark_up_Level = MarkupLvltextBox.Text.Trim();
            model1.Cost = CosttextBox.Text.Trim();

            using (InventoryEntities ctx = new InventoryEntities())
            {
                ctx.Inventory_Lists.Add(model1);
                ctx.SaveChanges();
            }

            clear();

            MessageBox.Show("New Item has been Added to Inventory");
           


        }
    }
}
