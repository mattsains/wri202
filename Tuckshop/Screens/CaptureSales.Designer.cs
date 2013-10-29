namespace Tuckshop
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
            this.btnCapSales = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.staffnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgCapSales.Location = new System.Drawing.Point(3, 29);
            this.dgCapSales.Name = "dgCapSales";
            this.dgCapSales.Size = new System.Drawing.Size(630, 441);
            this.dgCapSales.TabIndex = 0;
            this.dgCapSales.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCapSales_CellEnter);
            this.dgCapSales.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCapSales_CellLeave);
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
            this.btnCapSales.Click += new System.EventHandler(this.btnCapSales_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(42, 3);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
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
            this.itemdesc.ReadOnly = true;
            // 
            // CaptureSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnCapSales);
            this.Controls.Add(this.dgCapSales);
            this.Name = "CaptureSales";
            this.Size = new System.Drawing.Size(636, 518);
            ((System.ComponentModel.ISupportInitialize)(this.dgCapSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCapSales;
        private System.Windows.Forms.Button btnCapSales;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdesc;
    }
}
