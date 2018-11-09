using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Registerlogic
    {
        private Registerrepository Repository;

        public Registerlogic(Registerrepository registerrepository)
        {
            this.Repository = registerrepository;
        }

        public void AddUser(User user)
        {
            //if (user.Username.Length > 10)
            //{

            //}
            Repository.AddUser(user);
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
