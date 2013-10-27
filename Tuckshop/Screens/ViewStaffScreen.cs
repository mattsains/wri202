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
        int highlightstaffnum;
        public ViewStaffScreen(int highlightstaffnum=-1)
        {
            InitializeComponent();

            //centre the add button
            btnAdd.Left = (this.Width - btnAdd.Width) / 2;

            //fill the data grid with... data?
            foreach (Staff s in Staff.All())
            {
                dgStaff.Rows.Add(s.Select("StaffNum", "FirstName", "Surname", "Email", "Balance"));
            }
            //set the variable that makes the right row be highlighted.
            //can't actually highlight the row now because the datagrid isn't alive properly yet
            this.highlightstaffnum = highlightstaffnum;
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

        private void ViewStaffScreen_Load(object sender, EventArgs e)
        {
            //highlight a new row if needed.
            if (highlightstaffnum != -1)
                foreach (DataGridViewRow row in dgStaff.Rows)
                {
                    if ((int)row.Cells[0].Value == highlightstaffnum)
                        row.Selected = true;
                }
        }
    }
}
