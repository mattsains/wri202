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
    public partial class ViewStockScreen : UserControl
    {
        public ViewStockScreen(params object[] data)
        {
            InitializeComponent();
        }

        private void ViewStockScreen_Load(object sender, EventArgs e)
        {
            //centre the print button
            FillDataGrid(StockItem.All());
        }
        private void FillDataGrid(List<StockItem> items)
        {
            foreach (StockItem i in items)
                dgItems.Rows.Add(i.Select("ItemNum", "QtyInStock", "Description", "CostPrice", "SellPrice"));
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search..." || txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
            else
            {
                //searching routine
            }
        }
        /// <summary>
        /// This gets triggered when a cell is double clicked on the data grid.
        /// ie., the user wants to edit an item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.SwitchTo(Screen.EditStock, dgItems[0, e.RowIndex].Value);
        }
        /// <summary>
        /// Is triggered twice when the radio selection is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdAllStock_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioSender = (RadioButton)sender;
            //Taking care of the double trigger problem:
            if (radioSender.Checked)
            {
                // radioSender is the Radio button which is now selected
                if (radioSender == rdAllStock)
                    FillDataGrid(StockItem.All());
                else
                    FillDataGrid(StockItem.All(item => item.QtyInStock != 0));
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Program.SwitchTo(Screen.PrintPreview, "Print Stock List", "file:///C:/Documents%20and%20Settings/Matt/Desktop/varsity%20working%20folder/wri202/UI-Skeleton/StockItemList.html");
        }

    }
}
