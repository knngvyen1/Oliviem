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
            productlogic = Factory.Factory.GetProductslogic();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct(Productviewmodel viewmodel)
        {
            try
            {
                productlogic.Addproduct(new Product(viewmodel.Id ,viewmodel.Name, viewmodel.Size, viewmodel.Color, viewmodel.Price, viewmodel.Quantity, viewmodel.Description, viewmodel.CategoryID));
            }
            catch (Exception e)
            {

                viewmodel.Message = e.Message;
            }
            return View(viewmodel);
        }
    }
}