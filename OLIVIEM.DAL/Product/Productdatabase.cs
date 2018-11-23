using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DAL;
using OLIVIEM.Models;

namespace OLIVIEM.DAL
{
   public class ProductDatabase : Iproductcontext 
    {
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);

        public void AddProduct(Product product)
        {
            conn.Open();
            string query = "INSERT INTO [Product](Name, Price, Color, Size, Quantity)values(@Name, @Price, @Color, @Size, @Quantity)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"Name", product.Name);
            cmd.Parameters.AddWithValue(@"Price", product.Price);
            cmd.Parameters.AddWithValue(@"Color", product.Color);
            cmd.Parameters.AddWithValue(@"Size", product.Size);
            cmd.Parameters.AddWithValue(@"Quantity", product.Quantity);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

    }
}
