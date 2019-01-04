using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OLIVIEM.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
        [HttpGet]
        public IActionResult GetOrder()
        {
            return View();
        }
    }

}