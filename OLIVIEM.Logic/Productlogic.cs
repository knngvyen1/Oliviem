﻿using DAL;
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

        public void GetAllProducts() 
        {
            productrepository.GetAllProducts();
        }
      
      
    }
}
