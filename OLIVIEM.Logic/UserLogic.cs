using OLIVIEM.DAL.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Logic
{
   public class UserLogic
    {
        private UserRepository userrepository;

        public UserLogic(UserRepository Userrepository)
        {
            userrepository = Userrepository;
        }
    }
}
