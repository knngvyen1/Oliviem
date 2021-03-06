﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Models;
using OLIVIEM.Models;

namespace DAL
{
    public class RegisterDatabase : Iregistercontext
    {
        private static string connectionString = @"Server=mssql.fhict.local;Database=dbi390996;User Id=dbi390996;Password=YourChoosenPassword;12345678";
        SqlConnection conn = new SqlConnection(connectionString);

        public void AddUser(Account user)
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
        public Account GetUser(string username)
        {
            conn.Open();
            string query = $"Select username FROM [User] WHERE username = '{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    new Account()
                    {
                        username = (string)reader["username"],
                      
                    };
                }
            }
            return new Account();
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

