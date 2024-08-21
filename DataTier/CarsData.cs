using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    static public class clsCarsData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";
        
        static public DataTable AllCarsData()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string query = "select * from Cars";
            SqlCommand command=new SqlCommand(query, connection);
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
                return dataTable;
            }
            finally { connection.Close(); }
        }

        static public int Add(int issueDate, string maker, string model, string bodyStyle)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "INSERT INTO Cars(IssueDate,Maker,Model,BodyStyles) VALUES(@year,@make,@model,@body_styles)"+
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@year", issueDate);
            command.Parameters.AddWithValue("@make", maker);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@Body_styles", bodyStyle);
            try
            {
                object value = command.ExecuteScalar();
                if (value != null&&int.TryParse(value.ToString(),out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static bool Update(int ID,short issueDate, string maker, string model, string bodyStyle)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "UPDATE Cars SET IssueDate = @year,Maker= @make,Model =@model,BodyStyles =@body_styles WHERE ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@year", issueDate);
            command.Parameters.AddWithValue("@make", maker);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@Body_styles", bodyStyle);
            try
            {
                int value = command.ExecuteNonQuery();
                if (value != 0)
                    return true;
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool Find(int iD, ref string maker, ref string model, ref string bodyStyle, ref short issueDate)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "select * from Cars WHERE ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", iD);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    maker = (string)reader["Maker"];
                    model = (string)reader["Model"];
                    bodyStyle = (string)reader["BodyStyle"];
                    issueDate = Convert.ToInt16(reader["IssueDate"]);
                    return true;
                }
                return false;
            }
            finally { connection.Close(); }
        }
    }
}
