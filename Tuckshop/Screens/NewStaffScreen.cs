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
    public partial class NewStaffScreen : UserControl
    {
        public NewStaffScreen()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.SwitchTo(Screen.ViewStaff);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int staffnum = 0;
            try
            {
                staffnum = int.Parse(txtStaffNum.Text);
            }
            catch (FormatException)
            {
                Program.ShowError("Invalid Staff Number", "Please enter a numeric Staff Number", Screen.ViewStaff, txtStaffNum);
                return;
            }

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
            try
            {
                Staff.New(staffnum, txtfirstName.Text, txtSurname.Text, txtEmail.Text);
            }
            catch (Exception ex)
            {
                Program.ShowError("Database error", "Failed to add the new staff member!", Screen.ViewStaff);
                return;
            }
            MessageBox.Show("The staff member was added to the system", "Success", MessageBoxButtons.OK);
            Program.SwitchTo(Screen.ViewStaff, staffnum);
        }
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (sender == txtStaffNum)
                    txtfirstName.Focus();
                else if (sender == txtfirstName)
                    txtSurname.Focus();
                else if (sender == txtSurname)
                    txtEmail.Focus();
                else if (sender == txtEmail)
                    btnAdd_Click(sender, new EventArgs());
                e.Handled = true;
            }
        }

        private void NewStaffScreen_Load(object sender, EventArgs e)
        {
            txtStaffNum.Focus();
        }

    }
}
