using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tuckshop
{
    public partial class ViewAccountsScreen : UserControl
    {
        public ViewAccountsScreen()
        {
            InitializeComponent();
            //some example data
            foreach (Staff s in Staff.All())
            {
                object[] so = s.Select("staffnum","firstname", "balance");
                so[1] += " " + s.Surname;
                dgAccounts.Rows.Add(so);
            }

            btnMarkAll.Left = (this.Width - (3 * btnMarkAll.Width + 2 * 6)) / 2;
            btnUnmarkAll.Left = btnMarkAll.Right + 6;
            btnEmail.Left = btnUnmarkAll.Right + 6;
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

        private void btnEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Because this feature might be run very often while testing this application, and because people won't appreciate getting a thousand nonsense emails, Instead this program will save copies of the emails to your desktop. Please find them there.", "Email feature disabled", MessageBoxButtons.OK);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\reminderEmails\\";
            Directory.CreateDirectory(path);
            foreach (DataGridViewRow row in dgAccounts.Rows)
            {
                if ((bool)row.Cells[3].Value)
                {
                    //means email please
                    Staff s = new Staff((int)row.Cells[0].Value);
                    StreamWriter xml = new StreamWriter(path + s.StaffNum + ".html");
                    xml.WriteLine(@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">
<html>
    <head>
    <style type=""text/css"">
            body
            {
                font-family=""Microsoft Sans Serif"";
            }
            td
            {
                border:1px solid #000;
            }
            table
            {
                border-collapse:collapse;
            }
        </style>
    </head>
	<body>");
                    xml.WriteLine("<p>Hello " + s.FirstName + "</p>");
                    xml.WriteLine("<p>Just a quick reminder that you owe the tuckshop " + s.Balance.ToString("C2") + "</p>");
                    xml.WriteLine(@"<p>Here is a itemized statement:</p>
        <table>
            <tr><th>Date</th><th>Description</th><th>Quantity</th><th>Amount</th></tr>");
                    List<Payment> payments = Payment.All(payment => payment.staff == s);
                    List<PurchaseItem> purchases = PurchaseItem.All(pi => pi.purchase.staff == s);
                    List<Tuple<DateTime, string>> statlines = new List<Tuple<DateTime, string>>();

                    foreach (Payment p in payments)
                    {
                        statlines.Add(new Tuple<DateTime, string>(p.date, "<tr><td>" + p.date.ToLongDateString() + "</td><td>Payment</td><td></td><td>" + p.amountPaid + "</td></tr>"));
                    }
                    foreach (PurchaseItem pi in purchases)
                    {
                        statlines.Add(new Tuple<DateTime, string>(pi.purchase.date, "<tr><td>" + pi.purchase.date.ToLongDateString() + "</td><td>" + pi.item.Description + "</td><td>" + pi.QtyBought + "</td><td>" + pi.item.SellPrice + "</td></tr>"));
                    }

                    statlines.Sort(delegate(Tuple<DateTime, string> tuple1, Tuple<DateTime, string> tuple2)
                            { return tuple1.Item1.CompareTo(tuple2.Item1); }); //sort on date

                    foreach (Tuple<DateTime, string> statline in statlines)
                        xml.WriteLine(statline.Item2);

                    if (statlines.Count == 0)
                        xml.WriteLine("<tr><td colspan=\"4\">Nothing to show!</td></tr>");

                    xml.WriteLine(@"</table>
	</body>
</html>");
                    xml.Close();
                }
            }
            Program.SwitchTo(Screen.Main);
        }
    }
}
