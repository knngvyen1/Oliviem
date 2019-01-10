using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Logic;
using OLIVIEM.Models;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class AccountController : Controller
    {
        Accountlogic logic;
        public AccountController()
        {
            logic = Factory.Factory.GetAccountlogic();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addsaldo(Accountviewmodel viewmodel)
        {
            //logic.AddSaldo(viewmodel.Saldo, Session.Id);
            return View(viewmodel);
        }
        [HttpGet]
        public IActionResult Addsaldo()
        {

            return View();
        }

    }
}