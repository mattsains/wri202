using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_Skeleton
{
    public partial class EditStockScreen : UserControl
    {
        private int itemID;
        public EditStockScreen(int itemID)
        {
            InitializeComponent();
            numQuantity.Maximum = decimal.MaxValue;
            this.itemID = itemID;
            txtItemNumber.Text = itemID.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Are you sure you want to delete Item #{0}?", "123"), "Deleting Item From Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
