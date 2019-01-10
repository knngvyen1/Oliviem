using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OLIVIEM.Models;
using OLIVIEM.utils;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class OrderController : Controller
    {
        private Productlogic productLogic;
        public OrderController()
        {
            productLogic = Factory.Factory.GetProductslogic();
        }
        public IActionResult Index()
        {
            return View();
        }
     
        [HttpGet]
        public IActionResult GetOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Productviewmodel productViewmodel)
        {
            //List<Product> products = new List<Product>;
            //foreach(var product in productViewmodel.products)
            //{

            //}
            Account a = HttpContext.Session.Get<Account>("UserSession");


            return View();
        }

        
    }

}