using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Allproducts(Productviewmodel viewmodel)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct()
        {

            return View();
        }
    }
}