using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Tuckshop
{
    static class DataProvider
    {
        public static SqlConnection _connection;
        public static SqlConnection connection
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
        protected string primaryKeyName;
        protected string primaryKeyValue;

        protected DataObject(string tableName, string primaryKeyName,string primaryKeyValue=null)
        {
            using (SqlCommand columncheck = new SqlCommand("SELECT count(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE Table_Name=@table AND Column_Name=@keyname"))
            {
                columncheck.Parameters.Add(new SqlParameter("table",tableName));
                columncheck.Parameters.Add(new SqlParameter("keyname",primaryKeyName));
                SqlDataReader reader = columncheck.ExecuteReader();
                reader.Read();
                if ((int)reader[0] == 0)
                    throw new ArgumentException(string.Format("The table-key combination {0}-{1} does not exist", tableName, primaryKeyName));
                else
                {
                    this.tableName = tableName;
                    this.primaryKeyName = primaryKeyName;
                    if (primaryKeyValue!=null)
                    {
                        using (SqlCommand keycheck=new SqlCommand("SELECT count(*) FROM @table WHERE @keyname=@keyvalue"))
                        {
                            keycheck.Parameters.Add(new SqlParameter("table",tableName));
                            keycheck.Parameters.Add(new SqlParameter("keyname",primaryKeyName));
                            keycheck.Parameters.Add(new SqlParameter("keyvalue",primaryKeyValue));
                            reader=keycheck.ExecuteReader();
                            if ((int)reader[0]!=1)
                                throw new ArgumentException("Primary key set to an invalid value");
                            else
                                this.primaryKeyValue=primaryKeyValue;
                        }
                    }
                }
            }
        }
        protected T GetAttr<T>(string fieldName)
        {
            using (SqlCommand lookup = new SqlCommand("SELECT @fieldname FROM @tablename WHERE @keyname=@keyvalue"))
            {
                lookup.Parameters.Add(new SqlParameter("fieldname", fieldName));
                lookup.Parameters.Add(new SqlParameter("tablename", tableName));
                lookup.Parameters.Add(new SqlParameter("keyname", primaryKeyName));
                lookup.Parameters.Add(new SqlParameter("keyvalue", primaryKeyValue));

                SqlDataReader reader = lookup.ExecuteReader();
                return (T)(reader[0]);
            }
        }
        protected object[] GetAttr(params string[] fieldNames)
        {
            string fields = "";
            for (int i = 0; i < fieldNames.Length; i++)
            {
                fields += string.Format("@field{0}, ", i);
            }
            fields=fields.Substring(0,fields.LastIndexOf(','));
            using (SqlCommand lookup = new SqlCommand("SELECT " + fields + " FROM @tablename WHRE @keyname=@keyvalue"))
            {
                for (int i = 0; i < fieldNames.Length; i++)
                {
                    lookup.Parameters.Add(new SqlParameter("field" + i, fieldNames));
                }
                SqlDataReader reader = lookup.ExecuteReader();
                object[] output = new object[fieldNames.Length];
                reader.GetValues(output);
                return output;
            }
        }
        protected void SetAttr(string fieldName, object value)
        {
            using (SqlCommand update = new SqlCommand("UPDATE @tablename SET @fieldname=@value WHERE @keyname=@keyvalue"))
            {
                update.Parameters.Add(new SqlParameter("tablename", tableName));
                update.Parameters.Add(new SqlParameter("fieldname", fieldName));
                update.Parameters.Add(new SqlParameter("value", value));
                update.Parameters.Add(new SqlParameter("keyname", primaryKeyName));
                update.Parameters.Add(new SqlParameter("keyvalue", primaryKeyValue));

                update.ExecuteNonQuery();
            }
        }
    }
    class DataObjects<T> : IEnumerable<T>
    {
        protected SqlDataReader dataReader;
        private string TableName;

        protected DataObjects(string tableName)
        {
            this.TableName = tableName;
        }

    }
}
