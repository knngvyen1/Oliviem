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
        private Orderlogic orderLogic;
        public OrderController()
        {
            productLogic = Factory.Factory.GetProductslogic();
            orderLogic = Factory.Factory.GetOrderLogic();
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

        [HttpGet]
        public IActionResult CreateOrder()
        {
            //List<Product> products = new List<Product>;
            //foreach(var product in productViewmodel.products)
            //{

            //}

            var a = new Account
            {
                id = 18
            };
            List<int> k = HttpContext.Session.Get<List<int>>("Cart");
            List<Product> products = new List<Product>();
            if (k == null)
            {
                return View();
            }

            foreach (int productId in k)
            {
                var product = productLogic.GetProduct(productId);

                products.Add(product);
            }
            orderLogic.Creat(products, a);

            return View();
        }

        
    }

}