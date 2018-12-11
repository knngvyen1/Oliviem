using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace OLIVIEM.DAL.Account
{
   public class Accountdatabase : IAccountcontext
    {
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);


        public void AddSaldo(double saldo, int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //prepared q
                conn.Open();
                string query = $"UPDATE [User] SET saldo += { saldo } WHERE [User].Userid = {id}";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public int Getsaldo(int id)
        {
            conn.Open();
            string query = $"SELECT * FROM [User] WHERE Userid = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            int saldo = 0;
            cmd.Parameters.AddWithValue("@id", id);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AddSaldo(0, id);
                    saldo = Convert.ToInt32(reader["saldo"]);
                }
            }
            conn.Close();
            return saldo;
        }


    }
}
