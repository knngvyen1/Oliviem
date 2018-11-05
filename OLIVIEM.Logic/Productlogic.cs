using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
   public class Productlogic
    {
        private Productrepository productrepository;
        
        public Productlogic(Productrepository productrepository)
        {
            this.productrepository = productrepository;
        }

        public new List<Product> GetAllProducts()
        {
            return productrepository.GetAllProducts();
        }
      
    }
}
