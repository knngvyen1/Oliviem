
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OLIVIEM.Models;
using OLIVIEM.utils;
using OLIVIEM.Viewmodel;

namespace OLIVIEM.Controllers
{
    public class CartController : Controller
    {
        private Productlogic productLogic;
       
        public CartController()
        {
            productLogic = Factory.Factory.GetProductslogic();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddItem(int id)
        {
            
            List<int> k = HttpContext.Session.Get<List<int>>("Cart");
            if(k == null)
            {
                k = new List<int>();
            }
            k.Add(id);
            HttpContext.Session.Set("Cart", k);

            return View();
        }

        [HttpGet]
        public IActionResult Items()
       {
            Productviewmodel productViewModel = new Productviewmodel();
            productViewModel.products = new List<Product>();
            List<int> k = HttpContext.Session.Get<List<int>>("Cart");

            if(k == null)
            {
                return View(productViewModel);
            }
            
            
            foreach(int productId in k)
            {
                var product = productLogic.GetProduct(productId);

                productViewModel.products.Add(product);
            }
            return View(productViewModel);
        }
    }
}