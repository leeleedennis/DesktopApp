using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Administrator : Form
    {
        public bool verified = false;

        private int childFormNumber = 0;

        public Administrator()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
            childForm.Location = new Point(0, 0);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void inventoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryList list = new InventoryList();
            list.MdiParent = this;
            list.Show();
            list.Location = new Point(0, 0);
        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInventory manage = new ManageInventory();
            manage.MdiParent = this;
            manage.Show();
            manage.Location = new Point(0, 0);
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.MdiParent = this;
            add.Show();
            add.Location = new Point(0, 0);
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword();
            reset.MdiParent = this;
            reset.Show();
            reset.Location = new Point(0, 0);
        }

        private void purcheaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder purchase = new PurchaseOrder();
            purchase.MdiParent = this;
            purchase.Show();
            purchase.Location = new Point(0, 0);
        }

        private void returnOderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm form = new ReturnForm();
            form.MdiParent = this;
            form.Show();
            form.Location = new Point(0, 0);
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.MdiParent = this;
            orders.Show();
            orders.Location = new Point(0, 0);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* verified = false;
             Login login = new Login();
             login.MdiParent = this;
             login.Show();    */

            Application.Exit();
        }

        public System.Windows.Forms.Form logWin = null;

        public Administrator(System.Windows.Forms.Form Login)
        {
            InitializeComponent();
            this.logWin = Login;
            this.logWin.Close();
        }

        private void estimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estimate estimate = new Estimate();
            estimate.MdiParent = this;
            estimate.Show();
            estimate.Location = new Point(0, 0);
        }

        private void creditMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditMemo credit = new CreditMemo();
            credit.MdiParent = this;
            credit.Show();
            credit.Location = new Point(0, 0);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.MdiParent = this;
            invoice.Show();
            invoice.Location = new Point(0, 0);
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
