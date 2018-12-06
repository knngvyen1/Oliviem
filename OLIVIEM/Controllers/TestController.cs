using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Logic;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class TestController : Controller
    {
        private Accountlogic accountlogic;
        public TestController()
        {
            accountlogic = Factory.Factory.GetAccountlogic();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Accountviewmodel viewmodel)
        {
            accountlogic.AddSaldo(viewmodel.Saldo, viewmodel.Id);
            return View(viewmodel);
        }
    }
}