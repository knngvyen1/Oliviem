using OLIVIEM.DAL.Shoppingcart;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Logic
{
   public class ShoppingcartLogic
    {
        private ShoppingcartRepository shoppingcartrepository;

        public ShoppingcartLogic(ShoppingcartRepository Shoppingcartrepository)
        {
            shoppingcartrepository = Shoppingcartrepository;
        }
    }
}

