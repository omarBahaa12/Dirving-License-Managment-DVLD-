using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class clsApplicationData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(string ApplicationStatus,
                int ApplicationTypeID,int PersonID,DateTime ApplcationDate, int UserID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "INSERT INTO Applications(ApplicationStatus,ApplicationTypeID ," +
                "PersonID,ApplicationDate,UserID) VALUES (@ApplicationStatus,@ApplicationTypeID," +
                "@PersonID,@ApplicationDate,@UserID) " +
                "select SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplcationDate);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null&&int.TryParse(Value.ToString(),out int ID)) 
                {
                    return ID;
                }
                return 0;
            }
            finally { connection.Close(); }
        }

        public static bool Delete(int applicationID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query= "DELETE FROM Applications WHERE ApplicationID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", applicationID);
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

        public static bool Find(int applicationID, ref int personID, ref int userID, ref int applicationType,
            ref string applicationStatus, ref DateTime applicationDate)
        {
            SqlConnection sqlConnection=new SqlConnection(ConnectionString);
            string Query = "select * from Applications where ApplicationID=@ID";
            SqlCommand command= new SqlCommand(Query, sqlConnection);
            command.Parameters.AddWithValue("@ID", applicationID);
            sqlConnection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    userID = (int)reader["UserID"];
                    applicationType = (int)reader["ApplicationTypeID"];
                    applicationStatus = (string)reader["ApplicationStatus"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    return true;
                }
                reader.Close();
                return false;
            }
            finally {  sqlConnection.Close(); }
        }

        public static bool Update(int ApplicationID ,int personID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "UPDATE Applications SET  PersonID =@PersonID WHERE ApplicationID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ApplicationID);
            command.Parameters.AddWithValue("@PersonID", personID);
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
    }
}
