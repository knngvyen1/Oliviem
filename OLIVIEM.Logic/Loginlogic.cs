using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Models;

namespace Logic
{
    public class Loginlogic
    {
        private Loginrepository repository;
        private global::DAL.Loginrepository loginrepository;

        public Loginlogic(Loginrepository repository)
        {
            this.repository = repository;
        }


        public bool Login(User user)
        {
            if (user.Password.Length < 5)
            {
                return false;
            }
            return repository.Login(user); 
        }
       

       
    }
}
