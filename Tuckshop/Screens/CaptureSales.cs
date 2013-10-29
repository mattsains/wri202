using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tuckshop
{
    public partial class CaptureSales : UserControl
    {
        public CaptureSales()
        {
            InitializeComponent();
            //centre the add button
            btnCapSales.Left = (this.Width - btnCapSales.Width) / 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCapSales_Click(object sender, EventArgs e)
        {

        }
    }
}
