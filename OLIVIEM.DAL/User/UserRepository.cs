using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Account
{
   public class UserRepository
    {
        private IUserContext iusercontext;
        public UserRepository(IUserContext IUsercontext)
        {
            iusercontext = IUsercontext;
        }
    }
}
