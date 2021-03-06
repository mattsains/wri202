﻿using System;
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
            set
            {
                base.SetAttr("Balance", value);
                throw new InvalidOperationException("Only data objects should *EVER* call this!");
            }
        }

        public object[] Select(params string[] fieldNames)
        {
            object[] output=new object[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (fieldNames[i].ToLower())
                {
                    case "staffnum": output[i] = this.StaffNum; break;
                    case "firstname": output[i] = this.FirstName; break;
                    case "surname": output[i] = this.Surname; break;
                    case "email": output[i] = this.Email; break;
                    case "balance": output[i] = this.Balance; break;
                }
            }
            return output;
        }
        /// <summary>
        /// Instantiates a staff member by StaffNum
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
        /// <summary>
        /// Filters staff members based on a criteria
        /// </summary>
        /// <param name="filter">A function/lambda/delegate that returns true for elements that you want</param>
        /// <returns>A list of staff members</returns>
        public static List<Staff> All(Func<Staff, bool> filter)
        {
            List<Staff> staff = All();
            for (int i = 0; i < staff.Count; i++)
            {
                if (!filter(staff[i]))
                    staff.RemoveAt(i--);
            }
            return staff;
        }

        public override void Delete()
        {
            //delete everything referencing this staff member. Probably not the best idea but whatever.
            List<Payment> payments = Payment.All(payment => payment.staff.StaffNum == this.StaffNum);
            foreach (Payment p in payments)
                p.Delete();

            List<Purchase> purchases = Purchase.All(purchase => purchase.staff.StaffNum == this.StaffNum);
            foreach (Purchase p in purchases)
                p.Delete();

            base.Delete();
        }
        /// <summary>
        /// Inserts a new Staff Member
        /// </summary>
        /// <param name="values">A dictionary of the values of the new staff member</param>
        /// <returns>The staff num of the new record</returns>
        public static Staff New(int staffNum, string firstName, string lastName, string email, decimal balance = 0M)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();

            values["staffnr"] = staffNum;
            values["firstname"] = firstName;
            values["surname"] = lastName;
            values["email"] = email;
            values["balance"] = balance;

            DataObject.Insert("Staff", values);
            return new Staff(staffNum);
        }

        public string ToString()
        {
            return StaffNum + ": " + FirstName + " " + Surname;
        }
    }
}
