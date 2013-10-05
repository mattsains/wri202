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
    public partial class EditStaffScreen : UserControl
    {
        private int staffID;
        public EditStaffScreen(int staffID)
        {
            InitializeComponent();
            this.staffID=staffID;
            this.txtStaffNum.Text = staffID.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.SwitchTo(Screen.ViewStaff);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Are you sure you want to delete Staff member {0}?", "Matthew Sainsbury"), "Deleting Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
