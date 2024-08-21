using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataTier
{
    public static class clsLicensesData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";
        public static int Add(int l_L_ApplicationID, int driverID, DateTime issueDate,
            DateTime expireDate, string notes, string issueReason, bool isActive, string _LicenseName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClassName,IssueReason,Notes,IssueDate,ExpireDate,IsActive) " +
                "VALUES (@ApplicationID,@DriverID,@LicenseClass,@IssueReason,@Notes,@IssueDate,@ExpireDate ,@IsActive)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", l_L_ApplicationID);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@IssueReason", issueReason);
            command.Parameters.AddWithValue("@Notes", notes);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpireDate", expireDate);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@LicenseClass", _LicenseName);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static void Find(int licenseID, ref int applicationID, ref int driverID, ref DateTime issueDate,
           ref DateTime expireDate, ref string issueReason, ref string licenseName, ref string notes, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select * from licenses where LicenseID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expireDate = (DateTime)reader["ExpireDate"];
                    issueReason = (string)reader["IssueReason"];
                    licenseName = (string)reader["LicenseClassName"];
                    notes = (string)reader["Notes"];
                    isActive = (bool)reader["IsActive"];
                }
                reader.Close();
            }
            finally { connection.Close(); }
        }
        public static int GetLicenseID(int applicationID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select LicenseID from Licenses where ApplicationID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", applicationID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int ID))
                    return ID;
                return 0;

            }
            finally { connection.Close(); }
        }
        public static bool IsExist(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Licenses WHERE LicenseID =@ID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool Result))
                    return Result;
                return false;
            }
            finally { connection.Close(); }
        }
        public static bool IsActive(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Licenses WHERE LicenseID =@ID and IsActive=1)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool Result))
                    return Result;
                return false;
            }
            finally { connection.Close(); }
        }
        public static DateTime GetExpireDate(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select ExpireDate from Licenses Where LicenseID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && DateTime.TryParse(value.ToString(), out DateTime Result))
                    return Result;
                return DateTime.Now;
            }
            finally { connection.Close(); }
        }
        public static DataTable LicenseList(int DriverID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select L_ID=LicenseID,ApplicationID,ClassName=LicenseClassName,IssueDate," +
                "ExpireDate,IsActive from Licenses Where DriverID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", DriverID);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                if (reader.HasRows)
                    dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
            finally { connection.Close(); }
        }
        public static int GetDriverID(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select DriverID from Licenses where LicenseID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int ID))
                    return ID;
                return 0;

            }
            finally { connection.Close(); }
        }
        public static string LicenseClassName(int l_LicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select LicenseClassName from Licenses where LicenseID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_LicenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null)
                    return value.ToString();
                return "";

            }
            finally { connection.Close(); }
        }
        public static void DeActivtedLicense(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "UPDATE Licenses SET IsActive=0 where LicenseID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                int value = command.ExecuteNonQuery();

            }
            finally { connection.Close(); }

        } 
    } 
}

