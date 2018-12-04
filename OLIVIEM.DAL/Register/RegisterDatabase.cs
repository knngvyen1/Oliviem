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
            string query = "INSERT INTO [User] (Name, Lastname, DateOfBirth, Gender, Username, Password, Saldo)values(@nm, @ln, @dbr, @gdr, @usr, @psw, @sld)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nm", user.name);
            cmd.Parameters.AddWithValue("@ln", user.lastname);
            cmd.Parameters.AddWithValue("@dbr", user.dateofbirth);
            cmd.Parameters.AddWithValue("@gdr", user.gender);
            cmd.Parameters.AddWithValue("@usr", user.username);
            cmd.Parameters.AddWithValue("@psw", user.password);
            cmd.Parameters.AddWithValue("@sld", user.saldo);
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
        public bool UsernameExist(string username)
         {
            conn.Open();    
            string query = "SELECT * FROM [User] WHERE Username = '" + username + "'";// aantal username
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            bool hasRows = reader.HasRows;
            hasRows = reader.HasRows;
            conn.Close();
            return hasRows; //moet true zijn als er een gebruiker bestaat
                
        }




      
    }
}

