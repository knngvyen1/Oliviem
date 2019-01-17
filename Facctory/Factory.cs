using DAL;
using Logic;
using OLIVIEM.DAL;
using OLIVIEM.DAL.Account;
using OLIVIEM.DAL.Order;
using OLIVIEM.Logic;

namespace Factory
{
    public static class Factory
    {
         
        public static Loginlogic GetLoginLogic()
        {
            return new Loginlogic(new Loginrepository(new Logindatabase()));
        }

        public static Productlogic GetProductslogic()
        {
            return new Productlogic(new Productrepository(new ProductDatabase()));
        }

        public static Accountlogic GetAccountlogic()
        {
            return new Accountlogic(new Accountrepository(new Accountdatabase()));
        }

        public static Orderlogic GetOrderLogic()
        {
            return new Orderlogic(new Orderrepository(new Orderdatabase()));
        }

        public static Registerlogic GetRegisterlogic()
        {
            return new Registerlogic(new Registerrepository(new RegisterDatabase()));
        }


       

        //Public static Shoppingcart GetShoppingcartLogic()


    }
}
