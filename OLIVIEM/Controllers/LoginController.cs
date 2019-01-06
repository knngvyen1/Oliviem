using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Viewmodel;
using Models;
using OLIVIEM.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

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
                Account account = new Account()
                {
                    id = 2,
                    name = "kechie"
                };

                HttpContext.Session.SetString("AccountSession", JsonConvert.SerializeObject(account));
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