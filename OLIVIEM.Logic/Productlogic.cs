using DAL;
using Models;
using OLIVIEM.Models;
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


        public void Addproduct(Product product)
        {
     
            productrepository.AddProduct(product);
        }

        public List<Product> GetAllProducts() 
        {
            return productrepository.GetAllProducts();
        }
        public List<Product> GetCategoryproducts(string category)
        {
            return productrepository.GetCategoryproducts(category);
        }


        public Product GetProduct(int id)
        {
            return productrepository.GetProduct(id);
        }
      
      
    }
}
