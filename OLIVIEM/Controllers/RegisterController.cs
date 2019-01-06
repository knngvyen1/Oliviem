using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Models;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class RegisterController : Controller
    {
        private Registerlogic registerlogic;

        public RegisterController()
        {
            registerlogic = Factory.Factory.GetRegisterlogic();
        }
        
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(RegisterViewmodel viewmodel)
        {
            registerlogic.AddUser(new Models.Account(viewmodel.Name, viewmodel.Lastname, viewmodel.DateOfBirth, viewmodel.Gender, viewmodel.Username, viewmodel.Password, viewmodel.Saldo));
            return View("../Login/Index");

            //try
            //{
            //}
            //catch (Exception e)
            //{
            //    viewmodel.message = e.Message;

            //}
            //finally
            //{
            //    viewmodel.Password = "";
            //}
            //return PartialView();


            //return View("../Login/Index");
        }
    }
}