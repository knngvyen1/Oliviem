using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class Registerrepository
    {
        private Iregistercontext Context;
        private RegisterDatabase Database;
        //public Registerrepository(RegisterDatabase database)
        //{
        //    Database = database;
        //}
        public Registerrepository(Iregistercontext context)
        {
            Context = context;
        }
        
        
        public void AddUser(User user)
        {
            Context.AddUser(user);
        }
    }
}
