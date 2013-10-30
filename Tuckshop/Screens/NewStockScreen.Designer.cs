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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgCapStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCapStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCapStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.itemnum.Width = 92;
            // 
            // cQuantity
            // 
            this.cQuantity.HeaderText = "Bought Quantity";
            this.cQuantity.Name = "cQuantity";
            this.cQuantity.Width = 108;
            // 
            // itemdesc
            // 
            this.itemdesc.HeaderText = "Item Description";
            this.itemdesc.Name = "itemdesc";
            this.itemdesc.Width = 108;
            // 
            // cCostPrice
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.cCostPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.cCostPrice.HeaderText = "Cost Price";
            this.cCostPrice.Name = "cCostPrice";
            this.cCostPrice.Width = 80;
            // 
            // cSellPrice
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.cSellPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.cSellPrice.HeaderText = "Sell Price";
            this.cSellPrice.Name = "cSellPrice";
            this.cSellPrice.Width = 76;
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
