using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Loginrepository
    {
        private ILogincontext Context;

        public Loginrepository(ILogincontext context)
        {
            Context = context;
        }
        //public Loginrepository(Logindatabase database)
        //{
        //    this.database = database;
        //}

        public bool Login(User user)
        {
            return Context.Login(user); 
        }

      
        
    }
}
