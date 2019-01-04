using OLIVIEM.DAL.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Logic
{
   public class Accountlogic
    {
        private Accountrepository accountrepository;
        public Accountlogic(Accountrepository Accountrepository)
        {
            accountrepository = Accountrepository;
        }

        public void AddSaldo(decimal saldo, int id)
        {
            accountrepository.AddSaldo(saldo, id);
        }

        public int Getsaldo(int id)
        {
            return accountrepository.Getsaldo(id);
        }
    }
}
