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


        public Loginlogic(Loginrepository Repository)
        {
           repository = Repository;
        }

        public bool LogIn(string Username, string Password)
        {
          return repository.LogIn(Username, Password);

          
        }

        //Usecase 1 en 2
        //public bool Login(User user)
        //{
        //    if (user.password.Length <= 8)
        //    {
        //        return false;
        //    }
        //    return repository.Login(user); 
        //}





    }
}
