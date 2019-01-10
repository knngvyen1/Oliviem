using OLIVIEM.DAL.Order;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
   public class Orderlogic
    {
        private Orderrepository Orderrepository;
        public Orderlogic(Orderrepository orderrepository)
        {
            Orderrepository = orderrepository;
        }

        public void Creat(List<Product> products, Account account)
        {
            Orderrepository.Create(products, account);
        }
    }
}
