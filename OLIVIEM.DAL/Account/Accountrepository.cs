using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Account
{
   public class Accountrepository
    {
        private IAccountcontext context;
        public Accountrepository(IAccountcontext Context)
        {
            context = Context;
        }

        public void AddSaldo(double saldo, int id)
        {
            context.AddSaldo(saldo, id);
        }
        public int Getsaldo(int id)
        {
            return context.Getsaldo(id);
        }
    }
}
