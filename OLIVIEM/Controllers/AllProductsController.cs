using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;

namespace OLIVIEM.Controllers
{
    public class AllProductsController : Controller
    {
        private Productlogic productlogic;

        public AllProductsController()
        {
            productlogic = Factory.Factory.GetProductslogic();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProducts()
        {
            productlogic.GetAllProducts();
            return View();
        }
    }
}