using DAL;
using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
   
    public class Registerlogic
    {
        private Registerrepository Repository;
        private const int MIN_PASSWORD_LENGTH = 8;

        public Registerlogic(Registerrepository registerrepository)
        {
            this.Repository = registerrepository;
        }


        public void AddUser(Account user)

        {
            if (user.password.Length >= MIN_PASSWORD_LENGTH)
            {
                if (UsernameExists(user.username) == false)
                {
                    Repository.AddUser(user);
                }
                else
                {
                    //bestaat al😡
                    throw new Exception("User already exists😡.");
                }
            }          
            else
            {
                //ww nie lang genoeg
                throw new Exception($"Password is too short. Required length is {MIN_PASSWORD_LENGTH}.😡");
            }
        }

        public bool UsernameExists(string username)
        {
            return Repository.UsernameExist(username);
        }


    }
}
