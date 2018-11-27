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

        public void GetAllProducts(List<Product> products)
        {
            context.GetAllProducts(products);
        }


    }
}
