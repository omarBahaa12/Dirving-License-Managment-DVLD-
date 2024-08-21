using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataTier
{
    public class clsL_LicenseApplicationData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";
        public static int Add(int licenseClassID, int applicationID,byte TestPassed)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "INSERT INTO LocalLicenseApplication(LicenseClassID,ApplicationID,TestPassed)" +
                " VALUES (@LicenseClassID,@ApplicationID,@Test)"+
                                "select SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@Test", TestPassed);
            connection.Open();
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null && int.TryParse(Value.ToString(), out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static bool Delete(int l_L_ApplicationID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "DELETE FROM LocalLicenseApplication WHERE LocalLicenseApplicationID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
            connection.Open();
            try
            {
                int Value = command.ExecuteNonQuery();
                if (Value != 0)
                    return true;
                return false;
            }
            finally { connection.Close(); }
        }
        public static void Find(int l_L_ApplicationID, ref int licenseClassID, ref int applicationID, 
            ref int applicationTypeID, ref int personID, ref int userID, ref string applicationStatus,
            ref byte testPassed, ref DateTime applicationDate)
        {
            SqlConnection connection =new SqlConnection(ConnectionString);
            string Query = "select * from LocalLicenseApplication,Applications " +
                "where LocalLicenseApplicationID=@ID and LocalLicenseApplication.ApplicationID=Applications.ApplicationID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    l_L_ApplicationID = (int)reader["LocalLicenseApplicationID"];
                    licenseClassID = (int)reader["LicenseClassID"];
                    applicationID = (int)reader["ApplicationID"];
                    testPassed = Convert.ToByte(reader["TestPassed"]);
                    applicationStatus = (string)reader["ApplicationStatus"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    personID = (int)reader["PersonID"];
                    userID = (int)reader["UserID"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                }
                reader.Close();
            }
            finally { connection.Close(); }
        }
        public static int GetApplicationID(int l_L_ApplicationID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "Select ApplicationID from LocalLicenseApplication where LocalLicenseApplicationID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
            connection.Open();
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null && int.TryParse(Value.ToString(), out int AppID))
                    return AppID;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static int GetLicenseClassID(int l_L_ApplicationID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "Select LicenseClassID from LocalLicenseApplication where LocalLicenseApplicationID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
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
        public static DataTable GetL_L_ApplicationList()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable table = new DataTable();
            string Query = "Select LocalLicenseApplicationID,FullName=FirstName+' '+SecondName+' '+ThirdName+' '+LastName," +
                "NationalNumber,ClassName,ApplicationDate,TestPassed,ApplicationStatus" +
                " from LocalLicenseApplication,Applications,LicenseClass,Persons " +
                "Where LocalLicenseApplication.LicenseClassID=LicenseClass.LicenseClassID and " +
                "LocallicenseApplication.ApplicationID=Applications.ApplicationID and " +
                "Applications.PersonID=Persons.PersonID";              
            SqlCommand command=new SqlCommand(Query, connection);
            connection.Open ();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
                return table;
            }
            finally
            { connection.Close(); }
        }
        public static int GetPersonID(int l_L_ApplicationID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select PersonID from Applications,LocalLicenseApplication where LocalLicenseApplicationID=@ID " +
                "and Applications.ApplicationID=LocalLicenseApplication.ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
            connection.Open ();
            try
            {
                object value = command.ExecuteScalar();
                if(value != null&&int.TryParse(value.ToString(),out int PersonID))
                    return PersonID;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static byte GetTestPassed(int l_L_ApplicationID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open ();
            string Query = "Select TestPassed from LocalLicenseApplication where LocalLicenseApplicationID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", l_L_ApplicationID);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && byte.TryParse(value.ToString(), out byte TestPassed))
                    return TestPassed;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static bool IsPersonHasSameApplicationOfL_L_Application(int PersonID,int LicenseClassID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
                string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM LocalLicenseApplication , Applications WHERE " +
                "LocalLicenseApplication.ApplicationID =Applications.ApplicationID and" +
                " PersonID=@ID and LicenseClassID=@ClassID and ApplicationStatus!='Cancel')" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", PersonID);
            command.Parameters.AddWithValue("@ClassID", LicenseClassID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && bool.TryParse(value.ToString(), out bool result))
                    return result;
                return false;
            }
            finally { connection.Close(); }
        }
        public static bool  Update(int l_LicenseApplicationID, int licenseClassID, byte _TestPassed)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "UPDATE LocalLicenseApplication SET LicenseClassID=@LicenseClassID,TestPassed=@TestPassed " +
                "WHERE LocalLicenseApplicationID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@ID", l_LicenseApplicationID);
            command.Parameters.AddWithValue("@TestPassed", _TestPassed);
            connection.Open() ;
            try
            {
                int value = command.ExecuteNonQuery();
                if (value != 0)
                    return true;
                return false;
            }
            finally { connection.Close() ; }
        }
        public static bool UpdateApplicationStatus(int ApplicationID, string applicationStatus)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "UPDATE Applications SET ApplicationStatus=@Status" +
                " WHERE ApplicationID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Status", applicationStatus);
            command.Parameters.AddWithValue("@ID", ApplicationID);
            connection.Open() ;
            try
            {
                int value = command.ExecuteNonQuery();
                if (value != 0) return true;
                return false;
            }
            finally { connection.Close() ; }
        }
    }
}
