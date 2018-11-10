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
        public void AddUser(string username, string password)
        {
            con.Open();
            string query = "INSERT INTO [User](Username, Password)values(@usr,@pas)";
            SqlCommand cmd = new SqlCommand( query, con);
            cmd.Parameters.AddWithValue(@"Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
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
