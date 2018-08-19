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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[]
                {   new DataColumn ("Item Code", typeof(string)),
                    new DataColumn ("Quantity", typeof(int)),
                    new DataColumn ("Description", typeof(string)),
                    new DataColumn ("UOM", typeof(int)),
                    new DataColumn ("Price each", typeof(double)),
                    new DataColumn ("Amount", typeof(double)),
                    new DataColumn ("Tax", typeof(int)),

                });
        }
    }
}
