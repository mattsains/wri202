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
        int selectedid;
        public ViewStockScreen(params object[] data)
        {
            InitializeComponent();
            if (data.Length != 0)
            {
                selectedid = (int)data[0];
            }
        }

        private void ViewStockScreen_Load(object sender, EventArgs e)
        {
            //centre the print button
            FillDataGrid(StockItem.All());
            foreach (DataGridViewRow row in dgItems.Rows)
                if ((int)row.Cells[0].Value == selectedid)
                    row.Selected = true;
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
            if (e.RowIndex >= 0)
                Program.SwitchTo(Screen.EditStock, dgItems[0, e.RowIndex].Value);
        }
        /// <summary>
        /// Is triggered twice when the radio selection is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdAllStock_CheckedChanged(object sender, EventArgs e)
        {
            dgItems.Rows.Clear();

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
            string title = "Stock List";
            if (rdAllStock.Checked)
                title = "List of all stock";
            else if (rdInStockOnly.Checked)
                title = "Items in stock";

            if (txtSearch.Text != "Search..." && txtSearch.Text != "")
                title += " matching '" + txtSearch.Text + "'";

            Program.PrintStockList(dateTimePicker1.Value, title, dgItems.Rows);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<StockItem> stock = new List<StockItem>();

            if (txtSearch.Text == "Search..." || txtSearch.Text == "")
                stock = StockItem.All();
            else
            {
                List<int> stocknums = DataObject.Search("ItemNum", "StockItem", new string[] { "ItemNum", "Description" }, txtSearch.Text);
                stock = stocknums.ConvertAll(stocknum => new StockItem(stocknum));//cool! <<sure is!
            }
            dgItems.Rows.Clear();
            foreach (StockItem s in stock)
                dgItems.Rows.Add(s.Select("ItemNum", "QtyInStock", "Description", "CostPrice", "SellPrice"));
        }

    }
}