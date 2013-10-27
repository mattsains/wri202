using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuckshop.DataClasses
{
    class PurchaseItem : DataObject
    {
        public int purchaseItemID
        {
            get { return base.GetAttr<int>("PurchItemID"); }
        }
        public Purchase purchase
        {
            get { return new Purchase(base.GetAttr<int>("PurchNum")); }
            set
            {
                if (purchase != null)
                    purchase.total -= QtyBought * item.SellPrice;
                base.SetAttr("PurchNum", value.purchaseNum);
                value.total += QtyBought * item.SellPrice;
            }
        }
        public int QtyBought
        {
            get{return base.GetAttr<int>("QtyBought");}
            set
            {
                try
                {
                    if (purchase != null)
                        purchase.total += (value - QtyBought) * item.SellPrice;
                }
                catch (InvalidOperationException) { /*silencing a warning exception */ }
            }
        }
        public StockItem item
        {
            get{return new StockItem(base.GetAttr<int>("ItemNum"));}
            set
            {
                try
                {
                    if (purchase != null)
                        purchase.total += QtyBought * (value.SellPrice - item.SellPrice);
                }
                catch (InvalidOperationException) { /*silencing a warning exception */ }
            }
        }

        public object[] Select(params string[] fieldNames)
        {
            object[] output = new object[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (fieldNames[i])
                {
                    case "qtybought": output[i] = this.QtyBought; break;
                    case "purchase": output[i] = this.purchase; break;
                    case "item": output[i] = this.item; break;
                    default: //wants some information about the something, delegate to Something.Select()
                        if (fieldNames[i].StartsWith("purchase."))
                            output[i] = purchase.Select(fieldNames[i].Substring(fieldNames[i].IndexOf('.') + 1));
                        else if (fieldNames[i].StartsWith("item."))
                            output[i] = item.Select(fieldNames[i].Substring(fieldNames[i].IndexOf('.') + 1));
                        break;
                }
            }
            return output;
        }

        /// <summary>
        /// Instantiates a purchaseItem by PurchaseItemID
        /// </summary>
        public PurchaseItem(int? purchaseItemID = null)
            : base("PurchItem", "PurchItemID", purchaseItemID) { }

        public static List<PurchaseItem> All()
        {
            List<int> keys = DataObject.All("PurchItem", "PurchItemID");
            List<PurchaseItem> output = new List<PurchaseItem>();
            foreach (int key in keys)
                output.Add(new PurchaseItem(key));
            return output;
        }

        /// <summary>
        /// Filters purchase items based on a criteria
        /// </summary>
        /// <param name="filter">A function/lambda/delegate that returns true for elements that you want</param>
        /// <returns>A list of purchase items</returns>
        public static List<PurchaseItem> All(Func<PurchaseItem, bool> filter)
        {
            List<PurchaseItem> purchaseitems = All();
            for (int i = 0; i < purchaseitems.Count; i++)
            {
                if (!filter(purchaseitems[i]))
                    purchaseitems.RemoveAt(i--);
            }
            return purchaseitems;
        }

        /// <summary>
        /// Deletes this purchaseItem from the database
        /// </summary>
        public override void Delete()
        {
            try
            {
                if (purchase != null)
                    purchase.total -= item.SellPrice * QtyBought;
            }
            catch (InvalidOperationException) { /*silence warning exception*/ }
            base.Delete();
        }

        public static int Insert(Purchase purchase, StockItem item, int qtyBought)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();

            values["PurchNum"] = purchase.purchaseNum;
            values["QtyBought"] = qtyBought;
            values["ItemNum"] = item.ItemNum;

            return DataObject.Insert("PurchItem", values);
        }

        public override string ToString()
        {
            return QtyBought + "x " + item.Description;
        }
    }
}
