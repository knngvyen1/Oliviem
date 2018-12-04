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

        public bool LogIn(string Username, string Password)
        {
            return Context.LogIn(Username, Password);
        }


    }
}
