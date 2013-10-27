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
        private Staff staff;
        public EditStaffScreen(int staffID)
        {
            InitializeComponent();
            this.staff = new Staff(staffID);

            this.txtStaffNum.Text = staff.StaffNum.ToString();
            this.txtfirstName.Text = staff.FirstName;
            this.txtSurname.Text = staff.Surname;
            this.txtEmail.Text = staff.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.SwitchTo(Screen.ViewStaff);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(string.Format("Are you sure you want to delete Staff member {0} {1}?", staff.FirstName, staff.Surname), "Deleting Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
                staff.Delete();
            Program.SwitchTo(Screen.ViewStaff);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: input validation
            staff.FirstName = txtfirstName.Text;
            staff.Surname = txtSurname.Text;
            staff.Email = txtEmail.Text;
            Program.SwitchTo(Screen.ViewStaff);
        }
    }
}
