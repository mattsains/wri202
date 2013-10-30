using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tuckshop
{
    public partial class CaptureSales : UserControl
    {
        public CaptureSales()
        {
            InitializeComponent();
            //centre the add button
            btnCapSales.Left = (this.Width - btnCapSales.Width) / 2;
        }


       private void dgCapSales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCapSales.SelectedCells.Count == 1)
                if (e.ColumnIndex < 3)
                    dgCapSales.BeginEdit(true);
                else
                {
                    dgCapSales[e.ColumnIndex, e.RowIndex].Selected = false;
                    if (Control.ModifierKeys == Keys.Shift && e.ColumnIndex > 0)
                        cellToChangeTo = dgCapSales[e.ColumnIndex - 1, e.RowIndex];
                    else if (e.RowIndex + 1 < dgCapSales.Rows.Count)
                        cellToChangeTo = dgCapSales[0, e.RowIndex + 1];
                    else cellToChangeTo = null;

                    if (cellToChangeTo != null)
                    {
                        BeginInvoke(new MethodInvoker(ChangeCellTo));
                        dgCapSales.BeginEdit(true);
                    }
                }
        }
        //I don't even
        private DataGridViewCell cellToChangeTo;
        private void ChangeCellTo()
        {
            if (cellToChangeTo != null)
                dgCapSales.CurrentCell = cellToChangeTo;
        }

        private void btnCapSales_Click(object sender, EventArgs e)
        {
            Dictionary<int, List<Tuple<StockItem, int>>> staffpurchases = new Dictionary<int, List<Tuple<StockItem, int>>>();
            int lastStaffId = -1;
            foreach (DataGridViewRow row in dgCapSales.Rows)
            {
                int staffid;
                if (row.Cells[0].Value == null)
                    break; //we are at the end of the datagrid, this is the empty row used for insertions
                if (int.TryParse((string)row.Cells[0].Value, out staffid))
                {
                    try
                    {
                        Staff s = new Staff(staffid);
                        int stockid;
                        if (int.TryParse((string)row.Cells[1].Value, out stockid))
                        {
                            try
                            {
                                StockItem si = new StockItem(stockid);
                                int qty;
                                if (int.TryParse((string)row.Cells[2].Value, out qty) && qty > 0)
                                {
                                    if (qty <= si.QtyInStock)
                                    {
                                        //right, after all that, time to add to the dictionary
                                        if (lastStaffId == staffid)
                                            staffpurchases[staffid].Add(new Tuple<StockItem, int>(si, qty));
                                        else
                                        {
                                            lastStaffId = staffid;
                                            staffpurchases.Add(staffid, new List<Tuple<StockItem, int>>() { new Tuple<StockItem, int>(si, qty) });
                                        }
                                    }
                                    else
                                    {
                                        Program.ShowError("Invalid Quantity", "The tuckshop does not have enough " + si.Description + " in stock", Screen.Main);
                                        return;
                                    }
                                }
                                else
                                {
                                    Program.ShowError("Invalid Quantity", "Please enter a positive quantity", Screen.Main);
                                    return;
                                }
                            }
                            catch
                            {
                                Program.ShowError("Invalid stock code", "The stock code '" + row.Cells[1].Value + "' doesn't exist.", Screen.Main);
                                return;
                            }
                        }
                        else
                        {
                            Program.ShowError("Invalid stock code", "The stock code '" + row.Cells[1].Value + "' is invalid.", Screen.Main);
                            return;
                        }
                    }
                    catch
                    {
                        Program.ShowError("Invalid Staff number", "The staff number '" + row.Cells[0].Value + "' is invalid.", Screen.Main);
                        return;
                    }
                }
                else
                {
                    Program.ShowError("Invalid Staff number", "The staff number '" + row.Cells[0].Value + "' is invalid.", Screen.Main);
                    return;
                }
            }

            //right database time
            DateTime date = txtDate.Value;

            foreach (KeyValuePair<int, List<Tuple<StockItem, int>>> kp in staffpurchases)
            {
                Staff s = new Staff(kp.Key);
                Purchase p = Purchase.New(date, s);
                foreach (Tuple<StockItem, int> item in kp.Value)
                    PurchaseItem.New(p, item.Item1, item.Item2);
            }
            //and we are done.
            MessageBox.Show("The new sales were recorded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.SwitchTo(Screen.Main);
        }

        private void dgCapSales_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Color postmodern = Color.FromArgb(221, 57, 57);
            if (e.ColumnIndex == 0)
            {
                //user has just entered a staff num
                //validate
                int staffnum;

                if (int.TryParse((string)e.FormattedValue, out staffnum))
                {
                    try
                    {
                        //possibly a valid staff num
                        Staff s = new Staff(staffnum);
                        dgCapSales[0, e.RowIndex].Style.BackColor = Color.White; //reset colour
                    }
                    catch (ArgumentException)
                    {
                        dgCapSales[0, e.RowIndex].Style.BackColor = postmodern;
                        return;
                    }

                }
                else
                {
                    //not even an integer valued code
                    if (((string)e.FormattedValue).Length != 0)
                        dgCapSales[0, e.RowIndex].Style.BackColor = postmodern;
                    else
                        dgCapSales[0, e.RowIndex].Style.BackColor = Color.White;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                //user has just entered a stock code
                //validate
                int stockid;

                if (int.TryParse((string)e.FormattedValue, out stockid))
                {
                    try
                    {
                        //possibly a valid stock num
                        StockItem s = new StockItem(stockid);
                        dgCapSales[1, e.RowIndex].Style.BackColor = Color.White; //reset colour
                        dgCapSales[3, e.RowIndex].Value = s.Description;
                    }
                    catch (ArgumentException)
                    {
                        dgCapSales[3, e.RowIndex].Value = "";
                        dgCapSales[1, e.RowIndex].Style.BackColor = postmodern;
                        return;
                    }

                }
                else
                {
                    //not even an integer valued code
                    if (((string)e.FormattedValue).Length != 0)
                    {
                        dgCapSales[1, e.RowIndex].Style.BackColor = postmodern;
                        dgCapSales[3, e.RowIndex].Value = "";
                    }
                    else
                    {
                        dgCapSales[3, e.RowIndex].Value = "";
                        dgCapSales[1, e.RowIndex].Style.BackColor = Color.White;
                    }
                }

                //make sure we have enough 
                int temp = 0; //needs to have a value because of C#'s route detection
                if (int.TryParse((string)dgCapSales[2, e.RowIndex].EditedFormattedValue, out temp))
                {
                    try
                    {
                        int stocknum = int.Parse((string)e.FormattedValue);
                        StockItem s = new StockItem(stocknum);
                        if (s.QtyInStock < temp)
                        {
                            //not enough stock
                            dgCapSales[2, e.RowIndex].Style.BackColor = postmodern;
                        }
                        else
                            dgCapSales[2, e.RowIndex].Style.BackColor = Color.White;
                    }
                    catch
                    {
                        //all errors are the user's fault. Great programming mentality
                        dgCapSales[2, e.RowIndex].Style.BackColor = postmodern;
                    }
                }
                else if (((string)dgCapSales[2, e.RowIndex].EditedFormattedValue).Length == 0)
                    dgCapSales[2, e.RowIndex].Style.BackColor = Color.White;
                else
                    dgCapSales[2, e.RowIndex].Style.BackColor = postmodern;
            }
            else if (e.ColumnIndex == 2 && (string)dgCapSales[0, e.RowIndex].Value != null)
            {
                //make sure we have enough 
                int temp = 0;//needs to have a value because of C#'s route detection
                if (((string)e.FormattedValue).Length == 0 ||
                    (int.TryParse((string)e.FormattedValue, out temp) && temp > 0))
                {
                    try
                    {
                        int stocknum = int.Parse((string)dgCapSales[1, e.RowIndex].Value);
                        StockItem s = new StockItem(stocknum);
                        if (s.QtyInStock < temp)
                        {
                            //not enough stock
                            dgCapSales[e.ColumnIndex, e.RowIndex].Style.BackColor = postmodern;
                        }
                        else
                            dgCapSales[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    }
                    catch
                    {
                        //all errors are the user's fault. Great programming mentality
                        dgCapSales[e.ColumnIndex, e.RowIndex].Style.BackColor = postmodern;
                    }
                }
                else
                    dgCapSales[e.ColumnIndex, e.RowIndex].Style.BackColor = postmodern;
            }
        }
    }
}
