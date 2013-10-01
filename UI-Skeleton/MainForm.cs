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
    public enum Screen { Main, ViewStock, EditStock, NewStock, ViewStaff, EditStaff, ViewAccounts, AddPayment, AddSales, PrintSalesSheet }
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void SwitchTo(Screen s)
        {
            contentBox.Controls.Clear();
            switch (s)
            {
                case Screen.Main:
                    contentBox.Text = "Tuckshop Management System";
                    MainScreen screen = new MainScreen();
                    screen.Dock = DockStyle.Fill;
                    contentBox.Controls.Add(screen);
                    break;
                case Screen.EditStock:
                    break;
                case Screen.NewStock:
                    break;
                case Screen.ViewStaff:
                    break;
                case Screen.EditStaff:
                    break;
                case Screen.ViewAccounts:
                    break;
                case Screen.AddPayment:
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
