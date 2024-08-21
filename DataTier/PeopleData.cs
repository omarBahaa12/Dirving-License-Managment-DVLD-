using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlTypes;

namespace DataTier
{
    public class clsPersonData
    {
        static private string ConnectionString = "Server=.;Database=MyDVLD;User Id=sa;Password=sa123456;";

        public static int Add(string firstName, string secondName, string thirdName, string lastName,
            string email, string address, DateTime birthDate, string imagePath, string phone, string nationalNo, int CountryID,string Gender)
        {
            
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "INSERT INTO Persons(PersonCountryID,NationalNumber,FirstName,SecondName," +
                "ThirdName,LastName,Email,Phone,Image,Address,BirthDate,Gender)" +
                "VALUES (@PersonCountryID,@NationalNumber,@FirstName,@SecondName," +
                "@ThirdName,@LastName,@Email,@Phone,@Image,@Address,@BirthDate,@Gender)"+
                "select SCOPE_IDENTITY();" ;
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonCountryID", CountryID);
            command.Parameters.AddWithValue("@NationalNumber", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Image", imagePath);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@BirthDate", birthDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            connection.Open();
            try
            {
                object value=command.ExecuteScalar();
                if (value != null&&int.TryParse(value.ToString(),out int ID))
                    return ID;
                return 0;
            }
            finally { connection.Close(); }
        }

        public static bool Delete(int iD)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "DELETE FROM Persons WHERE PersonID=@ID";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", iD);
            connection.Open();
            try
            {
                int value = command.ExecuteNonQuery();
                if (value != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            finally { connection.Close(); }
        }

        public static DateTime GetDataBirth(int personID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "Select BirthDate from Persons where PersonID=@ID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", personID);
            connection.Open();
            try
            {
                object value = command.ExecuteScalar();
                if (value != null && DateTime.TryParse(value.ToString(), out DateTime Birthdate))
                    return Birthdate;
                return DateTime.MinValue;
            }
            finally { connection.Close(); }
        }

        public static string GetFullName(int personID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "Select FullName=FirstName+' '+SecondName+' '+ThirdName+' '+LastName " +
                "from Persons where PersonID=@ID";
            SqlCommand cmd=new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ID", personID);
            connection.Open();
            try
            {
                object value = cmd.ExecuteScalar();
                if (value != null)
                    return value.ToString();
                return "";
            }
            finally { connection.Close(); }
        }

        public static DataTable GetPeopleList()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            string Query = "select PersonID,NationalNumber,FullName=FirstName+' '+SecondName+' '+ThirdName+' '+LastName," +
                "Gender,CountryName,BirthDate,Phone,Email from Persons,Countries " +
                "where Persons.PersonCountryID=Countries.CountryID";
            DataTable PeopleData = new DataTable();
            SqlCommand command = new SqlCommand(Query, connection);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    PeopleData.Load(reader);
                return PeopleData;
            }
            finally { connection.Close(); }
        }

        public static bool GetPerson(int ID, ref string firstName, ref string secondName, ref string thirdName,
            ref string lastName, ref string email, ref string nationalNo,
            ref string gender, ref int countryID,ref string phone, 
            ref string address,ref string image,ref DateTime dateBirth)
        {
            SqlConnection connection =new SqlConnection(ConnectionString);
            string Query = "select * from Persons where PersonID=@ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    nationalNo = (string)reader["NationalNumber"];
                    gender = (string)reader["Gender"];
                    address = (string)reader["Address"];
                    countryID = (int)reader["PersonCountryID"];
                    dateBirth = (DateTime)reader["BirthDate"];
                    if (!Convert.IsDBNull(reader["Image"]))
                        image = (string)reader["Image"];
                    return true;
                }
                reader.Close();
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool GetPerson(ref int ID, ref string firstName, ref string secondName, ref string thirdName,
            ref string lastName, ref string email,string nationalNo,
            ref string gender, ref int countryID, ref string phone,
            ref string address, ref string image, ref DateTime dateBirth)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "select * from Persons where NationalNumber=@Nationno";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Nationno", nationalNo);
            connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID = (int)reader["PersonID"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    gender = (string)reader["Gender"];
                    address = (string)reader["Address"];
                    countryID = (int)reader["PersonCountryID"];
                    dateBirth = (DateTime)reader["BirthDate"];
                    if (!Convert.IsDBNull(reader["Image"]))
                        image = (string)reader["Image"];
                    return true;
                }
                reader.Close();
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool IsExist(string nationalNo)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS"+
                "(SELECT *FROM Persons WHERE NationalNumber =@National)"+
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@National",nationalNo);
            connection.Open();
            try
            {
                Object Value = command.ExecuteScalar();
                if (Convert.ToInt32(Value)==1)
                {
                    return true;
                }
                return false;
            }
            finally { connection.Close(); }
        }

        public static bool IsExist(int PersonID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Persons WHERE PersonID =@ID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", PersonID);
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

        public static bool Update(int personID,int country, string firstName, string secondName, string thirdName,
            string lastName, string email, string phone, string nationalNo,
            string gender, string imagePath, DateTime birthDate, string address)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "UPDATE Persons SET PersonCountryID = @PersonCountryID,NationalNumber =@NationalNumber" +
                ",FirstName =@FirstName,SecondName=@SecondName,ThirdName=@ThirdName,LastName=@LastName,Email=@Email" +
                ",Phone =@Phone,Image =@Image,Address=@Address,BirthDate =@BirthDate,Gender=@Gender WHERE PersonID=@ID";
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            sqlCommand.Parameters.AddWithValue("@PersonCountryID", country);
            sqlCommand.Parameters.AddWithValue("@NationalNumber", nationalNo);
            sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
            sqlCommand.Parameters.AddWithValue("@SecondName", secondName);
            sqlCommand.Parameters.AddWithValue("@LastName", lastName);
            sqlCommand.Parameters.AddWithValue("@ThirdName", thirdName);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);
            sqlCommand.Parameters.AddWithValue("@Image", imagePath);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@BirthDate",birthDate);
            sqlCommand.Parameters.AddWithValue("@Gender", gender);
            sqlCommand.Parameters.AddWithValue("@ID", personID);
            try
            {
                int value=sqlCommand.ExecuteNonQuery();
                if (value != 0)
                    return true;
                return false;
            }
            finally { connection.Close(); }

        }
    }
}
