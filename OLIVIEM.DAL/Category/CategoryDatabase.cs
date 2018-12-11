using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OLIVIEM.DAL.Category
{
   public class CategoryDatabase : ICategorycontext
    {
        private static string connectionString = @"Data Source=LAPTOP-EAQU5PDB\SQLEXPRESS;Initial Catalog=OLIVIEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection(connectionString);
        public CategoryDatabase()
        {

        }
    }
}
