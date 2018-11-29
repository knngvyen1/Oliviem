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
            viewmodel.message = "Your account has been created.";
            try
            {
                registerlogic.AddUser(new User(viewmodel.Name, viewmodel.Lastname, viewmodel.DateOfBirth, viewmodel.Gender, viewmodel.Username, viewmodel.Password, viewmodel.Saldo));
            }
            catch (Exception e)
            {
                viewmodel.message = e.Message;
                
            }
            finally
            {
                viewmodel.Password = "";
            }
            return View(viewmodel);
        }
    }
}