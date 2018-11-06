using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public interface Iregistercontext
    {
        void AddUser(User user);
        bool UsernameExist(User user);
        User GetUser(string username);
    }
}
