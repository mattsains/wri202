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
            this.contentBox = new System.Windows.Forms.GroupBox();
            this.navMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
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
            this.stockMenuItem.Size = new System.Drawing.Size(45, 20);
            this.stockMenuItem.Text = "Stock";
            // 
            // stockViewMenuItem
            // 
            this.stockViewMenuItem.Name = "stockViewMenuItem";
            this.stockViewMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stockViewMenuItem.Text = "&View/Edit Stock";
            this.stockViewMenuItem.Click += new System.EventHandler(this.stockViewMenuItem_Click);
            // 
            // newStockMenuItem
            // 
            this.newStockMenuItem.Name = "newStockMenuItem";
            this.newStockMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newStockMenuItem.Text = "Process &New Stock";
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
            this.viewStaffMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewStaffMenuItem.Text = "&View/Edit Staff";
            this.viewStaffMenuItem.Click += new System.EventHandler(this.viewStaffMenuItem_Click);
            // 
            // accountsStaffMenuItem
            // 
            this.accountsStaffMenuItem.Name = "accountsStaffMenuItem";
            this.accountsStaffMenuItem.Size = new System.Drawing.Size(172, 22);
            this.accountsStaffMenuItem.Text = "View &Accounts";
            // 
            // paymentsStaffMenuItem
            // 
            this.paymentsStaffMenuItem.Name = "paymentsStaffMenuItem";
            this.paymentsStaffMenuItem.Size = new System.Drawing.Size(172, 22);
            this.paymentsStaffMenuItem.Text = "Process &Payments";
            // 
            // salesMenuItem
            // 
            this.salesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureSalesMenuItem,
            this.printSalesMenuItem});
            this.salesMenuItem.Name = "salesMenuItem";
            this.salesMenuItem.Size = new System.Drawing.Size(44, 20);
            this.salesMenuItem.Text = "Sales";
            // 
            // captureSalesMenuItem
            // 
            this.captureSalesMenuItem.Name = "captureSalesMenuItem";
            this.captureSalesMenuItem.Size = new System.Drawing.Size(166, 22);
            this.captureSalesMenuItem.Text = "Capture &Sales";
            // 
            // printSalesMenuItem
            // 
            this.printSalesMenuItem.Name = "printSalesMenuItem";
            this.printSalesMenuItem.Size = new System.Drawing.Size(166, 22);
            this.printSalesMenuItem.Text = "&Print Sales Sheet";
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.Location = new System.Drawing.Point(12, 27);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(712, 524);
            this.contentBox.TabIndex = 1;
            this.contentBox.TabStop = false;
            this.contentBox.Text = "Tuckshop Management System";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 563);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.navMenu);
            this.MainMenuStrip = this.navMenu;
            this.Name = "MainForm";
            this.Text = "Tuckshop Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
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
        private System.Windows.Forms.GroupBox contentBox;
    }
}

