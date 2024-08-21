using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class clsApplicationTypesData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static DataTable ApplicationTypeList()
        {
            SqlConnection connection =new SqlConnection(ConnectionString);
            connection.Open();
            string query = "select * from ApplicationType";
            SqlCommand command=new SqlCommand(query, connection);
            DataTable dataTable = new DataTable();
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

        public static bool GetApplicationType(int applicationID, ref string title, ref double fees)
        {
            SqlConnection connection =new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select * from ApplicationType where ApplicationID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", applicationID);
            try 
            { 
                SqlDataReader reader=command.ExecuteReader();
                while(reader.Read())
                {
                    title = (string)reader["Title"];
                    fees = (double)reader["Fees"];
                    return true;
                }
                reader.Close();
                return false;
            } 
            finally { connection.Close(); }
        }

        public static double GetApplicationTypeFees(int applicationID)
        {
            SqlConnection connection =new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select Fees from ApplicationType where ApplicationID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", applicationID);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && double.TryParse(value.ToString(), out double Fees))
                    return Fees;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static string GetApplicationTypeName(int applicationTypeID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select Title from ApplicationType where ApplicationID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", applicationTypeID);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null)
                    return value.ToString();
                return "";
            }
            finally { connection.Close(); }
        }

        public static bool Update(int applicationID, double fees, string title)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "UPDATE ApplicationType SET Title =@Title,Fees =@Fees WHERE ApplicationID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", applicationID);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Fees", fees);
            try
            {
                int value = command.ExecuteNonQuery();
                if (value > 0)
                {
                    return true;
                }
                return false;
            }
            finally { connection.Close(); }
        }
    }
}
