using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class LoginController : Controller
    {
        private Loginlogic loginlogic;
        public LoginController()
        {
            loginlogic = Factory.Factory.GetLoginLogic();
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginViewmodel viewmodel)
        {
            
            if (loginlogic.LogIn(viewmodel.Username, viewmodel.Password)== true)
            {
                viewmodel.Messsage = "inloggen gelukt";
                return View("../Home/index");
            }
            else
            {
                viewmodel.Messsage = "Username/password onjuist";
                return View("../Login/index");
            }

        }

    }
}