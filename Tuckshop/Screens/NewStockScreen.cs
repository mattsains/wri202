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
    public partial class NewStockScreen : UserControl
    {
        public NewStockScreen()
        {
            InitializeComponent();

            btnCapStock.Left = (this.Width - btnCapStock.Width) / 2;
        }

        private void NewStockScreen_Load(object sender, EventArgs e)
        {
            dgCapStock.CurrentCell = dgCapStock[0, 0];
            dgCapStock.BeginEdit(false);
        }

        private void dgCapStock_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCapStock.SelectedCells.Count == 1)
                dgCapStock.BeginEdit(true);
        }

        private void dgCapStock_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //user has just entered a stock code
                //populate if possible
                int itemid;
                if (int.TryParse((string)dgCapStock[0, e.RowIndex].EditedFormattedValue, out itemid))
                {
                    dgCapStock[0, e.RowIndex].Style.BackColor = Color.White; //reset colour
                    try
                    {
                        //possibly a valid stock code
                        StockItem s = new StockItem(itemid);
                        dgCapStock[2, e.RowIndex].Value = s.Description;
                        dgCapStock[3, e.RowIndex].Value = s.CostPrice;
                        dgCapStock[4, e.RowIndex].Value = s.SellPrice;
                    }
                    catch (ArgumentException)
                    {
                        //no stock item like that exists, but it might be a valid new one
                        return;
                    }

                }
                else
                {
                    //not even an integer valued code
                    if (((string)dgCapStock[0, e.RowIndex].EditedFormattedValue).Length != 0)
                        dgCapStock[0, e.RowIndex].Style.BackColor = Color.Red; //TODO: change this to a more appealing colour
                    else
                        dgCapStock[0, e.RowIndex].Style.BackColor = Color.White;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                int temp;
                if (((string)dgCapStock[1, e.RowIndex].EditedFormattedValue).Length == 0 ||
                    int.TryParse((string)dgCapStock[1, e.RowIndex].EditedFormattedValue, out temp))
                    dgCapStock[1, e.RowIndex].Style.BackColor = Color.White;
                else
                    dgCapStock[1, e.RowIndex].Style.BackColor = Color.Red; //TODO: change this to a more appealing colour
            }
            else if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                decimal temp;
                if (((string)dgCapStock[e.ColumnIndex, e.RowIndex].EditedFormattedValue).Length == 0 ||
                    decimal.TryParse((string)dgCapStock[e.ColumnIndex, e.RowIndex].EditedFormattedValue, out temp))
                    dgCapStock[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                else
                    dgCapStock[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red; //TODO: change this to a more appealing colour
            }
        }

        private void btnCapStock_Click(object sender, EventArgs e)
        {
            bool errors = false;// If there are no errors by the end of the loop, then the program switches to the view stock screen.
            foreach (DataGridViewRow row in dgCapStock.Rows)
            {
                //ignore the last row which might be null
                if ((string)row.Cells[0].Value == null)
                    continue;

                int stockid;

                if (int.TryParse((string)row.Cells[0].Value, out stockid))
                {
                    decimal buyprice, sellprice;
                    int newqty;
                    if (int.TryParse((string)row.Cells[1].Value, out newqty))
                    {
                        if (decimal.TryParse((string)row.Cells[3].Value, out buyprice))
                        {
                            if (decimal.TryParse((string)row.Cells[4].Value, out sellprice))
                            {
                                StockItem s;
                                bool filled = false;
                                try { s = new StockItem(stockid); }
                                catch (ArgumentException)
                                {
                                    s = StockItem.New(stockid, (string)row.Cells[2].Value, newqty, buyprice, sellprice);
                                    filled = true;
                                }
                                //now guaranteed to have a proper stock item in s.
                                if (!filled)
                                {
                                    s.Description = (string)row.Cells[2].Value;
                                    s.QtyInStock += newqty;
                                    s.CostPrice = buyprice;
                                    s.SellPrice = sellprice;
                                }
                            }
                            else
                            {
                                errors = true;
                                Program.ShowError("Invalid Selling price", "'" + (string)row.Cells[4].Value + "' is not a valid currency value", Screen.Main);
                                return;
                            }
                        }
                        else
                        {
                            errors = true;
                            Program.ShowError("Invalid Cost price", "'" + (string)row.Cells[3].Value + "' is not a valid currency value", Screen.Main);
                            return;
                        }
                    }
                    else
                    {
                        errors = true;
                        Program.ShowError("Invalid Quantity", "'" + (string)row.Cells[1].Value + "' is not a valid integer", Screen.Main);
                        return;
                    }
                }
                else
                {
                    errors = true;
                    Program.ShowError("Invalid Item code", "'" + (string)row.Cells[0].Value + "' is not a valid integer item code.", Screen.Main);
                    return;
                }
            }
            if (!errors)
            {
                Program.SwitchTo(Screen.ViewStock);
            }
        }
    }
}
