﻿namespace Tuckshop
{
    partial class ViewStockScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdAllStock = new System.Windows.Forms.RadioButton();
            this.rdInStockOnly = new System.Windows.Forms.RadioButton();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.cItemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // rdAllStock
            // 
            this.rdAllStock.AutoSize = true;
            this.rdAllStock.Checked = true;
            this.rdAllStock.Location = new System.Drawing.Point(4, 5);
            this.rdAllStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdAllStock.Name = "rdAllStock";
            this.rdAllStock.Size = new System.Drawing.Size(97, 17);
            this.rdAllStock.TabIndex = 0;
            this.rdAllStock.TabStop = true;
            this.rdAllStock.Text = "Show All Stock";
            this.rdAllStock.UseVisualStyleBackColor = true;
            this.rdAllStock.CheckedChanged += new System.EventHandler(this.rdAllStock_CheckedChanged);
            // 
            // rdInStockOnly
            // 
            this.rdInStockOnly.AutoSize = true;
            this.rdInStockOnly.Location = new System.Drawing.Point(107, 5);
            this.rdInStockOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdInStockOnly.Name = "rdInStockOnly";
            this.rdInStockOnly.Size = new System.Drawing.Size(143, 17);
            this.rdInStockOnly.TabIndex = 1;
            this.rdInStockOnly.Text = "Show only items in Stock";
            this.rdInStockOnly.UseVisualStyleBackColor = true;
            this.rdInStockOnly.CheckedChanged += new System.EventHandler(this.rdAllStock_CheckedChanged);
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AllowUserToOrderColumns = true;
            this.dgItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.dgItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cItemNum,
            this.cQuantity,
            this.cDescription,
            this.cCostPrice,
            this.cSellPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgItems.Location = new System.Drawing.Point(3, 32);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgItems.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.Size = new System.Drawing.Size(595, 394);
            this.dgItems.TabIndex = 3;
            this.dgItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellDoubleClick);
            // 
            // cItemNum
            // 
            this.cItemNum.Frozen = true;
            this.cItemNum.HeaderText = "Num";
            this.cItemNum.Name = "cItemNum";
            this.cItemNum.ReadOnly = true;
            this.cItemNum.Width = 54;
            // 
            // cQuantity
            // 
            this.cQuantity.HeaderText = "Qty";
            this.cQuantity.Name = "cQuantity";
            this.cQuantity.Width = 48;
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            this.cDescription.Width = 85;
            // 
            // cCostPrice
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.cCostPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.cCostPrice.HeaderText = "Cost Price";
            this.cCostPrice.Name = "cCostPrice";
            this.cCostPrice.Width = 80;
            // 
            // cSellPrice
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.cSellPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.cSellPrice.HeaderText = "Selling Price";
            this.cSellPrice.Name = "cSellPrice";
            this.cSellPrice.Width = 90;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(466, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Location = new System.Drawing.Point(172, 429);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 432);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ViewStockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.rdInStockOnly);
            this.Controls.Add(this.rdAllStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewStockScreen";
            this.Size = new System.Drawing.Size(601, 459);
            this.Load += new System.EventHandler(this.ViewStockScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdAllStock;
        private System.Windows.Forms.RadioButton rdInStockOnly;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellPrice;
    }
}
