using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace DAL
{
   public class Logindatabase : ILogincontext
    {
        private static string connectionstring = "Data Source=LAPTOP-EAQU5PDBSQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection sqlConnection = new SqlConnection(connectionstring);

        public Logindatabase()
        {

        }
        public void AddUser(string username, string password)
        {
            sqlConnection.Open();
            string query = "INSERT INTO [User](Username, Password)values(@usr,@pas)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue(@"Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }

        bool ILogincontext.Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
