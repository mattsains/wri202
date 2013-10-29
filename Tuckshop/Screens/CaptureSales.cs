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

        private void dgCapSales_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            Color postmodern = Color.FromArgb(221, 57, 57);
            if (e.ColumnIndex == 0)
            {
                //user has just entered a staff num
                //validate
                int staffnum;

                if (int.TryParse((string)dgCapSales[0, e.RowIndex].EditedFormattedValue, out staffnum))
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
                    if (((string)dgCapSales[0, e.RowIndex].EditedFormattedValue).Length != 0)
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

                if (int.TryParse((string)dgCapSales[1, e.RowIndex].EditedFormattedValue, out stockid))
                {
                    try
                    {
                        //possibly a valid stock num
                        StockItem s = new StockItem(stockid);
                        dgCapSales[1, e.RowIndex].Style.BackColor = Color.White; //reset colour
                    }
                    catch (ArgumentException)
                    {
                        dgCapSales[1, e.RowIndex].Style.BackColor = postmodern;
                        return;
                    }

                }
                else
                {
                    //not even an integer valued code
                    if (((string)dgCapSales[1, e.RowIndex].EditedFormattedValue).Length != 0)
                        dgCapSales[1, e.RowIndex].Style.BackColor = postmodern;
                    else
                        dgCapSales[1, e.RowIndex].Style.BackColor = Color.White;
                }
            }
            else if (e.ColumnIndex == 2 && (string)dgCapSales[0, e.RowIndex].Value != null)
            {
                //make sure we have enough 
                int temp=0;//needs to have a value because of C#'s route detection
                if (((string)dgCapSales[2, e.RowIndex].EditedFormattedValue).Length == 0 ||
                    int.TryParse((string)dgCapSales[2, e.RowIndex].EditedFormattedValue, out temp))
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

        private void dgCapSales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCapSales.SelectedCells.Count == 1)
                if (e.ColumnIndex < 3)
                    dgCapSales.BeginEdit(true);
                else
                {
                    dgCapSales[e.ColumnIndex,e.RowIndex].Selected=false;
                    if (dgCapSales[0, e.RowIndex + 1] != null)
                    {
                        dgCapSales.CurrentCell = dgCapSales[0, e.RowIndex + 1];
                        dgCapSales.BeginEdit(true);
                    }
                }
        }

        private void btnCapSales_Click(object sender, EventArgs e)
        {

        }
    }
}
