using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Models;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class AllProductsController : Controller
    {
        private Productlogic productlogic;
        public List<Product> products = new List<Product>();
        

        public AllProductsController()
        {
            productlogic = Factory.Factory.GetProductslogic();
        }
        public IActionResult Index(Productviewmodel viewmodel)
        {
            viewmodel.products = productlogic.GetAllProducts();
            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult AllProducts(Productviewmodel viewmodel)
        {
            
            
            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult Women(Productviewmodel viewmodel)
        {
            return View(viewmodel);
        }


    }
}