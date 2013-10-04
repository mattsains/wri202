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
    public partial class NewStockScreen : UserControl
    {
        public NewStockScreen()
        {
            InitializeComponent();

            btnCapStock.Left = (this.Width - btnCapStock.Width) / 2;
        }
    }
}
