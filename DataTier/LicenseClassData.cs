using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsLicenseClassData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static double GetFeesLicenseClass(int licenseClassID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select ClassFees from LicenseClass where LicenseClassID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseClassID);
            try
            {
                object Value = command.ExecuteScalar();
                if (Value!=null&&double.TryParse(Value.ToString(),out double fees))
                    return fees;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static short GetMinimumAge(int licenseClassID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "Select MinimumAllowedAge from LicenseClass Where LicenseClassID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseClassID);
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null && short.TryParse(Value.ToString(), out short MinAge))
                    return MinAge;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static int LicenseClassID(string licenseClassName)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select LicenseClassID from LicenseClass where ClassName=@Name";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", licenseClassName);
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null && int.TryParse(Value.ToString(), out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static DataTable LicenseClassListName()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            DataTable dataTable = new DataTable();
            string Query = "Select ClassName from LicenseClass";
            SqlCommand command=new SqlCommand(Query,connection);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
            finally { connection.Close(); }
        }

        public static string LicenseClassName(int licenseClassID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select ClassName from LicenseClass where LicenseClassID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseClassID);
            try
            {
                object Value = command.ExecuteScalar();
                if (!string.IsNullOrWhiteSpace(Value.ToString()))
                    return Value.ToString();
                return "";
            }
            finally { connection.Close(); }
        }

        public static short ValidityLength(int licenseClassID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select DefaultValidityLength from LicenseClass where LicenseClassID=@ID";
            SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@ID", licenseClassID);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && short.TryParse(value.ToString(), out short Length))
                    return Length;
                return 0;
            }
            finally { connection?.Close(); }
        }
    }
}
