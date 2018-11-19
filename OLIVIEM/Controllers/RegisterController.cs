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
            viewmodel.message = "Your account has been created.";
            try
            {
                registerlogic.AddUser(new User(viewmodel.Username, viewmodel.Password));
            }
            catch (Exception e)
            {
                viewmodel.message = e.Message;
                //return ViewBag();
            }
            finally
            {
                viewmodel.Password = "";
            }
            
            return View(viewmodel);
        }









    }
}