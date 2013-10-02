namespace UI_Skeleton
{
    partial class CaptureSales
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
            this.dgCapSales = new System.Windows.Forms.DataGridView();
            this.staffnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCapSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCapSales
            // 
            this.dgCapSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCapSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.dgCapSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCapSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffnum,
            this.itemnum,
            this.qty,
            this.itemdesc});
            this.dgCapSales.Location = new System.Drawing.Point(3, 23);
            this.dgCapSales.Name = "dgCapSales";
            this.dgCapSales.Size = new System.Drawing.Size(630, 447);
            this.dgCapSales.TabIndex = 0;
            this.dgCapSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // staffnum
            // 
            this.staffnum.HeaderText = "Staff Number";
            this.staffnum.Name = "staffnum";
            // 
            // itemnum
            // 
            this.itemnum.HeaderText = "Item Number";
            this.itemnum.Name = "itemnum";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // itemdesc
            // 
            this.itemdesc.HeaderText = "Item Description";
            this.itemdesc.Name = "itemdesc";
            // 
            // btnCapSales
            // 
            this.btnCapSales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapSales.Location = new System.Drawing.Point(273, 476);
            this.btnCapSales.Name = "btnCapSales";
            this.btnCapSales.Size = new System.Drawing.Size(75, 23);
            this.btnCapSales.TabIndex = 1;
            this.btnCapSales.Text = "Capture";
            this.btnCapSales.UseVisualStyleBackColor = true;
            // 
            // CaptureSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapSales);
            this.Controls.Add(this.dgCapSales);
            this.Name = "CaptureSales";
            this.Size = new System.Drawing.Size(636, 518);
            ((System.ComponentModel.ISupportInitialize)(this.dgCapSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCapSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdesc;
        private System.Windows.Forms.Button btnCapSales;
    }
}
