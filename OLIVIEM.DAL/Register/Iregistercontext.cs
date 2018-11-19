using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public interface Iregistercontext
    {
        void AddUser(User user);
        bool UsernameExist(string username);
        User GetUser(string username);
    }
}
