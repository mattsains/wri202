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
    public partial class NewPaymentScreen : UserControl
    {
        public NewPaymentScreen()
        {
            InitializeComponent();
        }

        private void NewPaymentScreen_Resize(object sender, EventArgs e)
        {
            btnProcess.Left = (this.Width - btnProcess.Width) / 2;
            panel1.Width = calDate.Width + 18; //seems to break the page
            panel1.Left = (this.Width - panel1.Width) / 2;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            DateTime Date = calDate.SelectionStart;

            String Name = txtName.Text;

            if (Name == "")
            {
                Program.ShowError("Incomplete Details", "No Name was Entered", Screen.Main, txtName);
                return;
            }

            Decimal Amount = getAmount();

            if (Amount == 0)
                return;

            List<Staff> staffmember = Staff.All(s => (s.FirstName + " " + s.Surname).ToLower() == Name.ToLower());

            if (staffmember.Count == 0)
            {
                Program.ShowError("Incorrect Information", "Specified Staff Member Does not Exist", Screen.Main, txtName);
                return;
            }


            Payment.New(Date, Amount, staffmember[0]);
            MessageBox.Show("The new payment was recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAmount.Text = "";
            txtName.Clear();
            calDate.SelectionStart = DateTime.Now;
        }

        private Decimal getAmount()
        {

            String Amount = txtAmount.Text.ToUpper().Replace("R", "").Replace(',', '.');
            Decimal Amnt;

            bool Changed = Decimal.TryParse(Amount, out Amnt);

            if (!Changed)
                Amount = Amount.Remove(0, 2);

            Changed = Decimal.TryParse(Amount, out Amnt);

            if (Amount == "")
            {
                Program.ShowError("Incomplete Details", "No Amount Was Entered", Screen.Main, txtAmount);
                return 0;
            }

            Changed = Decimal.TryParse(Amount, out Amnt);

            if (!Changed)
            {
                Program.ShowError("Invalid Entry", "Amount field can only contain Numbers", Screen.NewPayment, txtAmount);
                txtAmount.Text = "";
                return 0;
            }
            if (Amnt < 0)
            {
                Program.ShowError("Invalid Entry", "Amount field can not be negative", Screen.NewPayment, txtAmount);
                txtAmount.Text = "";
                return 0;
            }
            return Amnt;


        }

        private void NewPaymentScreen_Load(object sender, EventArgs e)
        {
            foreach (Staff s in Staff.All())
                txtName.AutoCompleteCustomSource.Add(s.FirstName + " " + s.Surname);
        }


    }
}
