
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
            conn.Close();
            return productList;
        }

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
                    var p =  new Product()
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
                    };
                    conn.Close();
                    return p;
                }
            }
            conn.Close();
            return null;
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
        //categorien
       
        //public List<Product> GetAllProductsTest()
        //{          
        //    SqlCommand cmd = new SqlCommand("dbo.GetProducts", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    List<Product> productList = new List<Product>();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            productList.Add(new Product()
        //            {
        //                id = (int)reader["ProductID"],
        //                Name = (string)reader["Name"],
        //                Price = (int)reader["Price"],
        //                Size = (string)reader["Size"],
        //                Color = (string)reader["Color"],
        //                Quantity = (int)reader["Quantity"],
        //                Description = (string)reader["Description"],
        //                CategoryName = (string)reader["CategoryName"],
        //                Image = (string)reader["Image"]
        //            });
        //        }
        //    }
        //    return productList;
        //}
        public List<Product> GetCategoryproducts(string category)
        {         
             List<Product> productList = new List<Product>();
            conn.Open();
            string query = $"SELECT ProductID, Name, Price, Image, Category.CategoryName FROM[Product] inner join[Category] on Product.CategoryName = Category.CategoryName where Category.CategoryName = '{category}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    productList.Add(new Product()
                    {
                        id = (int)reader["ProductID"],
                        Name = (string)reader["Name"],
                        Price = (int)reader["Price"],
                        Image = (string)reader["Image"]


                    });
                }
            }
            conn.Close();
            return productList;
        }

        public List<string> GetAllCategoryNames()
        {
            conn.Open();
            string query = "select distinct CategoryName from [Product]";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<string> CategoryList = new List<string>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategoryList.Add(reader["CategoryName"].ToString());
                }
            }
            conn.Close();
            return CategoryList;
            
        }

        
    }   
}
