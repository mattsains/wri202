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
    public partial class ViewAccountsScreen : UserControl
    {
        public ViewAccountsScreen()
        {
            InitializeComponent();
            //some example data
            dgAccounts.Rows.Add("Dean Gifford", "R 12.52");
            dgAccounts.Rows.Add("Douglas Bentley", "R 0.00");
            dgAccounts.Rows.Add("Matthew Sainsbury", "R 1.23");

        }

        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgAccounts.Rows)
                row.Cells["cEmail"].Value = true;
        }

        private void btnUnmarkAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgAccounts.Rows)
                row.Cells["cEmail"].Value = false;
        }
    }
}
