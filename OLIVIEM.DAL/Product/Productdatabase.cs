using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DAL;
using OLIVIEM.Models;
using System.Data;

namespace OLIVIEM.DAL
{
   public class ProductDatabase : Iproductcontext 
    {
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);

        public void AddProduct(Product product)
        {
            conn.Open();
            string query = "INSERT INTO [Product](Name, Price, Color, Size, Quantity, Description, CategoryID) values(@Name, @Price, @Color, @Size, @Quantity, @Description, @CategoryID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"Name", product.Name);
            cmd.Parameters.AddWithValue(@"Price", product.Price);
            cmd.Parameters.AddWithValue(@"Color", product.Color);
            cmd.Parameters.AddWithValue(@"Size", product.Size);
            cmd.Parameters.AddWithValue(@"Quantity", product.Quantity);
            cmd.Parameters.AddWithValue(@"Description", product.Description);
            cmd.Parameters.AddWithValue(@"CategoryID", product.CategoryID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Product> GetAllProducts()
        {
            conn.Open();
            string query = "SELECT * FROM [PRODUCT]";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Product> productList = new List<Product>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    productList.Add(new Product()
                    {
                        id = (int)reader["ProductID"],
                        Name = (string)reader["Name"],
                        Price = (decimal)reader["Price"],
                        Size = (string)reader["Size"],
                        Color = (string)reader["Color"],
                        Quantity = (int)reader["Quantity"],
                        Description = (string)reader["Description"],
                        CategoryID = (int)reader["CategoryID"]
                    });
                }
            }
            return productList;
        }

        //public List<Product> GetAllWomenProducts(string category)
        //{
        //    conn.Open();
        //    string query = $"SELECT * from [Product] where color in (select COLOR from Product where color = '{category}')";

        //}

        public Product GetProduct(int id)
        {
            conn.Open();
            string query = $"SELECT * FROM [Product] WHERE ProductID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    return new Product()
                    {
                        id = (int)reader["ProductID"],
                        Name = (string)reader["Name"],
                        Price = (decimal)reader["Price"],
                        Size = (string)reader["Size"],
                        Color = (string)reader["Color"],
                        Quantity = (int)reader["Quantity"],
                        Description = (string)reader["Description"],
                        CategoryID = (int)reader["CategoryID"]
                    };
                }
            }
            return new Product();
        }

        public bool CategoryExists(int id)
        {
            SqlCommand cmd = new SqlCommand("dbo.CategoryExists", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryId", id);
            conn.Open();
            var test = cmd.ExecuteReader();
            while (test.Read())
            {
                if (test.HasRows)
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;

        }
    }
}
