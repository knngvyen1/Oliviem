using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Models;
using System.Data.SqlClient;

namespace DAL
{
   public class Logindatabase : ILogincontext
    {
        private static string connectionString = @"Server=mssql.fhict.local;Database=dbi390996;User Id=dbi390996;Password=YourChoosenPassword;12345678";
        SqlConnection conn = new SqlConnection(connectionString);

        public Logindatabase()
        {

        }
        public void DeleteUser(string username, string password)
        {
            conn.Open();
            string query = "DELETE from[User] where username = @username, password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Username en Password valid
        public bool LogIn(string Username, string Password)
        {
            conn.Open();
            int id = 0;
            bool valid = false;
            string query = $"SELECT COUNT(*) AS 'CNT' FROM [User] WHERE Username = '{Username}' AND Password = '{Password}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }               
            }
            if (id == 1)
            {
                valid = true;
            }
            conn.Close();
            return valid;
        }
    }
}
