using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Facctory;
using OLIVIEM.Viewmodel;
using Models;

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
            Messageviewmodel messageviewmodel = new Messageviewmodel();
            try
            {
                registerlogic.AddUser(new User(viewmodel.Username, viewmodel.Password));
            }
            catch (Exception)
            {
                messageviewmodel.Message = "wachtwoord is te kort";              
            }
            
            return View(messageviewmodel);
        }







    }
}