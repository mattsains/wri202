using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_Skeleton
{
    public enum Screen { Main, ViewStock, EditStock, NewStock, ViewStaff, EditStaff, NewStaff, ViewAccounts, NewPayment, NewSales, PrintSalesSheet }
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches the screen displayed on the form
        /// This method drops the current screen, so make sure it's done whatever it was doing.
        /// </summary>
        /// <param name="s">Enum corresponding to the screen to be shown</param>
        /// <param name="data">If you want to send data to the screen to be opened, this is where it goes. Different screens have different requirements for this field</param>
        /// TODO: make sure the previous screen exits properly (there's gotta be an event in the UserControl we can trigger, eg., Unload())
        public void SwitchTo(Screen s, params object[] data)
        {
            contentBox.Controls.Clear();

            switch (s)
            {
                case Screen.Main:
                    lblHeader.Text = "Tuckshop Management System";
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(mainScreen);
                    break;
                case Screen.ViewStock:
                    lblHeader.Text = "View/Edit Stock";
                    ViewStockScreen viewStockScreen = new ViewStockScreen(data);
                    viewStockScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(viewStockScreen);
                    break;
                case Screen.EditStock:
                    int itemid;

                    try { itemid = (int)data[0]; }
                    catch (InvalidCastException e) { throw new ArgumentException("The Edit Stock screen requires an itemID", e); }

                    lblHeader.Text = string.Format("Edit Stock Item #{0}", itemid);
                    EditStockScreen editStockScreen = new EditStockScreen(itemid);
                    editStockScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(editStockScreen);
                    break;
                case Screen.NewStock:
                    lblHeader.Text = "Capture New Stock";
                    NewStockScreen newStockScreen = new NewStockScreen();
                    newStockScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(newStockScreen);
                    break;
                case Screen.ViewStaff:
                    lblHeader.Text = "View/Edit Staff";
                    ViewStaffScreen viewStaffScreen = new ViewStaffScreen();
                    viewStaffScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(viewStaffScreen);
                    break;
                case Screen.EditStaff:
                    int staffid;

                    try { staffid = (int)data[0]; }
                    catch (InvalidCastException e) { throw new ArgumentException("The Edit Staff screen requires a staffID", e); }

                    lblHeader.Text = string.Format("Edit Staff member #{0}", staffid);
                    EditStaffScreen editStaffScreen = new EditStaffScreen(staffid);
                    editStaffScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(editStaffScreen);
                    break;
                case Screen.NewStaff:
                    lblHeader.Text = "New Staff Member";
                    NewStaffScreen newStaffScreen = new NewStaffScreen();
                    newStaffScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(newStaffScreen);
                    break;
                case Screen.ViewAccounts:
                    lblHeader.Text = "View/Email Accounts";
                    ViewAccountsScreen viewAccountsScreen = new ViewAccountsScreen();
                    viewAccountsScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(viewAccountsScreen);
                    break;
                case Screen.NewPayment:
                    lblHeader.Text = "Process Payment";
                    NewPaymentScreen newPaymentScreen = new NewPaymentScreen();
                    newPaymentScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(newPaymentScreen);
                    break;
                case Screen.NewSales:
                    lblHeader.Text = "Capture Sales";
                    CaptureSales capSalesScreen = new CaptureSales();
                    capSalesScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(capSalesScreen);
                    break;
                case Screen.PrintSalesSheet:
                    break;
                default:
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SwitchTo(Screen.Main);
        }

        private void stockViewMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTo(Screen.ViewStock);
        }

        private void viewStaffMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTo(Screen.ViewStaff);
        }

        private void captureSalesMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTo(Screen.NewSales);
        }

        private void newStockMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTo(Screen.NewStock);
        }

        private void accountsStaffMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTo(Screen.ViewAccounts);
        }

        private void paymentsStaffMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTo(Screen.NewPayment);
        }

        private void printSalesMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }
    }
}
