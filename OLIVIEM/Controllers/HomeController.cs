using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Logic;
using OLIVIEM.Models;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class HomeController : Controller
    {
        private Productlogic productlogic;
        public HomeController()
        {
            productlogic = Factory.Factory.GetProductslogic();
        }
        [HttpGet]
        public IActionResult Index(Productviewmodel viewmodel)
        {
            viewmodel.Categorylist = productlogic.GetAllCategoryNames();
            viewmodel.products = productlogic.GetAllProducts();
            return View(viewmodel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


    }
}
