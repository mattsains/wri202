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
    public partial class ViewStockScreen : UserControl
    {
        public ViewStockScreen(params object[] data)
        {
            InitializeComponent();
        }

        private void ViewStockScreen_Load(object sender, EventArgs e)
        {
            //centre the print button
            btnPrint.Left = (this.Width - btnPrint.Width) / 2;
            //Some example data
            dgItems.Rows.Add(1, 10, "2 Minute Noodles", "R 3.50", "R 4.50");
            dgItems.Rows.Add(2, 4, "Big Corn Bites", "R 1.50", "R 2.50");
            dgItems.Rows.Add(3, 16, "Bravo (Chips in a Can!)", "R 7.00", "R 8.50");
            dgItems.Rows.Add(4, 8, "Chips (Simba & Lays)", "R 3.50", "R 3.80");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search..." || txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
            else
            {
                //searching routine
            }
        }
        /// <summary>
        /// This gets triggered when a cell is double clicked on the data grid.
        /// ie., the user wants to edit an item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.SwitchTo(Screen.EditStock, dgItems[0, e.RowIndex].Value);
        }
        /// <summary>
        /// Is triggered twice when the radio selection is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdAllStock_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioSender = (RadioButton)sender;
            //Taking care of the double trigger problem:
            if (radioSender.Checked)
            {
                // radioSender is the Radio button which is now selected
            }
        }

    }
}
