namespace Tuckshop
{
    partial class NewStockScreen
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
            this.btnCapStock = new System.Windows.Forms.Button();
            this.dgCapStock = new System.Windows.Forms.DataGridView();
            this.itemnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCapStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapStock
            // 
            this.btnCapStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapStock.Location = new System.Drawing.Point(273, 450);
            this.btnCapStock.Name = "btnCapStock";
            this.btnCapStock.Size = new System.Drawing.Size(75, 23);
            this.btnCapStock.TabIndex = 3;
            this.btnCapStock.Text = "Capture";
            this.btnCapStock.UseVisualStyleBackColor = true;
            this.btnCapStock.Click += new System.EventHandler(this.btnCapStock_Click);
            // 
            // dgCapStock
            // 
            this.dgCapStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCapStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.dgCapStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCapStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemnum,
            this.cQuantity,
            this.itemdesc,
            this.cCostPrice,
            this.cSellPrice});
            this.dgCapStock.Location = new System.Drawing.Point(3, 3);
            this.dgCapStock.Name = "dgCapStock";
            this.dgCapStock.Size = new System.Drawing.Size(630, 441);
            this.dgCapStock.TabIndex = 2;
            this.dgCapStock.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCapStock_CellEnter);
            this.dgCapStock.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCapStock_CellLeave);
            // 
            // itemnum
            // 
            this.itemnum.HeaderText = "Item Number";
            this.itemnum.Name = "itemnum";
            // 
            // cQuantity
            // 
            this.cQuantity.HeaderText = "Bought Quantity";
            this.cQuantity.Name = "cQuantity";
            // 
            // itemdesc
            // 
            this.itemdesc.HeaderText = "Item Description";
            this.itemdesc.Name = "itemdesc";
            // 
            // cCostPrice
            // 
            this.cCostPrice.HeaderText = "Cost Price";
            this.cCostPrice.Name = "cCostPrice";
            // 
            // cSellPrice
            // 
            this.cSellPrice.HeaderText = "Sell Price";
            this.cSellPrice.Name = "cSellPrice";
            // 
            // NewStockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapStock);
            this.Controls.Add(this.dgCapStock);
            this.Name = "NewStockScreen";
            this.Size = new System.Drawing.Size(636, 479);
            this.Load += new System.EventHandler(this.NewStockScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCapStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapStock;
        private System.Windows.Forms.DataGridView dgCapStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellPrice;
    }
}
