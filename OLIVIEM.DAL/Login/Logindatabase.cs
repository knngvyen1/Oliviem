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
        private static string connectionstring = "Data Source=LAPTOP-EAQU5PDBSQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection con = new SqlConnection(connectionstring);

        public Logindatabase()
        {

        }
        public void DeleteUser(string username, string password)
        {
            con.Open();
            string query = "DELETE from[User] where username = @username, password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue(@"username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // check if user exist in de database
        //check if user is ingelogd
        //if not melding user doesnt exist> registreer



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
