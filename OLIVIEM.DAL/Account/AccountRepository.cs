using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Account
{
   public class AccountRepository
    {
        private IAccountContext iaccountcontext;
        public AccountRepository(IAccountContext IAccountcontext)
        {
            iaccountcontext = IAccountcontext;
        }
    }
}
