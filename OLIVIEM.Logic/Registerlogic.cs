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

        public Registerlogic(Registerrepository registerrepository)
        {
            this.Repository = registerrepository;
        }

        public void AddUser(User user)
        {
            if (UsernameExist(user))
            {
                throw new NullReferenceException();
            }
            if (user.password.Length >= 8)
            {
                Repository.AddUser(user);
            }
            else
            {
                throw new Exception();
            }
        }

        public bool UsernameExist(User user)
        {
            return Repository.UsernameExist(user);
        }

        public User GetUser(string username)
        {
            return Repository.GetUser(username);
        }


    }
}
