using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class clsUsersData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";
        public static DataTable GetUserList()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "Select UserID,UserName,FullName=FirstName+' '+SecondName+' '+ThirdName+' '+LastName,NationalNumber," +
                "CountryName,IsActive from Users,Persons,Countries where Users.PersonID=Persons.PersonID and " +
                "Persons.PersonCountryID=Countries.CountryID";
            DataTable table = new DataTable();
            SqlCommand command=new SqlCommand(Query,connection);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
                return table;
            }
            finally {connection.Close();  }
        }
        public static int Add(string userName, string password, int personID, bool _IsActive)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Users(PersonID,UserName,Password,IsActive)" +
                "VALUES(@PersonID,@UserName,@Password,@IsActive) "+
                "select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", _IsActive);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null&&int.TryParse(value.ToString(),out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static bool IsExist(int UserID)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Users WHERE UserID =@ID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", UserID);
            connection.Open();
            try
            {
                Object Value = command.ExecuteScalar();
                if (Convert.ToInt32(Value) == 1)
                {
                    return true;
                }
                return false;
            }
            finally { connection.Close(); }
        }
        public static bool IsExistPersonID(int UserID,int PersonID)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query;
            if (UserID == 0)
            {
                 Query = "SELECT CASE WHEN EXISTS" +
                    "(SELECT UserID FROM Users WHERE PersonID =@ID)" +
                    "THEN CAST(1 AS BIT)" +
                    "ELSE CAST(0 AS BIT) END";
            }
            else
            {
                Query = "Select UserID from Users Where PersonID=@ID";
            }
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", PersonID);
            connection.Open();
            try
            {
                Object Value = command.ExecuteScalar();
                if (Convert.ToInt32(Value) != 0&&Convert.ToInt32(Value)!=UserID)
                {
                    return true;
                }
                return false;
            }
            finally { connection.Close(); }
        }
        public static bool Delete(int userID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "DELETE FROM Users WHERE UserID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", userID);
            connection.Open();
            try
            {
                int value = command.ExecuteNonQuery();
                if (value > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
            finally { connection.Close(); }
        }
        public static void GetUser(int userID, ref string userName, ref string password, ref int personID, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select * from Users Where UserID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", userID);
            connection.Open();
            try
            {
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    userName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    personID = (int)reader["PersonID"];
                    isActive = (bool)reader["IsActive"];
                }
                reader.Close();
            }
            finally { connection.Close(); }
        }
        public static bool Update(int userID, string password, int personID, bool isActive,string UserName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "UPDATE Users SET PersonID=@PersonID,UserName=@UserName," +
                "Password =@Password,IsActive =@IsActive WHERE userID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@ID", userID);
            command.Parameters.AddWithValue("@IsActive", isActive);
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
        public static bool IsUserFound(ref int UserID,ref string userName,string password
            ,ref int PersonID,ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select * from Users where UserName=@Name and Password=@password";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", userName);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    userName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                    return true;
                }
                reader.Close();
                return false;
            }
            finally { connection.Close(); }
        }
        public static string GetUserName(int userID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select UserName from Users Where UserID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", userID);
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
    }
}
