using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public static class clsTestTypesData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";
        public static DataTable GetTestTypesList()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select * from TestTypes";
            SqlCommand command=new SqlCommand(Query, connection);
            DataTable dataTable = new DataTable();
            connection.Open();
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

        public static bool Update(int TestID,string TestName,string TestDescription,double Fees)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "UPDATE TestTypes SET TestName=@TestName," +
                "TestDescription=@TestDescription,Fees=@Fees WHERE TestID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", TestID);
            command.Parameters.AddWithValue("@TestName", TestName);
            command.Parameters.AddWithValue("@TestDescription", TestDescription);
            command.Parameters.AddWithValue("@Fees", Fees);
            connection.Open();
            try
            {
                int value = command.ExecuteNonQuery();
                if (value > 0)
                    return true;
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool GetTestType(int TestID, ref string TestName, ref string TestDescription, ref double Fees)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "select * from TestTypes where TestID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@ID", TestID);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    TestName = (string)reader["TestName"];
                    TestDescription = (string)reader["TestDescription"];
                    Fees = (double)reader["Fees"];
                    return true;
                }
                reader.Close();
                return false;
            }
            finally {connection.Close();  }
        }

        public static string GetTestTypeName(int testID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "Select TestName from TestTypes Where TestID=@ID";
            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", testID);
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

        public static double GetFees(int testTypeID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select Fees from TestTypes where TestID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", testTypeID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && double.TryParse(value.ToString(), out double Fees))
                    return Fees;
                return 0.0;

            }
            finally { connection.Close();}
        }
    }
}
