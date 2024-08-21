using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsDriversData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(int personID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Drivers(PersonID) VALUES (@PersonID)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int id))
                    return id;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static int GetDriverID(int personID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select DriverID from Drivers Where PersonID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", personID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int id))
                    return id;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static int GetPersonID(int driverID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select PersonID from Drivers Where DriverID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", driverID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && int.TryParse(value.ToString(), out int id))
                    return id;
                return 0;
            }
            finally { connection.Close(); }
        }
        public static DataTable DriverList()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select Licenses.DriverID,Drivers.PersonID,FullName=FirstName +' '+ SecondName +' '+ ThirdName+' '+LastName,"+
                "NationalNumber,ActiveLicense = COUNT(Licenses.DriverID) from Licenses,Drivers,Persons "+
                "where Licenses.IsActive=1 and Licenses.DriverID = Drivers.DriverID and Drivers.PersonID = Persons.PersonID " +
                "Group by Licenses.DriverID,Drivers.PersonID,"+
				"Persons.FirstName,Persons.SecondName,Persons.ThirdName,Persons.LastName,Persons.NationalNumber";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
                return table;
            }
            finally { connection.Close(); }
        }
        public static bool IsExist(int personID)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Drivers WHERE PersonID =@Person)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Person", personID);
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
