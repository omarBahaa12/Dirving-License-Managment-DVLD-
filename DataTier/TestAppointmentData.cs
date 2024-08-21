using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsTestAppointmentData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(int l_LicenseApplicationID, int testTypeID
            , DateTime appointmentDate, bool islocked)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "INSERT INTO TestAppointments(LocalLicenseApplicationID,TestTypeID,AppointmentDate,IsLocked)" +
                " VALUES(@LocalLicenseApplicationID,@TestTypeID,@AppointmentDate,@IsLocked)"+
                                "select SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalLicenseApplicationID", l_LicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@IsLocked", islocked);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static bool Find(int testAppointmentID, ref int l_LApplicationID, ref int testTypeID,
            ref DateTime appointmentDate, ref bool islocked)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "select * from TestAppointments where TestAppointmentID=@ID";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", testAppointmentID);
            connection.Open() ;
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    l_LApplicationID = (int)reader["LocalLicenseApplicationID"];
                    testTypeID = (int)reader["TestTypeID"];
                    appointmentDate = (DateTime)reader["AppointmentDate"];
                    islocked = (bool)reader["IsLocked"];
                    return true;
                }
                reader.Close();
                return false;
            }
            finally { connection.Close(); }
        }

        public static DateTime GetTestAppointmentDate(int l_L_ApplicationID, int testTypeID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select AppointmentDate from TestAppointments " +
                "where LocalLicenseApplicationID=@ID and TestTypeID=@TypeID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
            command.Parameters.AddWithValue("@TypeID", testTypeID);
            connection.Open();
            try
            {
                object value= command.ExecuteScalar();
                if(value!=null&& DateTime.TryParse(value.ToString(),out DateTime ID)) 
                    return ID;
                return DateTime.Now;
            }
            finally { connection.Close(); }
            
        }

        public static DataTable GetTestAppointmentWithSameTestType(int testTypeID, int l_L_ApplicationID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dataTable = new DataTable();
            connection.Open();
            string Query = "select * from TestAppointments where " +
                "TestTypeID=@TypeID and LocalLicenseApplicationID=@L_LApplicationID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TypeID", testTypeID);
            command.Parameters.AddWithValue("@L_LApplicationID", l_L_ApplicationID);
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
               
        public static bool IsHasAppointmentNotFinished(int l_L_ApplicationID, int testTypeID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query= "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM TestAppointments WHERE TestTypeID =@TypeID" +
                " and LocalLicenseApplicationID=@L_L_AID and IsLocked=0)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TypeID", testTypeID);
            command.Parameters.AddWithValue("@L_L_AID", l_L_ApplicationID);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool Result))
                    return Result;
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool Update(int testAppointmentID, DateTime appointmentDate, bool islocked)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "UPDATE TestAppointments set AppointmentDate=@AppointmentDate,IsLocked =@IsLocked" +
                " WHERE TestAppointmentID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", testAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@IsLocked", islocked);
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
    }
}
