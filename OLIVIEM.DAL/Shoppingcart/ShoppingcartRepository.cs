using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Shoppingcart
{
   public class ShoppingcartRepository
    {
        private IShoppingCart ishoppingcart;

        public ShoppingcartRepository(IShoppingCart IshoppingCart)
        {
            ishoppingcart = IshoppingCart;
        }
    }
}
