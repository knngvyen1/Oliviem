using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Loginrepository
    {
        private ILogincontext context;
        private Logindatabase database;

        //public Loginrepository(ILogincontext context)
        //{
        //    this.context = context;
        //}
        public Loginrepository(Logindatabase database)
        {
            this.database = database;
        }

        public bool Login(User user)
        {
            return context.Login(user); 
        }

      
        
    }
}
