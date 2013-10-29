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
    public partial class PrintPreviewScreen : UserControl
    {
        public PrintPreviewScreen(string url)
        {
            InitializeComponent();
            webPrintSales.Navigate(url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
