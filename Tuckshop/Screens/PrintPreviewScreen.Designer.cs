namespace Tuckshop
{
    partial class PrintPreviewScreen
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
            this.webPrintSales = new System.Windows.Forms.WebBrowser();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webPrintSales
            // 
            this.webPrintSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webPrintSales.Location = new System.Drawing.Point(3, 3);
            this.webPrintSales.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPrintSales.Name = "webPrintSales";
            this.webPrintSales.Size = new System.Drawing.Size(454, 362);
            this.webPrintSales.TabIndex = 0;
            this.webPrintSales.Url = new System.Uri("file://C:\\Users\\Douglas\\Desktop\\wri202\\UI-Skeleton\\SalesPrint.htm", System.UriKind.Absolute);
            this.webPrintSales.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Location = new System.Drawing.Point(197, 371);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PrintPreviewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.webPrintSales);
            this.Name = "PrintPreviewScreen";
            this.Size = new System.Drawing.Size(460, 407);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webPrintSales;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button btnPrint;
    }
}
