using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public interface Iregistercontext
    {
        void AddUser(Account user);
        bool UsernameExist(string username);
        Account GetUser(string username);
    }
}
