using DAL;
using Logic;

namespace Facctory
{
    public static class Factory
    {
        public static Loginlogic GetLoginLogic()
        {
            return new Loginlogic(new Loginrepository(new Logindatabase()));
        }

        public static Productlogic GetProductslogic()
        {
            return new Productlogic(new Productrepository(new Productmemorycontext()));
        }

        //public static Orderlogic GetOrderLogic()
        //{
        //    return new Orderlogic(new Orderrepository(new Ordermemorycontext()));
        //}

        public static Registerlogic GetRegisterlogic()
        {
            return new Registerlogic(new Registerrepository(new RegisterDatabase()));
        }
    }
}
