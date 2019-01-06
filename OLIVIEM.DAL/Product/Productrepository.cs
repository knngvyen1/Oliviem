using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Productrepository
    {
        private Iproductcontext context;

        public Productrepository(Iproductcontext Context)
        {
            this.context = Context;
        }

        public void AddProduct(Product product)
        {
            context.AddProduct(product);
        }

        public bool CategoryExists(int id)
        {
            return context.CategoryExists(id);
        }

        public List<Product> GetAllProducts()
        {
           return  context.GetAllProducts();
        }

        public Product GetProduct(int id)
        {
            return context.GetProduct(id);
        }
        public List<Product> GetCategoryproducts(string category)
        {
            return context.GetCategoryproducts(category);
        }


    }
}
