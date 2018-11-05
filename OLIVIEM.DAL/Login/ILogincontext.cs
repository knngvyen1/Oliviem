using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL 
{
    public interface ILogincontext
    {
        bool Login(User user);
       
    }
}
