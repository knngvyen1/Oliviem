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
        

        public Loginlogic(Loginrepository repository)
        {
            this.repository = repository;
        }


        //Usecase 1 en 2
        public bool Login(User user)
        {
            if (user.password.Length <= 8)
            {
                return false;
            }
            return repository.Login(user); 
        }
       

       
    }
}
