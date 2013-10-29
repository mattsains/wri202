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
    public partial class NewPaymentScreen : UserControl
    {
        public NewPaymentScreen()
        {
            InitializeComponent();
        }

        private void NewPaymentScreen_Resize(object sender, EventArgs e)
        {
            btnProcess.Left = (this.Width - btnProcess.Width) / 2;
            panel1.Width = calDate.Width + 18; //seems to break the page
            panel1.Left = (this.Width - panel1.Width) / 2;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
        }

    }
}
