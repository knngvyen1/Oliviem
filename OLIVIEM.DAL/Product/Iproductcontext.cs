using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{
    public interface Iproductcontext
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
    }
}
