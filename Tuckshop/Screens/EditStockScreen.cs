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
    public partial class EditStockScreen : UserControl
    {
        private int itemID;
        public EditStockScreen(int itemID)
        {
            InitializeComponent();
            numQuantity.Maximum = decimal.MaxValue;
            this.itemID = itemID;
            txtItemNumber.Text = itemID.ToString();
            StockItem selected = new StockItem(itemID);
            numQuantity.Value = selected.QtyInStock;
            txtCostPrice.Text = selected.CostPrice.ToString();
            txtSellPrice.Text = selected.SellPrice.ToString();
            txtDescription.Text = selected.Description;

            pnlNotBlue.Left = (this.Width - pnlNotBlue.Width) / 2;
            btnSave.Left = (this.Width - (3*btnSave.Width + 2* 6)) / 2;
            btnCancel.Left = btnSave.Right + 6;
            btnDelete.Left = btnCancel.Right + 6;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Are you sure you want to delete Item #{0}?", "123"), "Deleting Item From Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void EditStockScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.SwitchTo(Screen.ViewStock);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool errors = false;// If there are no errors by the end then the program switches to the view stock screen.
                int stockid;

                if (!string.IsNullOrWhiteSpace(txtItemNumber.Text) && int.TryParse(txtItemNumber.Text, out stockid))
                {
                    decimal buyprice, sellprice;
                    int newqty;
                    if (int.TryParse(numQuantity.Value.ToString(), out newqty))
                    {
                        if (!string.IsNullOrWhiteSpace(txtCostPrice.Text) && decimal.TryParse(txtCostPrice.Text, out buyprice))
                        {
                            if (!string.IsNullOrWhiteSpace(txtSellPrice.Text) && decimal.TryParse(txtSellPrice.Text, out sellprice))
                            {
                                StockItem s;
                                bool filled = false;
                                try { s = new StockItem(stockid); }
                                catch (ArgumentException)
                                {
                                    if (string.IsNullOrWhiteSpace(txtDescription.Text))
                                    {
                                        errors = true;
                                        Program.ShowError("Invalid Description", "Description not found.", Screen.Main);
                                        return;
                                    }
                                    s = StockItem.New(stockid, txtDescription.Text, newqty, buyprice, sellprice);
                                    filled = true;
                                }
                                //now guaranteed to have a proper stock item in s.
                                if (!filled)
                                {
                                    s.Description = txtDescription.Text;
                                    s.QtyInStock += newqty;
                                    s.CostPrice = buyprice;
                                    s.SellPrice = sellprice;
                                }
                            }
                            else
                            {
                                errors = true;
                                if (string.IsNullOrWhiteSpace(txtSellPrice.Text))
                                    Program.ShowError("Invalid Selling price", "Selling price not found.", Screen.Main);
                                else
                                    Program.ShowError("Invalid Selling price", "'" + txtSellPrice.Text + "' is not a valid currency value", Screen.Main);
                                return;
                            }
                        }
                        else
                        {
                            errors = true;
                            if (string.IsNullOrWhiteSpace(txtCostPrice.Text))
                                Program.ShowError("Invalid Cost price", "Cost price not found.", Screen.Main);
                            else
                                Program.ShowError("Invalid Cost price", "'" + txtCostPrice.Text + "' is not a valid currency value", Screen.Main);
                            return;
                        }
                    }
                    else
                    {
                        errors = true;
                            Program.ShowError("Invalid Quantity", "'" + numQuantity.Value.ToString() + "' is not a valid integer", Screen.Main);
                        return;
                    }
                }
                else
                {
                        errors = true;
                    Program.ShowError("Invalid Item code", "'" + txtItemNumber.Text + "' is not a valid integer item code.", Screen.Main);
                    return;
                }
            
            if (!errors)
            {
                Program.SwitchTo(Screen.ViewStock);
            }
        }
    }
}
