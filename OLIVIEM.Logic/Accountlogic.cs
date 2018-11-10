using OLIVIEM.DAL.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Logic
{
   public class Accountlogic
    {
        private AccountRepository accountrepository;
        public Accountlogic(AccountRepository Accountrepository)
        {
            accountrepository = Accountrepository;
        }

    }
}
