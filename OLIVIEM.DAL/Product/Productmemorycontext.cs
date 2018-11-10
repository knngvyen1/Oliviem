using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Productmemorycontext : Iproductcontext
    {
        public List<Product> products;

        public Productmemorycontext()
        {
            products = new List<Product>();
            AddFakeData();
        }

        private void AddFakeData()
        {
            products.Add(new Product("Groene broek", "s", "grijs", 3.26, "broeken", 6));
            products.Add(new Product("Paarse broek", "m", "wit", 3.26, "broeken", 10));
        }

        public List<Product> Getallproduct()
        {
           
            return products;
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
        //voeg product toe
        // delete product
        // haal alle producten op
        //haal een specifiek product op / zoek een product
        //producten filteren
        
    }
}
