using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Tuckshop
{
    static class DataProvider
    {
        private static OleDbConnection _connection;
        public static OleDbConnection Connection
        {
            set
            {
                _connection = value;
                _connection.Open();
            }
            get { return _connection; }
        }
    }
    class DataObject
    {
        protected string tableName;
        protected string primaryKey;
        protected int primaryKeyValue;

        protected DataObject(string tableName, string primaryKeyName, int? primaryKeyValue = null)
        {
            DataTable schema = DataProvider.Connection.GetSchema("COLUMNS");
            var rows = schema.Select("TABLE_NAME='" + tableName + "' AND COLUMN_NAME='" + primaryKeyName+"'");
            
            if (rows.Length==0)
                throw new ArgumentException(string.Format("The table-key combination {0}-{1} does not exist", tableName, primaryKeyName));
            else
            {
                this.tableName = tableName;
                this.primaryKey = primaryKeyName;

                if (primaryKeyValue != null)
                {
                    using (OleDbCommand keycheck = new OleDbCommand("SELECT count(*) FROM "+tableName+" WHERE "+primaryKeyName+"=@keyvalue", DataProvider.Connection))
                    {
                        keycheck.Parameters.Add(new OleDbParameter("@keyvalue", primaryKeyValue.Value));
                        int rowCount = (int)keycheck.ExecuteScalar();
                        if (rowCount != 1)
                            throw new ArgumentException("Primary key "+primaryKeyValue.Value+" does not exist");
                        else
                            this.primaryKeyValue = primaryKeyValue.Value;
                    }
                }
            }
        }
        /// <summary>
        /// This is different from all the other implementations of All() because it returns primary keys and not instances of DataObject.
        /// It is intended to be called from wrapper classes which will perform lookups based on these primary keys
        /// </summary>
        /// <returns></returns>
        protected static List<int> All(string tableName, string primaryKeyName)
        {
            List<int> output=new List<int>();
            using (OleDbCommand lookup = new OleDbCommand("SELECT " + primaryKeyName + " FROM " + tableName, DataProvider.Connection))
            {
                OleDbDataReader reader = lookup.ExecuteReader();
                while (reader.Read())
                {
                    output.Add((int)reader[primaryKeyName]);
                }
            }
            return output;
        }
        /// <summary>
        /// Returns the value of this row's fieldName field.
        /// </summary>
        /// <typeparam name="T">the type to explicitly convert the value to</typeparam>
        /// <param name="fieldName">Which field to get</param>
        /// <returns>The value of the field</returns>
        protected T GetAttr<T>(string fieldName)
        {
            using (OleDbCommand lookup = new OleDbCommand("SELECT "+fieldName+" FROM "+tableName+" WHERE "+primaryKey+"=@keyvalue",DataProvider.Connection))
            {
                lookup.Parameters.Add(new OleDbParameter("keyvalue", primaryKeyValue));

                return (T)lookup.ExecuteScalar();
            }
        }
        /// <summary>
        /// Returns the values of the fields specified
        /// </summary>
        /// <param name="fieldNames">The names of field names to return</param>
        /// <returns>An object array of values</returns>
        protected object[] GetAttr(params string[] fieldNames)
        {
            string fields = "";
            for (int i = 0; i < fieldNames.Length; i++) { fields += fieldNames[i] + ", "; }
            fields=fields.Substring(0,fields.LastIndexOf(','));

            using (OleDbCommand lookup = new OleDbCommand("SELECT " + fields + " FROM "+tableName+" WHERE "+primaryKey+"=@keyvalue",DataProvider.Connection))
            {
                lookup.Parameters.Add(new OleDbParameter("keyvalue",primaryKeyValue));

                for (int i = 0; i < fieldNames.Length; i++)
                {
                    lookup.Parameters.Add(new OleDbParameter("field" + i, fieldNames));
                }
                OleDbDataReader reader = lookup.ExecuteReader();
                object[] output = new object[fieldNames.Length];
                reader.GetValues(output);
                return output;
            }
        }
        /// <summary>
        /// Sets a field for the this row
        /// </summary>
        /// <param name="fieldName">The field to set</param>
        /// <param name="value">The value to set the field to</param>
        protected void SetAttr(string fieldName, object value)
        {
            using (OleDbCommand update = new OleDbCommand("UPDATE "+tableName+" SET "+fieldName+"=@value WHERE "+primaryKey+"=@keyvalue",DataProvider.Connection))
            {
                update.Parameters.Add(new OleDbParameter("value", value));
                update.Parameters.Add(new OleDbParameter("keyvalue", primaryKeyValue));

                update.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// This doesn't do anything to foreign key constraints
        /// </summary>
        /// <param name="?"></param>
        protected void Delete()
        {
            OleDbCommand delete = new OleDbCommand("DELETE FROM " + tableName + " WHERE "+primaryKey+"=@keyvalue", DataProvider.Connection);
            delete.Parameters.Add(new OleDbParameter("keyvalue", primaryKeyValue));
            delete.ExecuteNonQuery();
        }
    }
}
