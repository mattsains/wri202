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
            //TODO: handle foreign key constraints
            base.Delete();
        }
        /// <summary>
        /// Inserts a new Staff Member
        /// </summary>
        /// <param name="values">A dictionary of the values of the new staff member</param>
        /// <returns>The primary key of the new record</returns>
        /// <exception cref="WARNING: Return value is only valid for auto-incrementing primary keys."></exception>
        /// <exception cref="IT WILL RETURN 0 IF YOU SET THE PRIMARY KEY YOURSELF"></exception>
        public static int Insert(int staffNum,string firstName, string lastName, string email, decimal balance=0M)
        {
            Dictionary<string,object> values=new Dictionary<string,object>();

            values["staffnum"]=staffNum;
            values["firstname"]=firstName;
            values["lastname"]=lastName;
            values["email"]=email.ToCharArray();//for some reason email is stored as a WCHAR[] type in Access, which cannot be marshalled as string
            values["balance"] = balance;

            DataObject.Insert("Staff", values);
            return staffNum;
        }
    }
}