using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_Skeleton
{
    public partial class NewPaymentScreen : UserControl
    {
        public NewPaymentScreen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewPaymentScreen_Resize(object sender, EventArgs e)
        {
            btnSave.Left = (this.Width - btnSave.Width) / 2;
        }
    }
}
