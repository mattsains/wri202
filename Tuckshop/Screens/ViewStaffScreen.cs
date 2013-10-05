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
    public partial class ViewStaffScreen : UserControl
    {
        public ViewStaffScreen()
        {
            InitializeComponent();
            //centre the add button
            btnAdd.Left = (this.Width - btnAdd.Width) / 2;
            //Some example data
            dgStaff.Rows.Add(1, "Matthew", "Sainsbury", "matthew@sainsbury.za.net", "R 123.00");
            dgStaff.Rows.Add(2, "Dean", "Gifford", "dean@gifford.com", "R 500.25");
            dgStaff.Rows.Add(3, "Douglas", "Bentley", "doug@bent.ley", "R 5.00");
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
        /// ie., the user wants to edit a staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.SwitchTo(Screen.EditStaff, dgStaff[0, e.RowIndex].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.SwitchTo(Screen.NewStaff);
        }
    }
}
