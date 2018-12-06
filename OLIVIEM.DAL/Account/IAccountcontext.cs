using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Account
{
   public interface IAccountcontext
    {
        void AddSaldo(double saldo, int id);
        int Getsaldo(int id);
    }
}
