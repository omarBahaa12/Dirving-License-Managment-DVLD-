using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsTestData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(int testAppointmentID, bool result, string notes)
        {
            SqlConnection connection =new SqlConnection(ConnectionString);
            connection.Open();
            if(notes==null)
                notes = string.Empty;
            string Query = "INSERT INTO Tests(TestAppointmentID,TestResult,Notes) " +
                "VALUES(@TestAppointmentID,@TestResult,@Notes)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@TestResult", result);
            command.Parameters.AddWithValue("@Notes", notes);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static bool IsFailedTestType(int l_L_applicationID, int testTypeID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Tests,TestAppointments WHERE TestTypeID =@TypeID" +
                " and LocalLicenseApplicationID=@L_L_AID and TestResult=0" +
                " and Tests.TestAppointmentID=TestAppointments.TestAppointmentID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TypeID", testTypeID);
            command.Parameters.AddWithValue("@L_L_AID", l_L_applicationID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool Found))
                    return Found;
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool IsPassedTestType(int L_L_ApplicationID, int testTypeID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Tests,TestAppointments WHERE TestTypeID =@TypeID" +
                " and LocalLicenseApplicationID=@L_L_AID and TestResult=1" +
                " and Tests.TestAppointmentID=TestAppointments.TestAppointmentID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TypeID", testTypeID);
            command.Parameters.AddWithValue("@L_L_AID", L_L_ApplicationID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool Found))
                    return Found;
                return false;
            }
            finally { connection.Close(); }
        }
    }
}
