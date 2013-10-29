using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuckshop
{
    class Payment : DataObject
    {
        public int paymentNum
        {
            get { return base.GetAttr<int>("paymentnum"); }
        }
        public DateTime date
        {
            get { return base.GetAttr<DateTime>("paymentdate"); }
            set { base.SetAttr("paymentdate", value); }
        }
        public decimal amountPaid
        {
            get { return base.GetAttr<decimal>("amountpaid"); }
            set
            {
                if (this.staff != null)
                {
                    try
                    {
                        staff.Balance -= (value - amountPaid);
                    }
                    catch (InvalidOperationException) { /*silence warning exception*/ }
                }
                base.SetAttr("amountpaid", value);
            }
        }
        public Staff staff
        {
            get { return new Staff(base.GetAttr<int>("staffnr")); }
            set {
                if (this.staff != null)
                {
                    try
                    {
                        staff.Balance += amountPaid;
                    }
                    catch (InvalidOperationException) { /*silence warning exception*/ }
                }
                base.SetAttr("staffnr", value.StaffNum);
                try
                {
                    value.Balance -= amountPaid;
                }
                catch (InvalidOperationException) { /*silence warning exception*/ }
            }
        }

        public object[] Select(params string[] fieldNames)
        {
            object[] output = new object[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (fieldNames[i])
                {
                    case "paymentnum": output[i] = this.paymentNum; break;
                    case "date": output[i] = this.date; break;
                    case "amountpayed": output[i] = this.amountPaid; break;
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
        /// Instantiates a payment by paymentNum
        /// </summary>
        public Payment(int? paymentNum = null)
            : base("Payment", "PaymentNum", paymentNum) { }

        public static List<Payment> All()
        {
            List<int> keys = DataObject.All("Payment", "PaymentNum");
            List<Payment> output=new List<Payment>();
            foreach (int key in keys)
                output.Add(new Payment(key));
            return output;
        }

        /// <summary>
        /// Filters payments based on a criteria
        /// </summary>
        /// <param name="filter">A function/lambda/delegate that returns true for elements that you want</param>
        /// <returns>A list of payments</returns>
        public static List<Payment> All(Func<Payment, bool> filter)
        {
            List<Payment> payments = All();
            for (int i = 0; i < payments.Count; i++)
            {
                if (!filter(payments[i]))
                    payments.RemoveAt(i--);
            }
            return payments;
        }

        /// <summary>
        /// Deletes this payment from the database
        /// </summary>
        public override void Delete()
        {
            try
            {
                staff.Balance += amountPaid;
            }
            catch (InvalidOperationException) { /*silencing warning exception*/ }

            base.Delete();
        }

        public static Payment New(DateTime date, decimal amountPaid, Staff staff)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();

            values["paymentdate"] = date;
            values["amountpaid"] = amountPaid;
            values["staffnr"] = staff.StaffNum;

            Payment output = new Payment(DataObject.Insert("Payment", values));
            try
            {
                staff.Balance -= amountPaid;
            }
            catch (InvalidOperationException) { /*silence warning exception*/ }

            return output;
        }

        public override string ToString()
        {
            return amountPaid + " paid by " + staff.FirstName;
        }
    }
}
