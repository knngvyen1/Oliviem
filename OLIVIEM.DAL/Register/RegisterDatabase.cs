using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Models;

namespace DAL
{
    public class RegisterDatabase : Iregistercontext
    {
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);

        public void AddUser(User user)
        {
            
            string query = "INSERT INTO [User](Username, Password)values(@Username,@Password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool UsernameExist(string username)
        {
            conn.Open();
            //prepare query
            string query = $"SELECT username FROM [User] WHERE username ='{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = -1;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            conn.Close();
            if (id != -1)
            {
                return true;
            }
            return false;
        }
        public User GetUser(string username)
        {
            conn.Open();
            string query = $"Select username FROM [User] WHERE username = '{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    new User()
                    {
                        Username = (string)reader["username"],
                      
                    };
                }
            }
            return new User();
        }

        public bool UsernameExist(User user)
        {
            throw new NotImplementedException();
        }
    }
}

