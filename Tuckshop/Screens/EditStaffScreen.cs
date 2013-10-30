using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            {
                staff.Delete();
                MessageBox.Show("The staff member was removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.SwitchTo(Screen.ViewStaff);
            }
            else
            {
                MessageBox.Show("The staff member was not removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfirstName.Text.Trim() == "")
            {
                Program.ShowError("Invalid First Name", "Please enter a first name", Screen.ViewStaff, txtfirstName);
                return;
            }
            if (txtSurname.Text.Trim() == "")
            {
                Program.ShowError("Invalid Surname", "Please enter a surname", Screen.ViewStaff, txtSurname);
                return;
            }
            if (!Regex.IsMatch(txtEmail.Text, "^.+@.+$"))
            {
                Program.ShowError("Invalid Email", "Please enter a valid email address", Screen.ViewStaff, txtEmail);
                return;
            }
            //by now we are validated
            staff.FirstName = txtfirstName.Text;
            staff.Surname = txtSurname.Text;
            staff.Email = txtEmail.Text;
            MessageBox.Show("The staff member was updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.SwitchTo(Screen.ViewStaff);
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (sender == txtfirstName)
                    txtSurname.Focus();
                else if (sender == txtSurname)
                    txtEmail.Focus();
                else if (sender == txtEmail)
                    btnSave_Click(sender, new EventArgs());
                e.Handled = true;
            }
        }

        private void EditStaffScreen_Load(object sender, EventArgs e)
        {
            txtfirstName.Focus();
        }
    }
}
