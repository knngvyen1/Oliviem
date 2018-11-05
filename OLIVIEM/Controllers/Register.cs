using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;

namespace OLIVIEM.Controllers
{
    public class Register : Controller
    {

        private Registerlogic registerlogic;


        public Register()
        {
            registerlogic.
        }
        public IActionResult Index()
        {
            return View();
        }



        
    }
}