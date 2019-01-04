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
            string query = "INSERT INTO [Product](Name, Price, Color, Size, Quantity, Description, CategoryName, Image) values(@Name, @Price, @Color, @Size, @Quantity, @Description, @CategoryName, @Image)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"Name", product.Name);
            cmd.Parameters.AddWithValue(@"Price", product.Price);
            cmd.Parameters.AddWithValue(@"Color", product.Color);
            cmd.Parameters.AddWithValue(@"Size", product.Size);
            cmd.Parameters.AddWithValue(@"Quantity", product.Quantity);
            cmd.Parameters.AddWithValue(@"Description", product.Description);
            cmd.Parameters.AddWithValue(@"CategoryName", product.CategoryName);
            cmd.Parameters.AddWithValue(@"Image", product.Image);
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
                        Price = (int)reader["Price"],
                        Size = (string)reader["Size"],
                        Color = (string)reader["Color"],
                        Quantity = (int)reader["Quantity"],
                        Description = (string)reader["Description"],
                        CategoryName = (string)reader["CategoryName"],
                        Image = (string)reader["Image"]
                    });
                }
            }
            return productList;
        }

        //public List<Product> GetcategoryProducts(string category)
        //{
        //    conn.Open();
        //    string query = $"SELECT * from [Product] where category in (select CATEGORY from Product where category = '{category}')";

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
                        CategoryName = (string)reader["CategoryName"],
                        Image = (string)reader["Image"]
                    };
                }
            }
            return new Product();
        }

        public bool CategoryExists(int CategoryName)
        {
            SqlCommand cmd = new SqlCommand("dbo.CategoryExists", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
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

        public List<Product> GetAllProductsTest()
        {
            SqlCommand cmd = new SqlCommand("dbo.GetProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Product> productList = new List<Product>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    productList.Add(new Product()
                    {
                        id = (int)reader["ProductID"],
                        Name = (string)reader["Name"],
                        Price = (int)reader["Price"],
                        Size = (string)reader["Size"],
                        Color = (string)reader["Color"],
                        Quantity = (int)reader["Quantity"],
                        Description = (string)reader["Description"],
                        CategoryName = (string)reader["CategoryName"],
                        Image = (string)reader["Image"]
                    });
                }
            }
            return productList;
        }
    }
}
