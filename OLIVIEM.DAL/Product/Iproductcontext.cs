using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{
    public interface Iproductcontext
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        Product GetProduct(int id);
    }
}
