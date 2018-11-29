using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    //regels
    public class Registerlogic
    {
        private Registerrepository Repository;
        private const int MIN_PASSWORD_LENGTH = 8;

        public Registerlogic(Registerrepository registerrepository)
        {
            this.Repository = registerrepository;
        }

        public void AddUser(User user)
        {

            if (user.password.Length >= MIN_PASSWORD_LENGTH)
            {
                if (UsernameExists(user.username)== true)
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

        private bool UsernameExists(string username)
        {
            return Repository.UsernameExist(username);
        }

        public User GetUser(string username)
        {
            return Repository.GetUser(username);
        }


    }
}
