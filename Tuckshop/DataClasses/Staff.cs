using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuckshop
{
    class Staff : DataObject
    {
        public int StaffNum
        {
            get { return base.GetAttr<int>(primaryKey); }
        }
        public string FirstName
        {
            get { return base.GetAttr<string>("FirstName"); }
            set { base.SetAttr("FirstName", value); }
        }
        public string Surname
        {
            get { return base.GetAttr<string>("Surname"); }
            set { base.SetAttr("Surname", value); }
        }
        public string Email
        {
            get { return base.GetAttr<string>("Email"); }
            set { base.SetAttr("Email", value); }
        }
        public decimal Balance
        {
            //I hate this because it should be calulated, but whatevs
            get { return base.GetAttr<decimal>("Balance"); }
            set { base.SetAttr("Balance", value); }
        }

        public object[] Select(params string[] fieldNames)
        {
            object[] output=new object[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (fieldNames[i])
                {
                    case "StaffNum": output[i] = this.StaffNum; break;
                    case "FirstName": output[i] = this.FirstName; break;
                    case "Surname": output[i] = this.Surname; break;
                    case "Email": output[i] = this.Email; break;
                    case "Balance": output[i] = this.Balance; break;
                }
            }
            return output;
        }
        /// <summary>
        /// Instantiates a 
        /// </summary>
        /// <param name="StaffNum"></param>
        public Staff(int? StaffNum = null)
            : base("Staff", "StaffNr", StaffNum) { }

        public static List<Staff> All()
        {
            List<int> keys = DataObject.All("Staff", "StaffNr");
            List<Staff> output=new List<Staff>();
            foreach (int key in keys)
                output.Add(new Staff(key));
            return output;
        }
    }
}
