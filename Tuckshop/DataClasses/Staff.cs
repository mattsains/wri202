using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuckshop.DataClasses
{
    class Staff : DataObject
    {
        public int StaffNum
        {
            get { return base.GetAttr<int>("staffNum"); }
        }

        public Staff(int? StaffNum = null)
            : base("Staff", "StaffNum", StaffNum.HasValue ? StaffNum.Value.ToString() : null)
        {

        }
    }
}
