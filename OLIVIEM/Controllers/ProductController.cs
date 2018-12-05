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
    public class ProductController : Controller
    {
        private Productlogic productlogic;
        public ProductController()
        {
            productlogic = Factory.Factory.GetProductslogic();
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            var k = productlogic.GetProduct(id);
            Productviewmodel test = new Productviewmodel();
            test.Id = k.id;
            test.Name = k.Name;
            test.Price = k.Price;

            return View(test);
        }
        
        //product ID meegeven
    }
}