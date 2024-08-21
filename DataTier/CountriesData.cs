using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class clsCountriesData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int GetCountryID(string country)
        {
            SqlConnection sqlConnection=new SqlConnection(ConnectionString);
            string Query = "select CountryID from Countries Where CountryName =@Country";
            SqlCommand command=new SqlCommand(Query,sqlConnection);
            command.Parameters.AddWithValue("@Country", country);
            sqlConnection.Open();
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null && int.TryParse(Value.ToString(), out int ID))
                    return ID;
                return 0;
            }
            finally { sqlConnection.Close(); }
        }
        public static string GetCountryName(int countryid)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string Query = "select CountryName from Countries Where CountryID=@Country";
            SqlCommand command = new SqlCommand(Query, sqlConnection);
            command.Parameters.AddWithValue("@Country", countryid);
            sqlConnection.Open();
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null )
                    return Value.ToString();
                return "";
            }
            finally { sqlConnection.Close(); }
        }
        public static DataTable GetCountries()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable table = new DataTable();
            string Query = "Select CountryName from Countries order by CountryName asc";
            SqlCommand command= new SqlCommand(Query, connection);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
                return table;
            }
            finally { connection.Close(); }
        }
    }
}
