namespace UI_Skeleton
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // rdAllStock
            // 
            this.rdAllStock.AutoSize = true;
            this.rdAllStock.Location = new System.Drawing.Point(3, 3);
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
            this.rdInStockOnly.Location = new System.Drawing.Point(3, 26);
            this.rdInStockOnly.Name = "rdInStockOnly";
            this.rdInStockOnly.Size = new System.Drawing.Size(143, 17);
            this.rdInStockOnly.TabIndex = 1;
            this.rdInStockOnly.TabStop = true;
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
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cItemNum,
            this.cQuantity,
            this.cDescription,
            this.cCostPrice,
            this.cSellPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgItems.Location = new System.Drawing.Point(3, 49);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(595, 378);
            this.dgItems.TabIndex = 3;
            this.dgItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellDoubleClick);
            // 
            // cItemNum
            // 
            this.cItemNum.Frozen = true;
            this.cItemNum.HeaderText = "Num";
            this.cItemNum.Name = "cItemNum";
            this.cItemNum.ReadOnly = true;
            // 
            // cQuantity
            // 
            this.cQuantity.HeaderText = "Qty";
            this.cQuantity.Name = "cQuantity";
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            // 
            // cCostPrice
            // 
            this.cCostPrice.HeaderText = "Cost Price";
            this.cCostPrice.Name = "cCostPrice";
            // 
            // cSellPrice
            // 
            this.cSellPrice.HeaderText = "Selling Price";
            this.cSellPrice.Name = "cSellPrice";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(466, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Location = new System.Drawing.Point(3, 433);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // ViewStockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
    }
}
