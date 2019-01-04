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
        public List<Product> products = new List<Product>();
        public ProductController()
        {
            productlogic = Factory.Factory.GetProductslogic();
        }

        public IActionResult Index(Productviewmodel viewmodel)
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Productviewmodel viewmodel)
        {
            try
            {
                productlogic.Addproduct(new Product(viewmodel.Id, viewmodel.Name, viewmodel.Size, viewmodel.Color, viewmodel.Price, viewmodel.Quantity, viewmodel.Description, viewmodel.CategoryName, viewmodel.Image));
            }
            catch (Exception e)
            {

                viewmodel.Message = e.Message;
            }
            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult AllProducts(Productviewmodel viewmodel)
        {
            return View(viewmodel);
        }
    }
}