using OLIVIEM.Models;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace OLIVIEM.DAL.Order
{
    public class Orderdatabase : IOrdercontext
    {
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);


        public void Create(List<Product> products, Models.Account account)
        {
            conn.Open();
            string query = "Insert into [Order](Orderstatus, Userid) values(@Orderstatus, @Userid); SELECT SCOPE_IDENTITY() as 'orderId'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Orderstatus", Models.Enums.OrderStatus.Verwerken);
            cmd.Parameters.AddWithValue("@Userid", account.id);
            decimal orderId = 0;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    orderId = (decimal)reader["orderId"];
                }
            }

            foreach (var product in products)
            {
                query = "Insert into [OrderProducts](name, orderId, userId) values(@name, @orderId, @userId)";
                SqlCommand test = new SqlCommand(query, conn);
               
                test.Parameters.AddWithValue("@name", product.Name);
                test.Parameters.AddWithValue("@orderId", orderId);
                test.Parameters.AddWithValue("@userId", account.id);
                test.ExecuteNonQuery();
                    
            }
            conn.Close();
        }
    }
}
