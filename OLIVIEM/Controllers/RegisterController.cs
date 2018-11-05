using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Facctory;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class RegisterController : Controller
    {

        private Registerlogic registerlogic;
        public RegisterController()
        {
            registerlogic = Factory.GetRegisterlogic();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewmodel viewmodel)
        {
            registerlogic.AddUser(new Models.User(viewmodel.Username, viewmodel.Password));
            return View();
        }



        
    }
}