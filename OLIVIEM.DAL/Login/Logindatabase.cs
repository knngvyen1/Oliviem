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
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);

        public Logindatabase()
        {

        }
        //public void DeleteUser(string username, string password)
        //{
        //    con.Open();
        //    string query = "DELETE from[User] where username = @username, password = @password";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.Parameters.AddWithValue(@"username", username);
        //    cmd.Parameters.AddWithValue("@password", password);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

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
       



        // check if user exist in de database
        //check if user is ingelogd
        //if not melding user doesnt exist> registreer


    }
}
