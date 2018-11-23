using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Productmemorycontext
    {
        public List<Product> products;

        public Productmemorycontext()
        {
            products = new List<Product>();
            AddFakeData();
        }

        private void AddFakeData()
        {

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
