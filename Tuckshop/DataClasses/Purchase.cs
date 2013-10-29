using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuckshop.DataClasses
{
    class Purchase : DataObject
    {        
        public int purchaseNum
        {
            get { return base.GetAttr<int>("PurchNum"); }
        }
        public DateTime date
        {
            get { return base.GetAttr<DateTime>("PurchDate"); }
            set { base.SetAttr("PurchDate", value); }
        }
        /// <summary>
        /// This total will be automatically maintained by the dataobjects themselves.
        /// Do not set this property unless you know precisely what you're doing.
        /// Setting this property will cause an InvalidOperationException.
        /// </summary>
        public decimal total
        {
            get { return base.GetAttr<decimal>("PurchTotal"); }
            set
            {
                base.SetAttr("PurchTotal", value);
                if (staff != null)
                    staff.Balance -= (value - total);//TODO: verify
                throw new InvalidOperationException("Only data objects should *EVER* call this!");
            }
        }
        public Staff staff
        {
            get { return new Staff(base.GetAttr<int>("StaffNr")); }
            set
            {
                if (staff != null)
                    staff.Balance += total; //TODO: verify
                base.SetAttr("StaffNr", value.StaffNum);
                value.Balance -= total; //TODO: verify
            }
        }
        //an internal cache of items in this purchase
        protected List<PurchaseItem> _items = new List<PurchaseItem>();

        public object[] Select(params string[] fieldNames)
        {
            object[] output = new object[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (fieldNames[i])
                {
                    case "purchasenum": output[i] = this.purchaseNum; break;
                    case "date": output[i] = this.date; break;
                    case "total": output[i] = this.total; break;
                    case "staff": output[i] = this.staff; break;
                    default: //wants some information about the staff member, delegate to Staff.Select()
                        if (fieldNames[i].StartsWith("staff."))
                            output[i] = staff.Select(fieldNames[i].Substring(fieldNames[i].IndexOf('.') + 1));
                        break;
                }
            }
            return output;
        }

        /// <summary>
        /// Instantiates a purchase by purchasenum
        /// </summary>
        public Purchase(int? purchaseNum = null)
            : base("Purchase", "PurchNum", purchaseNum)
        {
            if (purchaseNum != null)
            {
                _items = PurchaseItem.All(purchItem => purchItem.purchase.purchaseNum == purchaseNum);
            }
        }

        public static List<Purchase> All()
        {
            List<int> keys = DataObject.All("Purchase", "PurchNum");
            List<Purchase> output=new List<Purchase>();
            foreach (int key in keys)
                output.Add(new Purchase(key));
            return output;
        }

        /// <summary>
        /// Filters purchases based on a criteria
        /// </summary>
        /// <param name="filter">A function/lambda/delegate that returns true for elements that you want</param>
        /// <returns>A list of purchases</returns>
        public static List<Purchase> All(Func<Purchase, bool> filter)
        {
            List<Purchase> purchases = All();
            for (int i = 0; i < purchases.Count; i++)
            {
                if (!filter(purchases[i]))
                    purchases.RemoveAt(i--);
            }
            return purchases;
        }

        /// <summary>
        /// Deletes this instance of Purchase from the database
        /// </summary>
        public override void Delete()
        {
            if (staff != null)
                staff.Balance += total;
            //delete all items in this purchase
            foreach (PurchaseItem p in _items)
                p.Delete();

            base.Delete();
        }

        public static Purchase New(DateTime date, Staff staff)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["PurchDate"] = date;
            values["StaffNr"] = staff.StaffNum;

            return new Purchase(DataObject.Insert("Purchase", values));
        }

        public override string ToString()
        {
            return "Purchase on " + date + " by " + staff.FirstName + " (" + total + ")";
        }
    }
}
