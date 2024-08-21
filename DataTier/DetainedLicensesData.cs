using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsDetainedLicensesData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(int licenseID, DateTime detainedDate, int createdBy, double fees)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "INSERT INTO DetainedLicenses(LicenseID,DetainedDate,Fees,CreatedBy,IsReleased) " +
                "VALUES(@LicenseID,@DetainedDate,@Fees,@CreatedBy,@IsReleased)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@DetainedDate", detainedDate);
            command.Parameters.AddWithValue("@CreatedBy", createdBy);
            command.Parameters.AddWithValue("@Fees", fees);
            command.Parameters.AddWithValue("@IsReleased", false);
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

        public static int GetLicenseID(int detainedLicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select LicenseID from DetainedLicenses Where DetainedID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", detainedLicenseID);
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
        public static bool IsExist(int detainedLicenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query= "SELECT CASE WHEN EXISTS" +
            "(SELECT *FROM DetainedLicenses WHERE LicenseID=@ID and IsReleased=0)" +
            "THEN CAST(1 AS BIT)" +
            "ELSE CAST(0 AS BIT) END";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", detainedLicenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool Result))
                    return Result;
                return false;
            }
            finally { connection.Close();}
        }

        public static int GetDetainedID(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select DetainedID from DetainedLicenses Where LicenseID=@ID and IsReleased=0";
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

        public static double GetFineFees(int licenseID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select Fees from DetainedLicenses Where LicenseID=@ID and IsReleased=0";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && double.TryParse(value.ToString(), out double ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static bool Update(int detainedID, DateTime releasedDate, int releasedApplicationID)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "UPDATE DetainedLicenses SET IsReleased =@IsReleased,ReleasedDate =@ReleasedDate," +
                "ReleaseApplicationID=@ReleaseApplicationID WHERE DetainedID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", detainedID);
            command.Parameters.AddWithValue("@IsReleased", true);
            command.Parameters.AddWithValue("@ReleasedDate", releasedDate);
            command.Parameters.AddWithValue("@ReleaseApplicationID", releasedApplicationID);

            connection.Open();
            try
            {
                int value = command.ExecuteNonQuery();
                if (value != 0)
                    return true;
                return false;
            }
            finally { connection.Close(); }
        }

        public static DataTable ReleasedAndDetainedLlicenseList()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "Select DetainedID,L_ID=Licenses.LicenseID,FullName=FirstName+' '+SecondName+' '+ThirdName+' '+LastName,NationalNumber" +
                ",D_Date=DetainedDate,IsReleased,R_ApplicationID=ReleaseApplicationID,R_Date=ReleasedDate,Fees from " +
                "DetainedLicenses,Licenses,Drivers,Persons where DetainedLicenses.LicenseID=Licenses.LicenseID and " +
                "Licenses.DriverID=Drivers.DriverID and Drivers.PersonID=Persons.PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            DataTable dataTable=new DataTable();
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
    }
}
