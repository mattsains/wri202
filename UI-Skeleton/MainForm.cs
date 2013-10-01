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
    public enum Screen { Main, ViewStock, EditStock, NewStock, ViewStaff, EditStaff, NewStaff, ViewAccounts, NewPayment, AddSales, PrintSalesSheet }
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches the screen displayed on the form
        /// This method drops the current screen, so make sure it's done whatever it was doing.
        /// TODO: make sure the previous screen exits properly (there's gotta be an event in the UserControl we can trigger, eg., Unload())
        /// </summary>
        /// <param name="s">Enum corresponding to the screen to be shown</param>
        public void SwitchTo(Screen s)
        {
            contentBox.Controls.Clear();
            
            switch (s)
            {
                case Screen.Main:
                    contentBox.Text = "Tuckshop Management System";
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(mainScreen);
                    break;
                case Screen.ViewStock:
                    contentBox.Text = "View/Edit Stock";
                    ViewStockScreen viewStockScreen = new ViewStockScreen();
                    viewStockScreen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(viewStockScreen);
                    break;
                case Screen.EditStock:
                    break;
                case Screen.NewStock:
                    break;
                case Screen.ViewStaff:
                    break;
                case Screen.EditStaff:
                    break;
                case Screen.NewStaff:
                    break;
                case Screen.ViewAccounts:
                    break;
                case Screen.NewPayment:
                    break;
                case Screen.AddSales:
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
    }
}
