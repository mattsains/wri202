namespace UI_Skeleton
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navMenu = new System.Windows.Forms.MenuStrip();
            this.stockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureSalesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSalesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.Panel();
            this.navMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.navMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockMenuItem,
            this.staffMenuItem,
            this.salesMenuItem});
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(736, 24);
            this.navMenu.TabIndex = 0;
            this.navMenu.Text = "navMenu";
            // 
            // stockMenuItem
            // 
            this.stockMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockViewMenuItem,
            this.newStockMenuItem});
            this.stockMenuItem.Name = "stockMenuItem";
            this.stockMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockMenuItem.Text = "Stock";
            // 
            // stockViewMenuItem
            // 
            this.stockViewMenuItem.Name = "stockViewMenuItem";
            this.stockViewMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stockViewMenuItem.Text = "&View/Edit Stock";
            this.stockViewMenuItem.Click += new System.EventHandler(this.stockViewMenuItem_Click);
            // 
            // newStockMenuItem
            // 
            this.newStockMenuItem.Name = "newStockMenuItem";
            this.newStockMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newStockMenuItem.Text = "Process &New Stock";
            this.newStockMenuItem.Click += new System.EventHandler(this.newStockMenuItem_Click);
            // 
            // staffMenuItem
            // 
            this.staffMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStaffMenuItem,
            this.accountsStaffMenuItem,
            this.paymentsStaffMenuItem});
            this.staffMenuItem.Name = "staffMenuItem";
            this.staffMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffMenuItem.Text = "Staff";
            // 
            // viewStaffMenuItem
            // 
            this.viewStaffMenuItem.Name = "viewStaffMenuItem";
            this.viewStaffMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewStaffMenuItem.Text = "&View/Edit Staff";
            this.viewStaffMenuItem.Click += new System.EventHandler(this.viewStaffMenuItem_Click);
            // 
            // accountsStaffMenuItem
            // 
            this.accountsStaffMenuItem.Name = "accountsStaffMenuItem";
            this.accountsStaffMenuItem.Size = new System.Drawing.Size(169, 22);
            this.accountsStaffMenuItem.Text = "View &Accounts";
            this.accountsStaffMenuItem.Click += new System.EventHandler(this.accountsStaffMenuItem_Click);
            // 
            // paymentsStaffMenuItem
            // 
            this.paymentsStaffMenuItem.Name = "paymentsStaffMenuItem";
            this.paymentsStaffMenuItem.Size = new System.Drawing.Size(169, 22);
            this.paymentsStaffMenuItem.Text = "Process &Payments";
            this.paymentsStaffMenuItem.Click += new System.EventHandler(this.paymentsStaffMenuItem_Click);
            // 
            // salesMenuItem
            // 
            this.salesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureSalesMenuItem,
            this.printSalesMenuItem});
            this.salesMenuItem.Name = "salesMenuItem";
            this.salesMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesMenuItem.Text = "Sales";
            // 
            // captureSalesMenuItem
            // 
            this.captureSalesMenuItem.Name = "captureSalesMenuItem";
            this.captureSalesMenuItem.Size = new System.Drawing.Size(160, 22);
            this.captureSalesMenuItem.Text = "Capture &Sales";
            this.captureSalesMenuItem.Click += new System.EventHandler(this.captureSalesMenuItem_Click);
            // 
            // printSalesMenuItem
            // 
            this.printSalesMenuItem.Name = "printSalesMenuItem";
            this.printSalesMenuItem.Size = new System.Drawing.Size(160, 22);
            this.printSalesMenuItem.Text = "&Print Sales Sheet";
            this.printSalesMenuItem.Click += new System.EventHandler(this.printSalesMenuItem_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlHeader.Location = new System.Drawing.Point(-14, 24);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(763, 28);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(763, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.Location = new System.Drawing.Point(0, 49);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(736, 503);
            this.contentBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 552);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.navMenu);
            this.MainMenuStrip = this.navMenu;
            this.Name = "MainForm";
            this.Text = "Tuckshop Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navMenu;
        private System.Windows.Forms.ToolStripMenuItem stockMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStockMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureSalesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSalesMenuItem;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel contentBox;
    }
}

