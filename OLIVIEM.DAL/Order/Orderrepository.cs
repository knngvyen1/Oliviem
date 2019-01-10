using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Order
{
    public class Orderrepository
    {
        private IOrdercontext Context;

        public Orderrepository(IOrdercontext context)
        {
            Context = context;
        }

        public void Create(List <Product> products, Models.Account account)
        {
            Context.Create(products, account);
        }
    }
}
