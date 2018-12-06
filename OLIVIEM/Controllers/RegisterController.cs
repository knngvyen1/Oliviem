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
            /* viewmodel.registration =*/
            //if (registerlogic.UsernameExists(viewmodel.Username) == true)
            //{
            //    ViewBag.Message = "hai";
            //    return View("../Login/Index");            
            //}
            //else
            //{
            //     = "kutzooi";
            //    registerlogic.AddUser(new User(viewmodel.Name, viewmodel.Lastname, viewmodel.DateOfBirth, viewmodel.Gender, viewmodel.Username, viewmodel.Password, viewmodel.Saldo));
            //    return View("../Register/Index");
            //}

                if (registerlogic.UsernameExists(viewmodel.Username) == true)
                {
                    return View("../Login/Index");
                }
                else
                {
                    registerlogic.AddUser(new Models.Account(viewmodel.Name, viewmodel.Lastname, viewmodel.DateOfBirth, viewmodel.Gender, viewmodel.Username, viewmodel.Password, viewmodel.Saldo));
                    return View("../register/Index");

                }
            


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