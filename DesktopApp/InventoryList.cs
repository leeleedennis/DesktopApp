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
            this.QOAtextBox.Text = "";
            this.QOHtextBox.Text = "";
            this.QOOtextBox.Text = "";
            this.MarkupLvltextBox.Text = "";
            this.CosttextBox.Text = "";
        }

        private void InventoryList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult status = MessageBox.Show("Do you really want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (status == DialogResult.No)
                e.Cancel = true;
        }
    }
}
