using OLIVIEM.Models;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace OLIVIEM.DAL.Order
{
    public class Orderdatabase : IOrdercontext
    {
        private static string connectionString = @"Server=mssql.fhict.local;Database=dbi390996;User Id=dbi390996;Password=YourChoosenPassword;12345678";
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
                query = "Insert into [OrderProducts](name, orderId, userId, price) values(@name, @orderId, @userId, @price)";
                SqlCommand test = new SqlCommand(query, conn);
               
                test.Parameters.AddWithValue("@name", product.Name);
                test.Parameters.AddWithValue("@orderId", orderId);
                test.Parameters.AddWithValue("@userId", account.id);
                test.Parameters.AddWithValue("@price",  product.Price);
                test.ExecuteNonQuery();
                    
            }
            conn.Close();
        }
    }
}
