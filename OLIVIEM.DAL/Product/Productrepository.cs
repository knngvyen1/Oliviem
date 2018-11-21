using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Productrepository
    {
        private ILogincontext context;
        private Productmemorycontext productmemorycontext;

        public Productrepository(ILogincontext context)
        {
            this.context = context;
        }

        public Productrepository(Productmemorycontext productmemorycontext)
        {
            this.productmemorycontext = productmemorycontext;
        }



        public List<Product> GetAllProducts()
        {
            return productmemorycontext.Getallproduct();
        }


    }
}
