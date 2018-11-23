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
    public class AddProductController : Controller
    {
        private Productlogic productlogic;

        public AddProductController()
        {
            productlogic = Facctory.Factory.GetProductslogic();
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AllProducts(Productviewmodel viewmodel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Productviewmodel viewmodel)
        {
            viewmodel.Message = "Product added bitch";
            try
            {
                productlogic.Addproduct(new Product(viewmodel.Name, viewmodel.Size, viewmodel.Color, viewmodel.Price, viewmodel.Quantity));
            }
            catch (Exception e)
            {

                viewmodel.Message = e.Message;
            }
            return View(viewmodel);
        }
    }
}