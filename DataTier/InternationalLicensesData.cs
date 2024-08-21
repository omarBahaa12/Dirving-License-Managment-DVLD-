using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsInternationalLicensesData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(int LocalLicenseID, string _LicenseClass, int applicationID, int dirverID,
                      DateTime issueDate, DateTime expireDate, bool isActive)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "INSERT INTO InternationalLicenses" +
                "(ApplicationID,LicenseClass,LocalLicenseID,DriverID,IssueDate,ExpireDate,IsActive)" +
                " VALUES(@ApplicationID,@Class,@LocalLicenseID,@DriverID,@IssueDate,@ExpireDate,@IsActive)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@LocalLicenseID",LocalLicenseID );
            command.Parameters.AddWithValue("@DriverID", dirverID);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpireDate", expireDate);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@Class", _LicenseClass);
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

        public static DataTable InternationalLicenseList(int driverID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select I_L_ID=InternationalLicenseID,ApplicationID,LicenseClass,IssueDate," +
                "ExpireDate,IsActive from InternationalLicenses Where DriverID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", driverID);
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

        public static DataTable InternationalLicenseList()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select I_L_ID=InternationalLicenseID,DriverID,LocalLicenseID,LicenseClass,IssueDate," +
                "ExpireDate,IsActive from InternationalLicenses";
            SqlCommand command = new SqlCommand(Query, connection);
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

        public static bool IsHasInternationalLicense(int l_LicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
            "(SELECT *FROM InternationalLicenses WHERE LocalLicenseID=@ID)" +
            "THEN CAST(1 AS BIT)" +
            "ELSE CAST(0 AS BIT) END";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_LicenseID);
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
    }
}
