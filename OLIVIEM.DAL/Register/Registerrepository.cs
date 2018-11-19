using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Registerrepository
    {
        private Iregistercontext Context;

        public Registerrepository(Iregistercontext context)
        {
            Context = context;
        }
        
        
        public void AddUser(User user)
        {
            Context.AddUser(user);
        }

        public bool UsernameExist(string username)
        {
            return Context.UsernameExist(username);
        }
        
        public User GetUser(string username)
        {
            return Context.GetUser(username);
        }

    }
}
