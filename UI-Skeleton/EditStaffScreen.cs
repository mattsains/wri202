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
    }
}
