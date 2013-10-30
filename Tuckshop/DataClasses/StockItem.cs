using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuckshop
{
    class StockItem : DataObject
    {
        public int ItemNum
        {
            get { return base.GetAttr<int>(primaryKey); }
        }
        public string Description
        {
            get { return base.GetAttr<string>("Description"); }
            set { base.SetAttr("Description", value); }
        }
        public int QtyInStock
        {
            get { return base.GetAttr<int>("QtyInStock"); }
            set { base.SetAttr("QtyInStock", value); }
        }
        public decimal CostPrice
        {
            get { return base.GetAttr<decimal>("CostPrice"); }
            set { base.SetAttr("CostPrice", value); }
        }
        public decimal SellPrice
        {
            get { return base.GetAttr<decimal>("SellPrice"); }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                else base.SetAttr("SellPrice", value);
            }
        }
        public static StockItem operator +(StockItem s,int num)
        {
            s.QtyInStock += num;
            return s;
        }
        public static StockItem operator -(StockItem s, int num)
        {
            return s + (-num);
        }
        public static StockItem operator <<(StockItem s, int num)
        {
            return s + num;
        }
        public static StockItem operator >>(StockItem s, int num)
        {
            return s - num;
        }

        public object[] Select(params string[] fieldNames)
        {
            object[] output=new object[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (fieldNames[i].ToLower())
                {
                    case "itemnum": output[i] = this.ItemNum; break;
                    case "description": output[i] = this.Description; break;
                    case "qtyinstock": output[i] = this.QtyInStock; break;
                    case "costprice": output[i] = this.CostPrice; break;
                    case "sellprice": output[i] = this.SellPrice; break;
                }
            }
            return output;
        }
        /// <summary>
        /// Instantiates a stockItem by ItemNum
        /// </summary>
        /// <param name="ItemNum"></param>
        public StockItem(int? ItemNum = null)
            : base("StockItem", "ItemNum", ItemNum) { }

        public static List<StockItem> All()
        {
            List<int> keys = DataObject.All("StockItem", "ItemNum");
            List<StockItem> output=new List<StockItem>();
            foreach (int key in keys)
                output.Add(new StockItem(key));
            return output;
        }
        /// <summary>
        /// Filters stock items based on a criteria
        /// </summary>
        /// <param name="filter">A function/lambda/delegate that returns true for elements that you want</param>
        /// <returns>A list of stock items</returns>
        public static List<StockItem> All(Func<StockItem, bool> filter)
        {
            List<StockItem> stock = All();
            for (int i = 0; i < stock.Count; i++)
            {
                if (!filter(stock[i]))
                    stock.RemoveAt(i--);
            }
            return stock;
        }

        /// <summary>
        /// Deletes this instance of StockItem from the database
        /// </summary>
        public override void Delete()
        {
            //TODO: handle foreign key constraints
            base.Delete();
        }

        public static StockItem New(int itemNum, string description, int qtyInStock, decimal costprice, decimal sellprice)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();

            if (sellprice < 0) throw new ArgumentOutOfRangeException();

            values["itemnum"] = itemNum;
            values["description"] = description;
            values["qtyinstock"] = qtyInStock;
            values["costprice"] = costprice;
            values["sellprice"] = sellprice;

            DataObject.Insert("StockItem", values);
            return new StockItem(itemNum);
        }

        public string ToString()
        {
            return ItemNum + ": " + Description + "(" + QtyInStock + ")";
        }
    }
}
