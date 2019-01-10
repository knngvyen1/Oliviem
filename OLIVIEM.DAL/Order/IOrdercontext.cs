using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Order
{
   public interface IOrdercontext
    {
        void Create(List<Product> products, Models.Account account);
    }
}
