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
            conn.Open();
            string query = "INSERT INTO [User](Username, Password)values(@Username,@Password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"Username", user.username);
            cmd.Parameters.AddWithValue(@"Password", user.password);
            cmd.ExecuteNonQuery();
            conn.Close();
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
                        username = (string)reader["username"],
                      
                    };
                }
            }
            return new User();
        }
        public bool UsernameExist(User username)
        {
            conn.Open();
            string query = $"SELECT username FROM [User] WHERE username ='{username.username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    if(reader.HasRows)
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
            conn.Close();
            return true;
        }

        // Delete user


      
    }
}

